using CMA.StreamerFeed.Models.V1;
using CMA.StreamerFeed.Models.V1.Trading.Order.SendOptionExercise;
using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public class SendOptionExerciseCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;

        public SendOptionExerciseCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void btnSendOption_Click(object sender, EventArgs e)
        {
            if (Uteis.GetHealthCheckStatus(frm) == false)
            {
                return;
            }

            // Parametriza filtro
            SendOptionExerciseParam order = new SendOptionExerciseParam();
            order.SymbolId = new SymbolId() { SourceId = frm.txtSourceIdSendOption.Text, Symbol = frm.txtSymbolSendOption.Text };
            order.Signature = frm.txtSignatureSendOption.Text;
            order.Qtty = frm.txtQuantitySendOption.Text;
            order.Confirmation = frm.chkConfirmationSendOption.Checked;
            order.UserId = new UserId()
            {
                User = string.IsNullOrEmpty(frm.txtUserSendOption.Text) ? Convert.ToInt32(frm.txtUserSendOption.Text) : 0,
                UserMne = frm.txtUserMneSendOption.Text
            };

            order.MarketId = new MarketId { Market = frm.cboMarketIdSendOption.SelectedIndex > 0 ? frm.cboMarketIdSendOption.Text : "0"};

            Result <SendOptionExerciseResult> result; ;

            string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            // Solicitar lista de ordem com subscrição
            frm.cmaStreamerFeed.SendOptionExercise(order, 15000).Subscribe(
            obs =>
            {
                try
                {
                    result = obs.Result;
                }
                catch (Exception ex)
                {
                    result = new Result<SendOptionExerciseResult>()
                    {
                        Status = new Status()
                        {
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

                frm.txtResultSendOption.Text += strTexto + JsonConvert.SerializeObject(result, Formatting.Indented);
            },
            ex => frm.txtResultSendOption.Text = ex.Message
            );
        }
        #endregion

        #region Methods

        #endregion
    }
}
