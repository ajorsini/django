using CMA.StreamerFeed.Models.V1;
using CMA.StreamerFeed.Models.V1.Marketdata.QuotesHistory;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public class QuotesHistoryCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;
        private CancellationTokenSource cancellationTokenSource { get; set; }

        public QuotesHistoryCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void btnQuotesHistory_Click(object sender, EventArgs e)
        {
            frm.lstQuotesHistory.Clear();

            // Parametriza gráfico
            QuotesHistoryParam graficoParam = new QuotesHistoryParam();
            graficoParam.SourceID = frm.txtQuotesHistorySourceID.Text;
            graficoParam.SymbolID = frm.txtQuotesHistorySymbolID.Text;
            graficoParam.Period = frm.cboQuotesHistoryPeriod.Text.Trim();
            graficoParam.DateFrom = frm.txtQuotesHistoryDateFrom.Text;
            graficoParam.DateTo = frm.txtQuotesHistoryDateTo.Text;
            graficoParam.ClientMneMD = frm.txtQuotesHistoryCLientMneMD.Text;
            graficoParam.EnableTrace = frm.chkEnableTrace.Checked;

            //if (!frm.cboQuotesHistoryPeriod.Text.Equals("D"))
            //{
            //    graficoParam.DateFrom = graficoParam.DateFrom + " 00:00:00";
            //    graficoParam.DateTo = graficoParam.DateTo + " 24:00:00";
            //}

            //Configurando Gráfico
            frm.formsPlotQuotesHistory.plt.Title("Gráfico de Cotação");
            frm.formsPlotQuotesHistory.plt.YLabel("Preço (R$)");
            frm.formsPlotQuotesHistory.plt.Ticks(dateTimeX: true);

            if (frm.btnQuotesHistory.Text == "Desassinar" && cancellationTokenSource != null)
            {
                frm.btnQuotesHistory.Invoke(new MethodInvoker(delegate
                {
                    frm.btnQuotesHistory.Text = frm.chkQuotesHistorySign.Checked ? "Assinar" : "Buscar";

                    Task.Run(() =>
                    {
                        //Cancela o token
                        cancellationTokenSource.Cancel();
                        cancellationTokenSource = null;
                    });
                }));
            }
            // Solicitar gráfico
            else if (frm.chkQuotesHistorySign.Checked)
            {
                frm.btnQuotesHistory.Text = "Desassinar";

                cancellationTokenSource = new CancellationTokenSource();
                bool isNew = true;

                frm.cmaStreamerFeed.QuotesHistory(graficoParam, true, cancellationTokenSource.Token, 30000).Subscribe(
                    async obs =>
                    {
                        try
                        {
                            Result<List<QuotesHistoryResult>> graficoResult = await obs;

                            RenderInGraph(graficoResult, isNew);
                            RenderInTextArea(graficoResult);

                            isNew = false;
                        }
                        catch (Exception ex)
                        {
                            frm.lstQuotesHistory.Text = ex.Message;

                            frm.btnQuotesHistory.Text = frm.chkQuotesHistorySign.Checked ? "Assinar" : "Buscar";

                            cancellationTokenSource.Cancel();
                            cancellationTokenSource = null;
                        }
                    },
                    ex =>
                    {
                        frm.lstQuotesHistory.Text = ex.Message;
                        frm.btnQuotesHistory.Text = frm.chkQuotesHistorySign.Checked ? "Assinar" : "Buscar";
                        cancellationTokenSource.Cancel();
                    });
            }
            else
            {
                frm.btnQuotesHistory.Text = "Buscar";

                frm.cmaStreamerFeed.QuotesHistory(graficoParam, 30000).Subscribe(
                    async obs =>
                    {
                        try
                        {
                            Result<List<QuotesHistoryResult>> graficoResult = await obs;

                            RenderInGraph(graficoResult);
                            RenderInTextArea(graficoResult);
                        }
                        catch (Exception ex)
                        {
                            frm.lstQuotesHistory.Text = ex.Message;
                        }
                    },
                    ex => frm.lstQuotesHistory.Text = ex.Message
                    ).Dispose();
            }
        }

        public void chkQuotesHistorySign_CheckedChanged(object sender, EventArgs e)
        {
            frm.btnQuotesHistory.Text = cancellationTokenSource != null ? "Desassinar" : (frm.chkQuotesHistorySign.Checked ? "Assinar" : "Buscar");
        }
        #endregion

        #region Methods
        private void RenderInGraph(Result<List<QuotesHistoryResult>> graficoResult, bool isNew = true)
        {
            if (graficoResult.Data.Count > 0)
            {
                frm.Invoke(new MethodInvoker(delegate
                {
                    OHLC[] ohlcs = new OHLC[graficoResult.Data.Count];
                    string dateFormat = frm.cboQuotesHistoryPeriod.Text.ToLower().Contains("d") ||
                                        frm.cboQuotesHistoryPeriod.Text.ToLower().Contains("weekly") ||
                                        frm.cboQuotesHistoryPeriod.Text.ToLower().Contains("monthly") ||
                                        frm.cboQuotesHistoryPeriod.Text.ToLower().Contains("yearly") ? "yyyy-MM-dd" : "yyyy-MM-dd HH:mm:ss";
                    double? lastPointToUpdate = null;

                    if (isNew)
                        frm.formsPlotQuotesHistory.plt.Clear();
                    else
                        lastPointToUpdate = frm.formsPlotQuotesHistory.plt.GetPlottables()?.LastOrDefault()?.GetLimits()?.x1;


                    for (int i = 0; i < graficoResult.Data.Count; i++)
                    {
                        ohlcs[i] = new OHLC(graficoResult.Data[i].Open, graficoResult.Data[i].High, graficoResult.Data[i].Low, graficoResult.Data[i].Close, DateTime.ParseExact(graficoResult.Data[i].Date, dateFormat, System.Globalization.CultureInfo.InvariantCulture));
                    }

                    if (lastPointToUpdate != null && ohlcs.Any(o => o.time == lastPointToUpdate))
                    {
                        frm.formsPlotQuotesHistory.plt.GetPlottables().RemoveAll(p => p.GetLimits().x1 == lastPointToUpdate);
                        frm.formsPlotQuotesHistory.Render();
                    }

                    var existsPlottablesToUpdate = frm.formsPlotQuotesHistory.plt.GetPlottables().Any(p => ohlcs.Any(o => o.time == p.GetLimits().x1));

                    if (existsPlottablesToUpdate)
                    {
                        frm.formsPlotQuotesHistory.plt.GetPlottables().RemoveAll(p => ohlcs.Any(o => o.time == p.GetLimits().x1));
                    }


                    frm.formsPlotQuotesHistory.plt.PlotCandlestick(ohlcs);

                    //if (!isNew)
                    //{
                    //    frm.formsPlotQuotesHistory.Update();
                    //    frm.formsPlotQuotesHistory.Refresh();
                    //}

                    frm.formsPlotQuotesHistory.Render();
                }));
            }
        }

        private void RenderInTextArea(Result<List<QuotesHistoryResult>> graficoResult)
        {
            string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            stopWatch.Stop();
            if (frm.boolCalcularTempo)
            {
                strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
            }
            if (frm.chkJson.Checked)
            {
                strTexto += graficoResult.ToJSON();
            }
            else
            {
                if (graficoResult.Data.Count > 0)
                {
                    foreach (QuotesHistoryResult item in graficoResult.Data)
                    {
                        strTexto += "Date=" + item.Date + "  Open=" + item.Open + "  High="
                                   + item.High + "  Low=" + item.Low + "  Close=" + item.Close
                                   + "  Volume=" + item.Volume + "  AcumulatedQtty=" + item.AcumulatedQtty + "\n";
                    }

                }
                else
                {
                    if (graficoResult.Status.Success)
                    {
                        strTexto += "Nenhum registro retornado!";
                    }
                    else
                    {
                        strTexto += "Erro - Success=False Code=" + graficoResult.Status.Code + " Message=" + graficoResult.Status.Message;
                    }
                }
            }

            if (frm.chkEnableTrace.Checked)
            {
                strTexto += "\n\nTrace:" + graficoResult.Trace?.ToJSON();
            }

            strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";

            frm.lstQuotesHistory.Invoke(new MethodInvoker(delegate
             {
                 frm.lstQuotesHistory.Text = strTexto;
             }));
            //frm.lstQuotesHistory.Text = strTexto;
        }
        #endregion
    }
}
