using CMA.StreamerFeed.Models.V1;
using CMA.StreamerFeed.Models.V1.Marketdata.Book;
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
    public class BookCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;
        private int HiddenIdBook = 0;
        private Dictionary<int, CancellationTokenSource> BookTokens = new Dictionary<int, CancellationTokenSource>();

        public BookCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void btnBook_Click(object sender, EventArgs e)
        {
            frm.lstBook.Clear();
            if (Uteis.GetHealthCheckStatus(frm) == false)
            {
                return;
            }
            // Parametriza book
            BookParam bookParam = new BookParam();
            bookParam.SourceId = frm.txtBookSourceID.Text;
            bookParam.SymbolID = frm.txtBookSymbolID.Text;
            bookParam.Deep = frm.txtBookDeep.Text;
            bookParam.Consolidate = frm.cboBookConsolidate.Text == "true";
            bookParam.ClientMneMD = frm.txtBookClientMneMD.Text;
            bookParam.EnableTrace = frm.chkEnableTrace.Checked;
            bookParam.Referer = DateTime.Now;

            if (frm.btnBook.Text == "Desassinar" && BookTokens.Any())
            {
                frm.gridSubscriptionsBook.Invoke(new MethodInvoker(delegate
                {
                    frm.btnBook.Text = frm.chkBookSign.Checked ? "Assinar" : "Buscar";

                    Task.Run(() =>
                    {
                        //Cancela o token
                        BookTokens[HiddenIdBook].Cancel();
                        BookTokens.Remove(HiddenIdBook);

                    });
                }));


            }
            else if (frm.chkBookSign.Checked)
            {
                frm.btnBook.Text = "Desassinar";

                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                bool newSign = true;

                if (!frm.gridSubscriptionsBook.Visible)
                {
                    frm.lstBook.Height -= frm.gridSubscriptionsBook.Height;
                    frm.lstBook.Location = new Point(frm.gridSubscriptionsBook.Location.X, frm.gridSubscriptionsBook.Location.Y + frm.gridSubscriptionsBook.Height + 5);
                    frm.gridSubscriptionsBook.Visible = true;
                }


                // Solicitar Assinatura de book
                frm.cmaStreamerFeed.Book(bookParam, true, cancellationTokenSource.Token, 10000).Subscribe(
                obs =>
                {
                    RenderBookResponse(bookParam, obs, true, cancellationTokenSource, newSign);
                    newSign = false;
                },
                ex =>
                {
                    frm.lstBook.Text = ex.Message;
                    frm.btnBook.Text = frm.chkBookSign.Checked ? "Assinar" : "Buscar";

                    //Cancela assinatura
                    cancellationTokenSource.Cancel();
                });

            }
            else
            {
                frm.btnBook.Text = "Buscar";

                if (frm.gridSubscriptionsBook.Visible && frm.gridSubscriptionsBook.Rows.Count < 1)
                {
                    frm.gridSubscriptionsBook.Visible = false;
                    frm.lstBook.Location = frm.gridSubscriptionsBook.Location;
                    frm.lstBook.Height += frm.gridSubscriptionsBook.Height;
                }

                // Solicitar SNAPSHOT de book
                frm.cmaStreamerFeed.Book(bookParam, 10000).Subscribe(
                obs =>
                {
                    RenderBookResponse(bookParam, obs);
                },
                ex => frm.lstBook.Text = ex.Message
                ).Dispose();
            }
        }

        public void gridSubscriptionsBook_DataGridViewCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //var senderGrid = (DataGridView)sender;

            if (e.RowIndex == 0)
            {
                e.CellStyle.BackColor = Color.Gray;
                e.CellStyle.ForeColor = Color.White;
            }
            if (e.RowIndex == 1)
            {
                if (e.ColumnIndex < 4)
                {
                    e.CellStyle.BackColor = Color.FromArgb(234, 200, 30);
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(26, 187, 38);
                    e.CellStyle.ForeColor = Color.White;
                }
            }

        }

        public void chkBookSign_CheckedChanged(object sender, EventArgs e)
        {
            frm.btnBook.Text = BookTokens.Count > 0 ? "Desassinar" : (frm.chkBookSign.Checked ?  "Assinar" : "Buscar");
        }
        #endregion

        #region Methods
        private async void RenderBookResponse(BookParam bookParam, Task<Result<BookResult>> obs, bool isSubscription = false, CancellationTokenSource cancellationTokenSource = null, bool newSign = false)
        {
            try
            {
                string strTexto = "";

                if (isSubscription)
                {
                    if (frm.lstBook.InvokeRequired)
                    {
                        frm.lstBook.Invoke(new MethodInvoker(delegate { strTexto = frm.lstBook.Text; }));
                    }
                }

                strTexto += "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                Result<BookResult> bookResult = await obs;
                stopWatch.Stop();

                strTexto += "Symbol = " + bookParam.SymbolID + "\n\n";

                if (frm.boolCalcularTempo)
                {
                    strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                }

                if (isSubscription && cancellationTokenSource != null)
                {
                    if (bookResult.Status.Success)
                        if (bookResult.Data.BuyOffers.Count > 0 || bookResult.Data.SellOffers.Count > 0)
                            //Registra em uma tabela de subscrião, possibilitando o Unsign
                            RegisterSignedBookInGrid(bookParam, cancellationTokenSource, bookResult, newSign);
                        else
                        {
                            strTexto += "\nAção=" + bookResult.Data.SymbolId.SymbolID
                                        + " ==> Success=False Code=" + bookResult.Status.Code + " Message=" + bookResult.Status.Message + "\n";
                        }
                }
                else if (frm.chkJson.Checked)
                {
                    strTexto += bookResult.ToJSON();
                }
                else
                {
                    if (bookResult.Data.BuyOffers.Count > 0 || bookResult.Data.SellOffers.Count > 0)
                    {
                        strTexto += "---------- Ofertas de Compra ---------- \n";
                        foreach (BookOfferItem item in bookResult.Data.BuyOffers)
                        {
                            strTexto += (bookParam.Consolidate ? "" : ("Agente=" + item.Agent + "-" + item.AgentName + " ")) + "Qtd=" + item.Quantity + " Preço=" + item.Price + (!bookParam.Consolidate ? "" : (" OfferCount=" + item.OfferCount)) + "\n";
                        }
                        strTexto += "\n\n---------- Ofertas de Venda ---------- \n";
                        foreach (BookOfferItem item in bookResult.Data.SellOffers)
                        {
                            strTexto += (bookParam.Consolidate ? "" : ("Agente=" + item.Agent + "-" + item.AgentName + " ")) + "Qtd=" + item.Quantity + " Preço=" + item.Price + (!bookParam.Consolidate ? "" : (" OfferCount=" + item.OfferCount)) + "\n";
                        }
                    }
                    else
                    {
                        if (bookResult.Status.Success)
                        {
                            strTexto += "Nenhum registro retornado!";
                        }
                        else
                        {
                            strTexto += "Erro - Success=False Code=" + bookResult.Status.Code + " Message=" + bookResult.Status.Message;
                        }
                    }
                }

                if (frm.chkEnableTrace.Checked)
                {
                    strTexto += "\n\nTrace:" + bookResult.Trace?.ToJSON();
                }

                strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n\n";

                //frm.lstBook.Text = strTexto;
                frm.lstBook.Invoke(new MethodInvoker(delegate { frm.lstBook.Text = strTexto; }));
            }
            catch (Exception ex)
            {
                //frm.lstBook.Text = ex.Message;
                frm.lstBook.Invoke(new MethodInvoker(delegate { frm.lstBook.Text = ex.Message; }));
            }
        }

        private void RegisterSignedBookInGrid(BookParam bookParam, CancellationTokenSource cancellationTokenSource, Result<BookResult> bookResult, bool newSign)
        {
            frm.gridSubscriptionsBook.Invoke(new MethodInvoker(delegate
            {
                if (frm.gridSubscriptionsBook.Columns.Count == 0)
                {
                    CreateDynamicColumnsBook(bookParam);
                }

                frm.gridSubscriptionsBook.Rows.Clear();
                frm.gridSubscriptionsBook.Rows.Add("Ativo: " + bookResult.Data.SymbolId.SymbolID.ToUpper());
                frm.gridSubscriptionsBook.Rows.Add("Ofertas de Compra", "", "", "", "Ofertas de Venda", "", "", "");

                if (newSign)
                {
                    int id = ++HiddenIdBook;

                    //Limitando book a uma assinatura por vez
                    if (BookTokens.Any())
                    {
                        //Unsign para assinatura já existente
                        frm.gridSubscriptionsBook.Invoke(new MethodInvoker(delegate
                        {
                            Task.Run(() =>
                            {
                                //Cancela o token
                                BookTokens[HiddenIdBook - 1].Cancel();
                                BookTokens.Remove(HiddenIdBook - 1);

                            });
                        }));
                    }

                    BookTokens.Add(id, cancellationTokenSource);

                    frm.gridSubscriptionsBook.Visible = true;
                }

                foreach (BookOfferItem item in bookResult.Data.BuyOffers)
                {
                    //strTexto += (bookParam.Consolidate ? "" : ("Agente=" + item.Agent + "-" + item.AgentName + " ")) + "Qtd=" + item.Quantity + " Preço=" + item.Price + (!bookParam.Consolidate ? "" : (" OfferCount=" + item.OfferCount)) + "\n";
                    frm.gridSubscriptionsBook.Rows.Add(item.Agent + "-" + item.AgentName, item.Quantity, item.Price, item.OfferCount);
                }

                //Inicia na segunda linha, pois as 2 primeiras são informativas
                var countLines = 2;

                foreach (BookOfferItem item in bookResult.Data.SellOffers)
                {
                    //strTexto += (bookParam.Consolidate ? "" : ("Agente=" + item.Agent + "-" + item.AgentName + " ")) + "Qtd=" + item.Quantity + " Preço=" + item.Price + (!bookParam.Consolidate ? "" : (" OfferCount=" + item.OfferCount)) + "\n";

                    if (countLines > frm.gridSubscriptionsBook.Rows.Count)
                        frm.gridSubscriptionsBook.Rows.Add("", "", "", "", item.Agent + "-" + item.AgentName, item.Quantity, item.Price, item.OfferCount);
                    else
                        frm.gridSubscriptionsBook.Rows[countLines].SetValues(
                            frm.gridSubscriptionsBook.Rows[countLines].Cells[0].Value,
                            frm.gridSubscriptionsBook.Rows[countLines].Cells[1].Value,
                            frm.gridSubscriptionsBook.Rows[countLines].Cells[2].Value,
                            frm.gridSubscriptionsBook.Rows[countLines].Cells[3].Value,
                            item.Agent + "-" + item.AgentName, item.Quantity, item.Price, item.OfferCount);

                    countLines++;
                }
            }));

        }

        private void CreateDynamicColumnsBook(BookParam bookParam)
        {
            frm.gridSubscriptionsBook.CellBorderStyle = DataGridViewCellBorderStyle.None;
            frm.gridSubscriptionsBook.Columns.Add("Agente", "Agent");
            frm.gridSubscriptionsBook.Columns.Add("Qtd", "Quantity");
            frm.gridSubscriptionsBook.Columns.Add("Preço", "Price"); //TODO: " Preço=" + item.Price + (!bookParam.Consolidate ? "" : (" OfferCount=" + item.OfferCount)) + "\n";
            frm.gridSubscriptionsBook.Columns.Add("OfferCount", "OfferCount");
            frm.gridSubscriptionsBook.Columns.Add("Agente", "Agent");
            frm.gridSubscriptionsBook.Columns.Add("Qtd", "Quantity");
            frm.gridSubscriptionsBook.Columns.Add("Preço", "Price"); //TODO: " Preço=" + item.Price + (!bookParam.Consolidate ? "" : (" OfferCount=" + item.OfferCount)) + "\n";
            frm.gridSubscriptionsBook.Columns.Add("OfferCount", "OfferCount");
        }
        #endregion
    }
}
