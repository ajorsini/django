using CMA.StreamerFeed.Models.V1;
using CMA.StreamerFeed.Models.V1.Marketdata.News;
using CMA.StreamerFeedAPI.WinForm.Tester.AuxiliarForms;
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
    public class NewsCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;
        CancellationTokenSource existingCancellationTokenSource;

        public NewsCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void btnNews_Click(object sender, EventArgs e)
        {
            frm.lstNews.Clear();
            if (Uteis.GetHealthCheckStatus(frm) == false)
            {
                return;
            }

            // Parametriza news
            NewsParam newsParam = new NewsParam();
            newsParam.SourceId = int.Parse(frm.txtNewsSourceID.Text);
            newsParam.SubjectFilter = frm.txtNewsSubjectFilter.Text;
            newsParam.TextFilter = frm.txtNewsTextFilter.Text;
            newsParam.Quantity = int.Parse(frm.txtNewsQuantity.Text);
            newsParam.DateFilter = frm.txtNewsDateFilter.Text;
            newsParam.ClientMneMD = frm.txtNewsClientMneMD.Text;
            newsParam.EnableTrace = frm.chkEnableTrace.Checked;
            newsParam.Referer = DateTime.Now;

            if (existingCancellationTokenSource != null)
            {
                Task.Run(() => existingCancellationTokenSource.Cancel()).Wait();
            }

            bool isUpdate = false;

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            if (frm.chkNewsSign.Checked)
            {
                existingCancellationTokenSource = new CancellationTokenSource();

                // Solicitar news com subscrição
                frm.cmaStreamerFeed.News(newsParam, true, existingCancellationTokenSource.Token, 10000).Subscribe(
                async obs =>
                {
                    RenderNewsResponse(await obs, stopWatch, isUpdate);
                    isUpdate = true;
                },
                ex => frm.lstNews.Invoke(new MethodInvoker(delegate { frm.lstNews.Text = ex.Message; }))
                );
            }
            else
            {
                // Solicitar news
                frm.cmaStreamerFeed.News(newsParam, 10000).Subscribe(
                async obs =>
                {
                    RenderNewsResponse(await obs, stopWatch);
                },
                ex => frm.lstNews.Text = ex.Message
                ).Dispose();
            }

        }
        #endregion

        #region Methods
        private void RenderNewsResponse(Result<List<NewsResult>> newsResult, Stopwatch stopWatch, bool isUpdate = false)
        {
            try
            {
                string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                stopWatch.Stop();
                if (frm.boolCalcularTempo)
                {
                    strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                }

                if (frm.chkJson.Checked)
                {
                    strTexto += newsResult.ToJSON();
                }
                else
                {
                    if (newsResult.Status.Success)
                        RenderResponseInGrid(newsResult.Data, isUpdate);

                    if (newsResult.Data.Count > 0)
                    {
                        foreach (NewsResult item in newsResult.Data)
                        {
                            strTexto += "Date=" + item.Date + " Headline=" + item.Headline + " Subject=" + item.Subject + " Body=" + item.Body + "\n\n";
                        }
                    }
                    else
                    {
                        if (newsResult.Status.Success)
                        {
                            strTexto += "Nenhum registro retornado!";
                        }
                        else
                        {
                            strTexto += "Erro - Success=False Code=" + newsResult.Status.Code + " Message=" + newsResult.Status.Message;
                        }
                    }
                }

                if (frm.chkEnableTrace.Checked)
                {
                    strTexto += "\n\nTrace:" + newsResult.Trace?.ToJSON();
                }

                strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";

                frm.lstNews.Invoke(new MethodInvoker(delegate { frm.lstNews.Text = strTexto; }));
            }
            catch (Exception ex)
            {
                frm.lstNews.Invoke(new MethodInvoker(delegate { frm.lstNews.Text = ex.Message; }));
            }
        }

        private void RenderResponseInGrid(List<NewsResult> newsResult, bool isUpdate = false)
        {
            frm.Invoke(new MethodInvoker(delegate
            {
                if (!isUpdate)
                    frm.gridNews.Rows.Clear();

                if (newsResult.Count > 0 && frm.gridNews.Columns.Count == 2)
                {
                    CreateDynamicColumnsOrderList();
                }

                foreach (NewsResult news in newsResult)
                {
                    frm.gridNews.Rows.Insert(0, new DataGridViewRow()
                    {
                        DefaultCellStyle = new DataGridViewCellStyle()
                        {
                            BackColor = GetColorCells(frm.gridNews.Rows.Count)
                        }
                    });

                    foreach (DataGridViewColumn column in frm.gridNews.Columns)
                    {
                        if (column.Name == "HiddenIdNews")
                        {
                            frm.gridNews.Rows[0].Cells[column.Name].Value = news["Source"] + "_" + news["Key"];
                        }
                        else if (column.Name == "Integra")
                        {
                            frm.gridNews.Rows[0].Cells[column.Name].Value = "Ver íntegra";
                        }
                        else
                        {
                            frm.gridNews.Rows[0].Cells[column.Name].Value = news[column.Name];
                        }
                    }
                }
            }));
        }

        public void gridNews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Columns[e.ColumnIndex].Name == "Integra" &&
                e.RowIndex >= 0)
            {
                var source_key = ((string)senderGrid.Rows[e.RowIndex].Cells[0].Value).Split('_');

                if (source_key.Count() == 2)
                {
                    Task.Run(() =>
                    {
                        frm.gridNews.Invoke(new MethodInvoker(delegate
                        {

                            frm.cmaStreamerFeed.News(new NewsBodyParam()
                            {
                                SourceId = Convert.ToInt32(source_key[0]),
                                Key = source_key[1]
                            },
                            10000).Subscribe(
                                async obs =>
                                {
                                    try
                                    {
                                        var result = await obs;
                                        var f = new formToPopUpText();
                                        f.Text = result.Data.Headline;
                                        f.SetText(result.Data.Body);
                                        f.ShowDialog();
                                    }
                                    catch (Exception ex)
                                    {
                                        frm.lstNews.Text = ex.Message;
                                    }
                                },
                                ex => Console.WriteLine(ex.Message)
                            ).Dispose();
                        }));
                    });

                }
            }
        }

        private void CreateDynamicColumnsOrderList()
        {
            frm.gridNews.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            frm.gridNews.Columns.Add("Date", "Date");
            frm.gridNews.Columns.Add("Headline", "Headline");
            frm.gridNews.Columns.Add("Subject", "Subject");
            var index = frm.gridNews.Columns.Add("Body", "Body");
            frm.gridNews.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private System.Drawing.Color GetColorCells(int index)
        {
            Color color;

            if (index % 2 == 0)
                color = Color.White;
            else
                color = Color.LightGray;

            return color;
        }
        #endregion
    }
}
