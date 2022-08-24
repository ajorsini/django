using CMA.StreamerFeed.Models.V1;
using CMA.StreamerFeed.Models.V1.Trading.Order.OrderList;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public class OrderListCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;
        CancellationTokenSource existingCancellationTokenSource;

        public OrderListCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void btnOrderList_Click(object sender, EventArgs e)
        {
            frm.lstOrderList.Clear();
            if (Uteis.GetHealthCheckStatus(frm) == false)
            {
                return;
            }
            // Parametriza filtro
            OrderListParam orderListParam = new OrderListParam();
            orderListParam.ClientIdFilter = Convert.ToInt64(frm.txtOrderListClientIdFilter.Text);
            orderListParam.ClientMneFilter = frm.txtOrderListClientMneFilter.Text;
            orderListParam.OfferIdFilter1 = frm.txtOrderListOfferIdFilter1.Text;
            orderListParam.ListType = frm.cboOrderListListType.Text;
            if (!String.IsNullOrEmpty(frm.cboOrderListOfferMarketIdFilter.Text))
            {
                orderListParam.MarketIdFilter = int.Parse(frm.cboOrderListOfferMarketIdFilter.Text);
            }
            orderListParam.OfferMasterId = frm.txtOrderListOfferIdFilter1.Text;
            orderListParam.DaysToList = int.Parse(frm.txtOrderListDaysToList.Text);
            orderListParam.OfferStatusFilter = frm.txtOrderListOfferStatusFilter.Text;
            orderListParam.SearchHistory = false;
            orderListParam.OnlySelectedClients = (frm.chkOrderListClientLinked.Checked ? 3 : 0);
            orderListParam.EnableTrace = frm.chkEnableTrace.Checked;
            orderListParam.Referer = DateTime.Now;

            if (existingCancellationTokenSource != null)
                existingCancellationTokenSource.Cancel();

            existingCancellationTokenSource = new CancellationTokenSource();

            frm.cmaStreamerFeed.Order(orderListParam, 10000).Subscribe(
                obs =>
                {
                    try
                    {
                        RenderOrderListResponse(orderListParam, obs);
                    }
                    catch (Exception ex)
                    {
                        frm.lstOrderList.Text = ex.Message;
                    }
                },
                ex => frm.lstOrderList.Text = ex.Message
                ).Dispose();
        }
        #endregion

        #region Methods
        private void RenderOrderListResponse(OrderListParam orderListParam, Task<Result<List<OrderListResult>>> obs)
        {
            string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Result<List<OrderListResult>> orderListResults = obs.Result;
            stopWatch.Stop();

            if (frm.boolCalcularTempo)
            {
                strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
            }

            RenderResponseInGrid(orderListParam, orderListResults.Data);

            if (frm.chkJson.Checked)
            {
                strTexto += orderListResults.ToJSON();
            }
            else
            {
                strTexto += ((orderListParam.ListType == "G") ? "Ordens Agrupadas:\n\n" : "Orderns Desagrupadas:\n\n");
                if (orderListResults.Data.Count > 0)
                {
                    foreach (OrderListResult item in orderListResults.Data)
                    {

                        if (orderListParam.ListType == "G")
                        {
                            // Agrupada
                            strTexto += "#" + item.OrderId
                                + " UserMne=" + item.UserId.UserMne
                                + " Side=" + item.Side
                                + " Symb=" + item.SymbolId.SymbolID
                                + " Qtd=" + item.Qtty
                                + " Prç=" + item.LimitPrice
                                + " Vlr=" + item.Value
                                + " Status=" + item.Status
                                + " Qtd.Conf=" + item.ConfirmedQtty
                                + " Qtd.Canc=" + item.CancelQtty
                                + " Qtd.Exp=" + item.ExpiredQtty
                                + "\n";
                        }
                        else
                        {
                            // Desagrupada
                            strTexto += "#" + item.OrderId
                                + " UserMne=" + item.UserId.UserMne
                                + " Side=" + item.Side
                                + " Symb=" + item.SymbolId.SymbolID
                                + " Qtd.Status=" + item.Qtty
                                + " Vlr.Status=" + item.Value
                                + " Status=" + item.Status;
                            if (item.Status == "C")
                            {
                                strTexto += " Preço.Conf=" + item.ConfirmedPrice;
                            }
                            strTexto += "\n";
                        }
                    }
                }
                else
                {
                    if (orderListResults.Status.Success)
                    {
                        strTexto += "Nenhum registro retornado!";
                    }
                    else
                    {
                        strTexto += "Erro - Success=False Code=" + orderListResults.Status.Code + " Message=" + orderListResults.Status.Message;
                    }
                }
            }

            if (frm.chkEnableTrace.Checked)
            {
                strTexto += "\n\nTrace:" + orderListResults.Trace?.ToJSON();
            }

            strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";

            frm.lstOrderList.Invoke(new MethodInvoker(delegate { frm.lstOrderList.Text = strTexto; }));
        }

        private void RenderResponseInGrid(OrderListParam orderListParam, List<OrderListResult> orderListResults)
        {
            frm.Invoke(new MethodInvoker(delegate
            {
                frm.gridOrderList.Rows.Clear();
                frm.gridOrderList.Columns.Clear();

                if (orderListResults.Count > 0)
                {
                    CreateDynamicColumnsOrderList(orderListParam.ListType);
                }

                foreach (OrderListResult order in orderListResults)
                {
                    int indexRow = frm.gridOrderList.Rows.Add(new DataGridViewRow()
                    {
                        DefaultCellStyle = new DataGridViewCellStyle()
                        {
                            BackColor = GetColorCells(order)
                        }
                    });

                    foreach (DataGridViewColumn column in frm.gridOrderList.Columns)
                    {
                        frm.gridOrderList.Rows[indexRow].Cells[column.Name].Value = order[column.Name];
                    }
                }
            }));
        }

        private System.Drawing.Color GetColorCells(OrderListResult order)
        {
            Color color = Color.White;

            switch (order.Status.ToUpper())
            {
                case "P":
                    color = Color.Yellow;
                    break;
                case "E":
                    color = Color.LightGreen;
                    break;
                case "C":
                    color = Color.LightBlue;
                    break;
                case "X":
                    color = Color.Red;
                    break;
            }

            return color;
        }

        private void CreateDynamicColumnsOrderList(string listType)
        {
            frm.gridOrderList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            if (listType == "G")
            {
                // Agrupada
                frm.gridOrderList.Columns.Add("UserId>UserMne", "UserMne");
                frm.gridOrderList.Columns.Add("Side", "Side");
                frm.gridOrderList.Columns.Add("SymbolId>SymbolID", "Symb");
                frm.gridOrderList.Columns.Add("Qtty", "Qtd");
                frm.gridOrderList.Columns.Add("LimitPrice", "Prç");
                frm.gridOrderList.Columns.Add("Value", "Vlr");
                frm.gridOrderList.Columns.Add("Status", "Status");
                frm.gridOrderList.Columns.Add("ConfirmedQtty", "Qtd.Conf");
                frm.gridOrderList.Columns.Add("CancelQtty", "Qtd.Canc");
                frm.gridOrderList.Columns.Add("ExpiredQtty", "Qtd.Exp");
            }
            else
            {
                // Desagrupada
                frm.gridOrderList.Columns.Add("UserMne", "UserMne");
                frm.gridOrderList.Columns.Add("Side", "Side");
                frm.gridOrderList.Columns.Add("SymbolID", "Symb");
                frm.gridOrderList.Columns.Add("Qtty", "Qtd.Status");
                frm.gridOrderList.Columns.Add("Value", "Vlr.Status");
                frm.gridOrderList.Columns.Add("Status", "Status");
                frm.gridOrderList.Columns.Add("ConfirmedPrice", "Preço.Conf");
            }
        }
        #endregion
    }
}
