using CMA.StreamerFeed.Models.V1;
using CMA.StreamerFeed.Models.V1.Marketdata.Quotes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public class QuotesCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;
        private int HiddenIdQuotes = 0;
        private int IdQuotesTokensIdsMap = 0;
        private Dictionary<int, CancellationTokenSource> QuotesTokens = new Dictionary<int, CancellationTokenSource>();
        private Dictionary<int, List<int>> QuotesTokensIdsMap = new Dictionary<int, List<int>>();

        public QuotesCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void btnQuotes_Click(object sender, EventArgs e)
        {
            frm.lstQuotes.Clear();
            if (Uteis.GetHealthCheckStatus(frm) == false)
            {
                return;
            }
            // Parametriza cotação
            IList<QuotesParam> quotesParamList = new List<QuotesParam>();
            var strSymbols = frm.txtQuotesSymbolID.Text.Trim().Split(',');
            foreach (var strSymbol in strSymbols)
            {
                QuotesParam quotesParam = new QuotesParam();
                quotesParam.SourceID = frm.txtQuotesSourceID.Text;
                quotesParam.SymbolID = strSymbol;
                quotesParam.ClientMneMD = frm.txtQuotesClientMneMD.Text;
                quotesParam.EnableTrace = frm.chkEnableTrace.Checked;
                quotesParam.Referer = DateTime.Now;

                quotesParamList.Add(quotesParam);
            }

            if (frm.chkSign.Checked)
            {
                if (!frm.gridSubscriptions.Visible)
                {
                    frm.lstQuotes.Height -= frm.gridSubscriptions.Height;
                    frm.lstQuotes.Location = new Point(frm.gridSubscriptions.Location.X, frm.gridSubscriptions.Location.Y + frm.gridSubscriptions.Height + 5);
                    frm.gridSubscriptions.Visible = true;
                }

                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                bool newSign = true;

                // Assinar cotações
                frm.cmaStreamerFeed.Quotes(quotesParamList, true, cancellationTokenSource.Token, 10000, frm.chkOnlyDiffQuotes.Checked).Subscribe(
                obs =>
                {
                    RenderQuotesResponse(obs, true, cancellationTokenSource, newSign);

                    newSign = false;
                },
                ex =>
                {
                    frm.lstQuotes.Text = ex.Message;

                    //Cancela assinatura
                    cancellationTokenSource.Cancel();

                });

            }
            else
            {
                if (frm.gridSubscriptions.Visible && frm.gridSubscriptions.Rows.Count < 1)
                {
                    frm.gridSubscriptions.Visible = false;
                    frm.lstQuotes.Location = frm.gridSubscriptions.Location;
                    frm.lstQuotes.Height += frm.gridSubscriptions.Height;
                }

                // Solicitar SNAPSHOT de cotações
                frm.cmaStreamerFeed.Quotes(quotesParamList, 10000).Subscribe(
                obs =>
                {
                    RenderQuotesResponse(obs);
                },
                ex => frm.lstQuotes.Text = ex.Message
                ).Dispose();
            }
        }

        public void gridSubscriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Columns[e.ColumnIndex].Name == "Desassinar" &&
                e.RowIndex >= 0)
            {
                int idToRemove = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                frm.gridSubscriptions.Invoke(new MethodInvoker(delegate
                {
                    //Remove da grid
                    frm.gridSubscriptions.Rows.RemoveAt(e.RowIndex);

                    Task.Run(() =>
                    {
                        //Busca o mapeamento do Token que tenha o Id Mapeado
                        var quotesTokenIdsMap = QuotesTokensIdsMap.FirstOrDefault(q => q.Value.Contains(idToRemove));

                        //Remove o Id do mapeamento
                        quotesTokenIdsMap.Value.Remove(idToRemove);

                        //Entra aqui, caso não exista nenhum outro Id mapeado para este token
                        if (!QuotesTokensIdsMap[quotesTokenIdsMap.Key].Any())
                        {
                            //Remove o mapeamento já sem Ids mapeados
                            QuotesTokensIdsMap.Remove(quotesTokenIdsMap.Key);
                            
                            //Cancela o token
                            QuotesTokens[idToRemove].Cancel();
                        }

                        //Remove o token do dicionário
                        QuotesTokens.Remove(idToRemove);

                    });
                }));
            }
        }
        #endregion

        #region Methods
        private void RenderQuotesResponse(Task<List<Result<QuotesResult>>> obs, bool isSubscription = false, CancellationTokenSource cancellationTokenSource = null, bool newSign = false)
        {
            try
            {
                string strTexto = "";

                if (isSubscription)
                {
                    if (frm.lstQuotes.InvokeRequired)
                    {
                        frm.lstQuotes.Invoke(new MethodInvoker(delegate { strTexto = frm.lstQuotes.Text; }));
                    }
                }

                strTexto += "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n";

                var stopWatch = new Stopwatch();
                stopWatch.Start();
                IList<Result<QuotesResult>> quotesResults = obs.Result;
                stopWatch.Stop();

                if (frm.boolCalcularTempo)
                {
                    strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                }

                //Zero não é utilizado neste contador;
                IdQuotesTokensIdsMap++;

                foreach (Result<QuotesResult> quotesResult in quotesResults)
                {
                    if (isSubscription && cancellationTokenSource != null)
                    {
                        if (quotesResult.Status.Success)
                            //Registra em uma tabela de subscrião, possibilitando o Unsign
                            RegisterSignedQuotesInGrid(cancellationTokenSource, quotesResult, newSign);
                        else
                        {
                            strTexto += "\nAção=" + quotesResult.Data.Symbol.SymbolID
                                        + " ==> Success=False Code=" + quotesResult.Status.Code + " Message=" + quotesResult.Status.Message + "\n";

                        }
                    }
                    else if (frm.chkJson.Checked)
                    {
                        strTexto += "\n" + quotesResult.ToJSON() + "\n";
                    }
                    else
                    {
                        if (quotesResult.Status.Success)
                        {
                            strTexto += "\nAção=" + quotesResult.Data.Symbol.SymbolID + " - " + quotesResult.Data.StockDetail;

                            if (frm.chkSign.Checked && quotesResult.Data.UpdatedFields?.Count != 0)
                            {
                                strTexto += "\n\nCampos Arualizados=" + string.Join(", ", quotesResult.Data.UpdatedFields.ToArray()) + "\n";
                            }

                            strTexto += "\nAskBestOfferBroker=" + quotesResult.Data.AskBestOfferBroker
                                        + "\nAskBestOfferNumber=" + quotesResult.Data.AskBestOfferNumber
                                        + "\nAskBestOfferQty=" + quotesResult.Data.AskBestOfferQty
                                        + "\nAskPrice=" + quotesResult.Data.AskPrice
                                        + "\nAskQty=" + quotesResult.Data.AskQty
                                        + "\nAuctionAsk=" + quotesResult.Data.AuctionAsk
                                        + "\nAuctionBid=" + quotesResult.Data.AuctionBid
                                        + "\nAvgPrice=" + quotesResult.Data.AvgPrice
                                        + "\nBidBestOfferBroker=" + quotesResult.Data.BidBestOfferBroker
                                        + "\nBidBestOfferNumber=" + quotesResult.Data.BidBestOfferNumber
                                        + "\nBidBestOfferQty=" + quotesResult.Data.BidBestOfferQty
                                        + "\nBidPrice=" + quotesResult.Data.BidPrice
                                        + "\nBidQty=" + quotesResult.Data.BidQty
                                        + "\nCalendarDays=" + quotesResult.Data.CalendarDays
                                        + "\nChange=" + quotesResult.Data.Change
                                        + "\nClosePrice=" + quotesResult.Data.ClosePrice
                                        + "\nCumulativeQuantity=" + quotesResult.Data.CumulativeQuantity
                                        + "\nExecDate=" + quotesResult.Data.ExecDate
                                        + "\nExecPrice=" + quotesResult.Data.ExecPrice
                                        + "\nHighPrice=" + quotesResult.Data.HighPrice
                                        + "\nLastDifferential=" + quotesResult.Data.LastDifferential
                                        + "\nLastTradeDate=" + quotesResult.Data.LastTradeDate
                                        + "\nLastTradePrice=" + quotesResult.Data.LastTradePrice
                                        + "\nLastTradeQty=" + quotesResult.Data.LastTradeQty
                                        + "\nLastTradeTime=" + quotesResult.Data.LastTradeTime
                                        + "\nLowPrice=" + quotesResult.Data.LowPrice
                                        + "\nMonthChange=" + quotesResult.Data.MonthChange
                                        + "\nMonthsChange=" + quotesResult.Data.MonthsChange
                                        + "\nOpenContracts=" + quotesResult.Data.OpenContracts
                                        + "\nOpenPrice=" + quotesResult.Data.OpenPrice
                                        + "\nPrevClosePrice=" + quotesResult.Data.PrevClosePrice
                                        + "\nQuoteFactor=" + quotesResult.Data.QuoteFactor
                                        + "\nRemainingDaysToDue=" + quotesResult.Data.RemainingDaysToDue
                                        + "\nReturn=" + quotesResult.Data.Return
                                        + "\nStatus=" + quotesResult.Data.Status
                                        + "\nStockDetail=" + quotesResult.Data.StockDetail
                                        + "\nStockLength=" + quotesResult.Data.StockLength
                                        + "\nTendency=" + quotesResult.Data.Tendency
                                        + "\nTradesCount=" + quotesResult.Data.TradesCount
                                        + "\nVolume=" + quotesResult.Data.Volume
                                        + "\nWorkday=" + quotesResult.Data.Workday
                                        + "\nYearChange=" + quotesResult.Data.YearChange
                                        + "\n-----------------------------------------------------------------------------\n";

                        }
                        else
                        {
                            strTexto += "\nAção=" + quotesResult.Data.Symbol.SymbolID
                                        + " ==> Success=False Code=" + quotesResult.Status.Code + " Message=" + quotesResult.Status.Message + "\n";

                        }
                    }

                    if (frm.chkEnableTrace.Checked && !frm.chkJson.Checked)
                    {
                        strTexto += "\n\nTrace:" + quotesResult.Trace?.ToJSON();
                    }
                }
                strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <== \n\n\n";

                SetQuotesText(strTexto);
            }
            catch (Exception ex)
            {
                SetQuotesText(ex.Message);
            }
        }

        private void RegisterSignedQuotesInGrid(CancellationTokenSource cancellationTokenSource, Result<QuotesResult> quotesResult, bool newSign)
        {
            frm.gridSubscriptions.Invoke(new MethodInvoker(delegate
            {
                if (frm.gridSubscriptions.Columns.Count == 3)
                {
                    CreateDynamicColumnsQuotes();
                }

                if (newSign)
                {
                    int id = HiddenIdQuotes++;

                    frm.gridSubscriptions.Rows.Add(id, "Desassinar", quotesResult.Data.Symbol.SymbolID.ToUpper());

                    //Adicona uma instância do token ao dicionário, associando ao Id
                    QuotesTokens.Add(id, cancellationTokenSource);

                    if (!QuotesTokensIdsMap.ContainsKey(IdQuotesTokensIdsMap))
                        QuotesTokensIdsMap[IdQuotesTokensIdsMap] = new List<int>();

                    //Adiciona o Id ao mapeamento do token
                    QuotesTokensIdsMap[IdQuotesTokensIdsMap].Add(id);

                    frm.gridSubscriptions.Visible = true;
                }

                foreach (DataGridViewRow row in frm.gridSubscriptions.Rows)
                {
                    if (row.Cells.Cast<DataGridViewCell>().First(c => c.OwningColumn.Name == "Ativo")?.Value?.ToString().ToUpper().Contains(quotesResult.Data.Symbol.SymbolID.ToUpper()) == true)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (i > 2 && (newSign || quotesResult.Data.UpdatedFields.Contains(row.Cells[i].OwningColumn.Name)))
                            {
                                var newValue = quotesResult.Data[row.Cells[i].OwningColumn.Name];
                                var oldValue = row.Cells[i].Value;

                                if (oldValue != null)
                                {
                                    if (newValue?.GetType() == typeof(int))
                                    {
                                        row.Cells[i].Style.BackColor = (int)oldValue == (int)newValue ? Color.LightYellow : ((int)oldValue > (int)newValue ? Color.Red : Color.LightGreen);
                                    }
                                    else if (newValue?.GetType() == typeof(double))
                                    {
                                        row.Cells[i].Style.BackColor = (double)oldValue == (double)newValue ? Color.LightYellow : ((double)oldValue > (double)newValue ? Color.Red : Color.LightGreen);
                                    }
                                }

                                row.Cells[i].Value = newValue;
                            }
                        }
                    }
                }
            }));

        }

        private void CreateDynamicColumnsQuotes()
        {
            frm.gridSubscriptions.Columns.Add("AskBestOfferBroker", "AskBestOfferBroker");
            frm.gridSubscriptions.Columns.Add("AskBestOfferNumber", "AskBestOfferNumber");
            frm.gridSubscriptions.Columns.Add("AskBestOfferQty", "AskBestOfferQty");
            frm.gridSubscriptions.Columns.Add("AskPrice", "AskPrice");
            frm.gridSubscriptions.Columns.Add("AskQty", "AskQty");
            frm.gridSubscriptions.Columns.Add("AuctionAsk", "AuctionAsk");
            frm.gridSubscriptions.Columns.Add("AuctionBid", "AuctionBid");
            frm.gridSubscriptions.Columns.Add("AvgPrice", "AvgPrice");
            frm.gridSubscriptions.Columns.Add("BidBestOfferBroker", "BidBestOfferBroker");
            frm.gridSubscriptions.Columns.Add("BidBestOfferNumber", "BidBestOfferNumber");
            frm.gridSubscriptions.Columns.Add("BidBestOfferQty", "BidBestOfferQty");
            frm.gridSubscriptions.Columns.Add("BidPrice", "BidPrice");
            frm.gridSubscriptions.Columns.Add("BidQty", "BidQty");
            frm.gridSubscriptions.Columns.Add("CalendarDays", "CalendarDays");
            frm.gridSubscriptions.Columns.Add("Change", "Change");
            frm.gridSubscriptions.Columns.Add("ClosePrice", "ClosePrice");
            frm.gridSubscriptions.Columns.Add("CumulativeQuantity", "CumulativeQuantity");
            frm.gridSubscriptions.Columns.Add("ExecDate", "ExecDate");
            frm.gridSubscriptions.Columns.Add("ExecPrice", "ExecPrice");
            frm.gridSubscriptions.Columns.Add("HighPrice", "HighPrice");
            frm.gridSubscriptions.Columns.Add("LastDifferential", "LastDifferential");
            frm.gridSubscriptions.Columns.Add("LastTradeDate", "LastTradeDate");
            frm.gridSubscriptions.Columns.Add("LastTradePrice", "LastTradePrice");
            frm.gridSubscriptions.Columns.Add("LastTradeQty", "LastTradeQty");
            frm.gridSubscriptions.Columns.Add("LastTradeTime", "LastTradeTime");
            frm.gridSubscriptions.Columns.Add("LowPrice", "LowPrice");
            frm.gridSubscriptions.Columns.Add("MonthChange", "MonthChange");
            frm.gridSubscriptions.Columns.Add("MonthsChange", "MonthsChange");
            frm.gridSubscriptions.Columns.Add("OpenContracts", "OpenContracts");
            frm.gridSubscriptions.Columns.Add("OpenPrice", "OpenPrice");
            frm.gridSubscriptions.Columns.Add("PrevClosePrice", "PrevClosePrice");
            frm.gridSubscriptions.Columns.Add("QuoteFactor", "QuoteFactor");
            frm.gridSubscriptions.Columns.Add("RemainingDaysToDue", "RemainingDaysToDue");
            frm.gridSubscriptions.Columns.Add("Return", "Return");
            frm.gridSubscriptions.Columns.Add("Status", "Status");
            frm.gridSubscriptions.Columns.Add("StockDetail", "StockDetail");
            frm.gridSubscriptions.Columns.Add("StockLength", "StockLength");
            frm.gridSubscriptions.Columns.Add("Tendency", "Tendency");
            frm.gridSubscriptions.Columns.Add("TradesCount", "TradesCount");
            frm.gridSubscriptions.Columns.Add("Volume", "Volume");
            frm.gridSubscriptions.Columns.Add("Workday", "Workday");
            frm.gridSubscriptions.Columns.Add("YearChange", "YearChange");
        }
        #endregion

        #region Delegates
        delegate void SetQuotesTextCallback(string text);

        private void SetQuotesText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (frm.lstQuotes.InvokeRequired)
            {
                SetQuotesTextCallback d = new SetQuotesTextCallback(SetQuotesText);
                frm.Invoke(d, new object[] { text });
            }
            else
            {
                frm.lstQuotes.Text = text;
            }
        }
        #endregion
    }

}
