using CMA.StreamerFeed.Models.V1;
using CMA.StreamerFeed.Models.V1.LoadTest;
using CMA.StreamerFeed.Models.V1.Marketdata.Quotes;
using CMA.StreamerFeed.Models.V1.Provider;
using CMA.StreamerFeed.Models.V1.Trading.Order.OrderSingle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public class LoadTestCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;
        private int HiddenIdTest = 0;
        private int IdTestTokensIdsMap = 0;
        private Dictionary<int, CancellationTokenSource> TestTokens = new Dictionary<int, CancellationTokenSource>();
        private Dictionary<int, List<int>> TestTokensIdsMap = new Dictionary<int, List<int>>();

        public LoadTestCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void btnAddLoadTest_Click(object sender, EventArgs e)
        {
            frm.txtLoadTest.Clear();

            frm.txtLoadTest.Text = "Solicitação em andamento, aguarde o retorno...";
            if (Uteis.GetHealthCheckStatus(frm) == false)
            {
                return;
            }

            LoadTestParam loadTestParam = new LoadTestParam()
            {
                QttActors = (int)frm.numQtdAtores.Value,
                Sign = frm.chkSignLoadTest.Checked
            };

            if (frm.rbTestQuotes.Checked)
            {

                QuotesParam quotesParam = new QuotesParam();
                quotesParam.SourceID = "12";
                quotesParam.SymbolID = "PETR4";
                quotesParam.ClientMneMD = frm.txtQuotesClientMneMD.Text; //TODO: Alterar
                quotesParam.EnableTrace = frm.chkEnableTrace.Checked;
                quotesParam.Referer = DateTime.Now;

                loadTestParam.Quotes = quotesParam;
            }

            if (frm.rbTestOrder.Checked)
            {
                //TODO: Parametrizar cotação
                var strSymbol = "PETR4";

                OrderSingleParam orderSingleParam = new OrderSingleParam();
                orderSingleParam.UserId.User = 0;
                orderSingleParam.UserId.UserMne = "00001";
                orderSingleParam.Symbol = strSymbol;
                orderSingleParam.Side = "B";
                orderSingleParam.Qtty = "100";
                orderSingleParam.Price = "20.00";
                orderSingleParam.TypeOffer = "Market";
                orderSingleParam.TriggerType = "None";
                orderSingleParam.ValidityType = "Today";
                orderSingleParam.Validity = DateTime.Now.ToString("yyyy-mm-dd");
                orderSingleParam.TypeMarket = "12010";
                orderSingleParam.Confirmation = false;
                orderSingleParam.PlaceDateType = "Today";
                orderSingleParam.QuotesLastPrice = "20.00";
                orderSingleParam.QuotesTime = "10:00:00";
                orderSingleParam.IpRemote = ConfigurationManager.AppSettings["IpRemote"];
                orderSingleParam.HostName = ConfigurationManager.AppSettings["HostName"];
                orderSingleParam.Signature = ConfigurationManager.AppSettings["Signature"];
                orderSingleParam.TradeChannel = frm.txtOrderNewTradeChannel.Text;
                orderSingleParam.EnableTrace = frm.chkEnableTrace.Checked;
                orderSingleParam.Referer = DateTime.Now;

                loadTestParam.Order = orderSingleParam;
            }

            if (frm.chkSignLoadTest.Checked)
            {
                var millisecondsToLooping = (int)frm.txtMillisecondsToLoopingTest.Value;

                if (!frm.gridSubscriptionsLoadTest.Visible)
                {
                    frm.txtLoadTest.Height -= frm.gridSubscriptionsLoadTest.Height;
                    frm.txtLoadTest.Location = new Point(frm.gridSubscriptionsLoadTest.Location.X, frm.gridSubscriptionsLoadTest.Location.Y + frm.gridSubscriptionsLoadTest.Height + 5);
                    frm.gridSubscriptionsLoadTest.Visible = true;
                }

                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                bool newSign = true;

                // Assinar cotações
                frm.cmaStreamerFeed.LoadTest(loadTestParam, cancellationTokenSource.Token, millisecondsToLooping, 10000).Subscribe(
                obs =>
                {
                    RenderLoadTestResponse(obs, true, cancellationTokenSource, newSign, millisecondsToLooping);

                    newSign = false;
                },
                ex =>
                {
                    frm.txtLoadTest.Text = ex.Message;

                    //Cancela assinatura
                    cancellationTokenSource.Cancel();

                });

            }
            else
            {
                if (frm.gridSubscriptionsLoadTest.Visible && frm.gridSubscriptionsLoadTest.Rows.Count < 1)
                {
                    frm.gridSubscriptionsLoadTest.Visible = false;
                    frm.txtLoadTest.Location = frm.gridSubscriptionsLoadTest.Location;
                    frm.txtLoadTest.Height += frm.gridSubscriptionsLoadTest.Height;
                }

                // Solicitar SNAPSHOT de test
                frm.cmaStreamerFeed.LoadTest(loadTestParam, default).Subscribe(
                obs =>
                {
                    RenderLoadTestResponse(obs);
                },
                ex => frm.txtLoadTest.Text = ex.Message
                ).Dispose();
            }
        }

        public void gridSubscriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Columns[e.ColumnIndex].Name == "UnsignLoadTest" &&
                e.RowIndex >= 0)
            {
                int idToRemove = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                frm.gridSubscriptionsLoadTest.Invoke(new MethodInvoker(delegate
                {
                    //Remove da grid
                    frm.gridSubscriptionsLoadTest.Rows.RemoveAt(e.RowIndex);

                    Task.Run(() =>
                    {
                        //Busca o mapeamento do Token que tenha o Id Mapeado
                        var testTokensIdsMap = TestTokensIdsMap.FirstOrDefault(q => q.Value.Contains(idToRemove));

                        //Remove o Id do mapeamento
                        testTokensIdsMap.Value.Remove(idToRemove);

                        //Entra aqui, caso não exista nenhum outro Id mapeado para este token
                        if (!TestTokensIdsMap[testTokensIdsMap.Key].Any())
                        {
                            //Remove o mapeamento já sem Ids mapeados
                            TestTokensIdsMap.Remove(testTokensIdsMap.Key);

                            //Cancela o token
                            TestTokens[idToRemove].Cancel();
                        }

                        //Remove o token do dicionário
                        TestTokens.Remove(idToRemove);

                    });
                }));
            }
        }
        #endregion

        public void chkSignLoadTest_CheckedChanged(object sender, EventArgs e)
        {
            frm.txtMillisecondsToLoopingTest.Enabled = frm.chkSignLoadTest.Checked;
        }

        #region Methods
        private void RenderLoadTestResponse(Task<Result<LoadTestResult>> obs, bool isSubscription = false, CancellationTokenSource cancellationTokenSource = null, bool newSign = false, int millisecondsToLooping = 5000)
        {
            try
            {
                string strTexto = "";

                if (isSubscription)
                {
                    if (frm.txtLoadTest.InvokeRequired)
                    {
                        frm.txtLoadTest.Invoke(new MethodInvoker(delegate { strTexto = frm.txtLoadTest.Text; }));
                    }
                }

                strTexto += "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n";

                var stopWatch = new Stopwatch();
                stopWatch.Start();
                Result<LoadTestResult> loadTestResult = obs.Result;
                stopWatch.Stop();

                if (frm.boolCalcularTempo)
                {
                    strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                }

                //Zero não é utilizado neste contador;
                IdTestTokensIdsMap++;

                if (isSubscription && cancellationTokenSource != null)
                {
                    if (loadTestResult.Status.Success)
                        //Registra em uma tabela de subscrião, possibilitando o Unsign
                        RegisterSignedLoadTestInGrid(cancellationTokenSource, loadTestResult, newSign, millisecondsToLooping);
                    else
                    {
                        strTexto += loadTestResult.ToJSON();

                    }
                }
                else if (frm.chkJson.Checked)
                {
                    strTexto += "\n" + loadTestResult.ToJSON() + "\n";
                }
                else
                {
                    strTexto += loadTestResult.ToJSON();
                }

                if (frm.chkEnableTrace.Checked && !frm.chkJson.Checked)
                {
                    strTexto += "\n\nTrace:" + loadTestResult.Trace?.ToJSON();
                }

                strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <== \n\n\n";

                SetQuotesText(strTexto);
            }
            catch (Exception ex)
            {
                SetQuotesText(ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        private void RegisterSignedLoadTestInGrid(CancellationTokenSource cancellationTokenSource, Result<LoadTestResult> quotesResult, bool newSign, int millisecondsToLooping)
        {
            frm.gridSubscriptionsLoadTest.Invoke(new MethodInvoker(delegate
            {
                if (frm.gridSubscriptionsLoadTest.Columns.Count == 5)
                {
                    CreateDynamicColumnsQuotes();
                }

                if (newSign)
                {
                    int id = HiddenIdTest++;

                    frm.gridSubscriptionsLoadTest.Rows.Add(id, "Desassinar", quotesResult.Data.LoadTestId, quotesResult.Data.QttActors, millisecondsToLooping);

                    //Adicona uma instância do token ao dicionário, associando ao Id
                    TestTokens.Add(id, cancellationTokenSource);

                    if (!TestTokensIdsMap.ContainsKey(IdTestTokensIdsMap))
                        TestTokensIdsMap[IdTestTokensIdsMap] = new List<int>();

                    //Adiciona o Id ao mapeamento do token
                    TestTokensIdsMap[IdTestTokensIdsMap].Add(id);

                    frm.gridSubscriptionsLoadTest.Visible = true;
                }

                foreach (DataGridViewRow row in frm.gridSubscriptionsLoadTest.Rows)
                {
                    if (row.Cells.Cast<DataGridViewCell>().First(c => c.OwningColumn.Name == "LoadTestId")?.Value?.ToString().Contains(quotesResult.Data.LoadTestId.ToString()) == true)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (i > 4 /*&& (newSign || quotesResult.Data.UpdatedFields.Contains(row.Cells[i].OwningColumn.Name))*/)
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
            frm.gridSubscriptionsLoadTest.Columns.Add("OrderMinStreamerLatency", "OrderMinStreamerLatency");
            frm.gridSubscriptionsLoadTest.Columns.Add("OrderMaxStreamerLatency", "OrderMaxStreamerLatency");
            frm.gridSubscriptionsLoadTest.Columns.Add("OrderAvgStreamerLatency", "OrderAvgStreamerLatency");
            frm.gridSubscriptionsLoadTest.Columns.Add("OrderMinExchangeIntegrationLatency", "OrderMinExchangeIntegrationLatency");
            frm.gridSubscriptionsLoadTest.Columns.Add("OrderMaxExchangeIntegrationLatency", "OrderMaxExchangeIntegrationLatency");
            frm.gridSubscriptionsLoadTest.Columns.Add("OrderAvgExchangeIntegrationLatency", "OrderAvgExchangeIntegrationLatency"); 
            frm.gridSubscriptionsLoadTest.Columns.Add("QuotesMinStreamerLatency", "QuotesMinStreamerLatency");
            frm.gridSubscriptionsLoadTest.Columns.Add("QuotesMaxStreamerLatency", "QuotesMaxStreamerLatency");
            frm.gridSubscriptionsLoadTest.Columns.Add("QuotesAvgStreamerLatency", "QuotesAvgStreamerLatency");
            
            //frm.gridSubscriptionsLoadTest.Columns.Add("OrderIdList", "OrderIdList");
        }
        #endregion

        #region Delegates
        delegate void SetQuotesTextCallback(string text);

        private void SetQuotesText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (frm.txtLoadTest.InvokeRequired)
            {
                SetQuotesTextCallback d = new SetQuotesTextCallback(SetQuotesText);
                frm.Invoke(d, new object[] { text });
            }
            else
            {
                frm.txtLoadTest.Text = text;
            }
        }
        #endregion
    }

}
