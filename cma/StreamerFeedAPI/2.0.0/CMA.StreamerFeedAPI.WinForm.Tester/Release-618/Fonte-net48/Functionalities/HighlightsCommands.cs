using CMA.StreamerFeed.Models.V1;
using CMA.StreamerFeed.Models.V1.Marketdata.Highlights;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public class HighlightsCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;
        CancellationTokenSource existingCancellationTokenSource;

        public HighlightsCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void FillControls(WinFormAPITester.frmWinFormAPITester frm)
        {
            frm.cboTipoRelatorioHighlight.ValueMember = "Key";
            frm.cboTipoRelatorioHighlight.DisplayMember = "Value";
            frm.cboTipoRelatorioHighlight.DataSource =
                new BindingList<KeyValuePair<string, string>>() {
                    new KeyValuePair<string, string>("1", "Maiores Compradores/Vendedores por Contrato"),
                    new KeyValuePair<string, string>("2", "Ativos Mais Negociados por Agente"),
                    new KeyValuePair<string, string>("3", "Negócios por Agente"),
                    new KeyValuePair<string, string>("4", "Negócios por Agente Acumulado"),
                    new KeyValuePair<string, string>("5", "Negócios Cruzados: Agente X Contrato"),
                    new KeyValuePair<string, string>("6", "Maiores Altas"),
                    new KeyValuePair<string, string>("7", "Maiores Baixas"),
                    new KeyValuePair<string, string>("8", "Mais Negociadas"),
                    new KeyValuePair<string, string>("9", "Resumo de Negócios por Preço Médio") };

            frm.cboMarketHighlight.ValueMember = "Key";
            frm.cboMarketHighlight.DisplayMember = "Value";
            frm.cboMarketHighlight.DataSource =
                new BindingList<KeyValuePair<string, string>>() {
                    new KeyValuePair<string, string>("X", "Não definido"),
                    new KeyValuePair<string, string>("E", "Exercício de opções"),
                    new KeyValuePair<string, string>("F", "Ação fracionário"),
                    new KeyValuePair<string, string>("G", "Geral"),
                    new KeyValuePair<string, string>("I", "Índice"),
                    new KeyValuePair<string, string>("J", "Índice de opções"),
                    new KeyValuePair<string, string>("O", "Opção"),
                    new KeyValuePair<string, string>("R", "Outros"),
                    new KeyValuePair<string, string>("T", "Termo"),
                    new KeyValuePair<string, string>("U", "Futuro"),
                    new KeyValuePair<string, string>("V", "Ação vista")};

            frm.txtHighLightsDateFrom.Text = DateTime.Now.ToString("yyyy-MM-dd");
            frm.txtHighLightsDateTo.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        public void btnBuscarHighlights_Click(object sender, EventArgs e)
        {
            frm.lstHighlight.Clear();
            if (Uteis.GetHealthCheckStatus(frm) == false)
            {
                return;
            }
            // Parametriza filtro
            HighlightsParam highlightsParam = new HighlightsParam();
            //highlightsParam.ClientMneFilter = frm.txtHighlightsClientMneFilter.Text;

            if (!String.IsNullOrEmpty(frm.cboTipoRelatorioHighlight.Text))
            {
                highlightsParam.Kind = int.Parse(frm.cboTipoRelatorioHighlight.SelectedValue.ToString());
            }

            if (!String.IsNullOrEmpty(frm.cboMarketHighlight.Text))
            {
                highlightsParam.Market = frm.cboMarketHighlight.SelectedValue.ToString();
            }

            highlightsParam.Symbol = frm.txtSymbolHighlight.Text;
            highlightsParam.Source = int.Parse(frm.txtSourceHighlight.Text);
            highlightsParam.Max = int.Parse(frm.txtMaxResultHighlight.Text);
            highlightsParam.Broker = frm.txtBrokerHighlight.Text;
            highlightsParam.DateFrom = string.IsNullOrEmpty(frm.txtHighLightsDateFrom.Text) ? "" : frm.txtHighLightsDateFrom.Text.Replace("-", "");
            highlightsParam.DateTo = string.IsNullOrEmpty(frm.txtHighLightsDateTo.Text) ? "" : frm.txtHighLightsDateTo.Text.Replace("-", "");
            highlightsParam.EnableTrace = frm.chkEnableTrace.Checked;
            highlightsParam.Referer = DateTime.Now;

            if (existingCancellationTokenSource != null)
                existingCancellationTokenSource.Cancel();

            existingCancellationTokenSource = new CancellationTokenSource();

            if (frm.chkHighlightsSign.Checked)
            {
                var newSign = true;
                // Solicitar lista de ordem com subscrição
                frm.cmaStreamerFeed.Highlights(highlightsParam, true, existingCancellationTokenSource.Token, 1000, 10000).Subscribe(
                obs =>
                {
                    try
                    {
                        RenderHighlightsResponse(highlightsParam, obs, newSign);
                        newSign = false;
                    }
                    catch (Exception ex)
                    {
                        frm.lstHighlight.Invoke(new MethodInvoker(delegate { frm.lstHighlight.Text = ex.Message; }));
                    }
                },
                ex => frm.lstHighlight.Text = ex.Message
                );
            }
            else
            {
                //Solicitar Lista de Ordem
                frm.cmaStreamerFeed.Highlights(highlightsParam, false, new CancellationToken()).Subscribe(
                obs =>
                {
                    try
                    {
                        RenderHighlightsResponse(highlightsParam, obs);
                    }
                    catch (Exception ex)
                    {
                        frm.lstHighlight.Text = ex.Message;
                    }
                },
                ex => frm.lstHighlight.Text = ex.Message
                ).Dispose();
            }
        }
        #endregion

        #region Methods
        private void RenderHighlightsResponse(HighlightsParam highlightsParam, Task<Result<HighlightsResult>> obs, bool newSign = false)
        {
            string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Result<HighlightsResult> highlightsResults = obs.Result;
            stopWatch.Stop();

            if (newSign)
            {
                frm.Invoke(new MethodInvoker(delegate
                {
                    frm.gridHighlights.Rows.Clear();
                    frm.gridHighlights.Columns.Clear();
                }));
            }

            if (frm.boolCalcularTempo)
            {
                strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
            }

            if (frm.chkJson.Checked)
            {
                strTexto += highlightsResults.ToJSON();
            }
            else
            {
                if (highlightsResults.Data?.Report != null && highlightsResults.Data.Report.Count > 0)
                {
                    RenderResponseInGrid(highlightsParam, highlightsResults.Data);

                    foreach (HighlightReportResult item in highlightsResults.Data.Report)
                    {
                        // Agrupada
                        strTexto += "#" + item.Symbol
                            + " Agent=" + item.Agent
                            + " AvgBuyPrice=" + item.AvgBuyPrice
                            + " AvgSellPrice=" + item.AvgSellPrice
                            + " AvgPrice=" + item.AvgPrice
                            + " Buys=" + item.Buys
                            + " Delta=" + item.Delta
                            + " Last=" + item.Last
                            + " Qtd.Liquid=" + item.Liquid
                            + " Qtd.Market=" + item.Market
                            + " Qtd.Maximum=" + item.Maximum
                            + " Qtd.Minimum=" + item.Minimum
                            + " Qtd.Percent=" + item.Percent
                            + " Qtd.Quantity=" + item.Quantity
                            + " Qtd.Sells=" + item.Sells
                            + " Qtd.Side=" + item.Side
                            + " Qtd.Time=" + item.Time
                            + " Qtd.Volume=" + item.Volume
                            + "\n";
                    }
                }
                else
                {
                    if (highlightsResults.Status.Success)
                    {
                        strTexto += "Nenhum registro retornado!";
                    }
                    else
                    {
                        strTexto += "Erro - Success=False Code=" + highlightsResults.Status.Code + " Message=" + highlightsResults.Status.Message;
                    }
                }
            }

            if (frm.chkEnableTrace.Checked)
            {
                strTexto += "\n\nTrace:" + highlightsResults.Trace?.ToJSON();
            }

            strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";

            frm.lstHighlight.Invoke(new MethodInvoker(delegate { frm.lstHighlight.Text = strTexto; }));
        }

        private void RenderResponseInGrid(HighlightsParam highlightsParam, HighlightsResult highlightsResults)
        {
            frm.Invoke(new MethodInvoker(delegate
            {
                frm.gridHighlights.Rows.Clear();

                if (highlightsResults.Report.Count > 0)
                {
                    if (frm.gridHighlights.Columns.Count < 1)
                        CreateDynamicColumnsHighlights(highlightsParam);

                    int count = 0;
                    foreach (HighlightReportResult highlight in highlightsResults.Report)
                    {
                        int indexRow = frm.gridHighlights.Rows.Add(new DataGridViewRow()
                        {
                            DefaultCellStyle = new DataGridViewCellStyle()
                            {
                                BackColor = GetColorCells(count++)
                            }
                        });

                        foreach (DataGridViewColumn column in frm.gridHighlights.Columns)
                        {
                            frm.gridHighlights.Rows[indexRow].Cells[column.Name].Value = highlight[column.Name];
                        }
                    }
                }
            }));
        }

        private System.Drawing.Color GetColorCells(int index)
        {
            Color color = Color.White;

            if (index % 2 == 0)
                color = Color.LightGray;

            return color;
        }

        private void CreateDynamicColumnsHighlights(HighlightsParam param)
        {
            frm.gridHighlights.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            switch (param.Kind)
            {
                case 1:
                    frm.gridHighlights.Columns.Add("Side", "Side");
                    frm.gridHighlights.Columns.Add("Agent", "Agent");
                    frm.gridHighlights.Columns.Add("Volume", "Volume");
                    frm.gridHighlights.Columns.Add("Quantity", "Quantity");
                    frm.gridHighlights.Columns.Add("", "");
                    frm.gridHighlights.Columns.Add("AvgPrice", "AvgPrice");
                    break;
                case 2:
                    frm.gridHighlights.Columns.Add("Side", "Side");
                    frm.gridHighlights.Columns.Add("Symbol", "Symbol");
                    frm.gridHighlights.Columns.Add("Volume", "Volume");
                    frm.gridHighlights.Columns.Add("Quantity", "Quantity");
                    break;
                case 3:
                    frm.gridHighlights.Columns.Add("Side", "Side");
                    frm.gridHighlights.Columns.Add("Time", "Time");
                    frm.gridHighlights.Columns.Add("Symbol", "Symbol");
                    frm.gridHighlights.Columns.Add("Last", "Last");
                    frm.gridHighlights.Columns.Add("Quantity", "Quantity");
                    frm.gridHighlights.Columns.Add("Agent", "Agent");
                    break;
                case 4:
                    frm.gridHighlights.Columns.Add("Side", "Side");
                    frm.gridHighlights.Columns.Add("Agent", "Agent");
                    frm.gridHighlights.Columns.Add("Quantity", "Quantity");
                    break;
                case 5:
                    frm.gridHighlights.Columns.Add("Side", "Side");
                    frm.gridHighlights.Columns.Add("Time", "Time");
                    frm.gridHighlights.Columns.Add("Last", "Last");
                    frm.gridHighlights.Columns.Add("Quantity", "Quantity");
                    frm.gridHighlights.Columns.Add("Agent", "Agent");
                    break;
                case 6:
                case 7:
                case 8:
                    frm.gridHighlights.Columns.Add("Market", "Market");
                    frm.gridHighlights.Columns.Add("Symbol", "Symbol");
                    frm.gridHighlights.Columns.Add("Last", "Last");
                    frm.gridHighlights.Columns.Add("Percent", "Percent");
                    frm.gridHighlights.Columns.Add("Delta", "Delta");
                    frm.gridHighlights.Columns.Add("Quantity", "Quantity");
                    frm.gridHighlights.Columns.Add("Volume", "Volume");
                    frm.gridHighlights.Columns.Add("Maximum", "Maximum");
                    frm.gridHighlights.Columns.Add("Minimum", "Minimum");
                    break;
                case 9:
                    frm.gridHighlights.Columns.Add("Agent", "Agent");
                    frm.gridHighlights.Columns.Add("Buys", "Buys");
                    frm.gridHighlights.Columns.Add("AvgBuyPrice", "AvgBuyPrice");
                    frm.gridHighlights.Columns.Add("Sells", "Sells");
                    frm.gridHighlights.Columns.Add("AvgSellPrice", "AvgSellPrice");
                    frm.gridHighlights.Columns.Add("Liquid", "Liquid");
                    frm.gridHighlights.Columns.Add("AvgPrice", "AvgPrice");
                    break;
                default:
                    break;

            }
        }
        #endregion
    }
}
