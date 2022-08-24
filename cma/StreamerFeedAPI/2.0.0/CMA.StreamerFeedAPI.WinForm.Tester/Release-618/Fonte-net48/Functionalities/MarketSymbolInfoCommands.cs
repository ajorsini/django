using CMA.Streamerfeed.Standard.API.Models.V1.Marketdata.Symbol;
using CMA.StreamerFeed.Models.V1;
using CMA.StreamerFeed.Models.V1.Marketdata.Symbol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public class MarketSymbolInfoCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;

        public MarketSymbolInfoCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void btnMarketSymbolInfo_Click(object sender, EventArgs e)
        {
            frm.txtMarketSymbolInfo.Clear();
            // Solicita Check
            try
            {
                string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                var stopWatch = new Stopwatch();
                stopWatch.Start();

                List<string> symbols = frm.txtMarketSymbolId.Text.Split(',').Where(s => !string.IsNullOrEmpty(s.Trim())).ToList();

                if (symbols == null)
                {
                    frm.txtMarketSymbolInfo.Text = "Nenhum valor válido para Symbol foi digitado.";

                    return;
                }

                if (string.IsNullOrEmpty(frm.txtMarketSymbolSourceId.Text))
                {
                    frm.txtMarketSymbolInfo.Text = "Nenhum valor para SourceId foi digitado.";

                    return;
                }

                Result<List<MarketSymbolInfoResult>> result; ;

                // Solicitar SNAPSHOT de MarketSymbol
                frm.cmaStreamerFeed.MarketSymbolInfo(new MarketSymbolInfoParam() { Symbols = symbols, SourceId = frm.txtMarketSymbolSourceId.Text }, 30000).Subscribe(
                obs =>
                {
                    try
                    {
                        result = obs.Result;
                    }
                    catch (Exception ex){
                        result = new Result<List<MarketSymbolInfoResult>>() {
                            Status = new Status() {
                                Success = false,
                                Message = ex.Message + "\n" + ex.InnerException?.Message
                            }
                        };
                    }

                    stopWatch.Stop();

                    if (frm.boolCalcularTempo)
                    {
                        strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                    }

                    frm.txtMarketSymbolInfo.Text += strTexto + JsonConvert.SerializeObject(result, Formatting.Indented);
                }, 
                onError: ex =>
                {
                    frm.txtMarketSymbolInfo.Text = ex.Message;
                }).Dispose();

            }
            catch (Exception ex)
            {
                frm.txtMarketSymbolInfo.Text = ex.Message;
            }
        }

        #endregion

        #region Methods

        #endregion
    }
}
