using CMA.Streamerfeed.Standard.API.Models.V1.Acceptor;
using CMA.StreamerFeed.Models.V1.Acceptor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public class MonitoringCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;

        public MonitoringCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void btnHealthCheck_Click(object sender, EventArgs e)
        {
            frm.lstHealthCheck.Clear();
            // Solicita HealthCheck
            try
            {
                string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                HealthCheck resultHealthCheck = new HealthCheck();
                Task taskHealthCheck = Task.Run(() => { resultHealthCheck = frm.cmaStreamerFeed.HealthCheck(frm.chkHealthCheck.Checked).Result; });
                taskHealthCheck.Wait(10000);
                stopWatch.Stop();
                if (frm.boolCalcularTempo)
                {
                    strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                }
                if (frm.chkJson.Checked)
                {
                    strTexto += JsonConvert.SerializeObject(resultHealthCheck, Formatting.Indented);
                }
                else
                {
                    strTexto += "Informações da API:";
                    strTexto += "\n   InstanceName = " + resultHealthCheck.Api.InstanceName;
                    strTexto += "\n   Status = " + resultHealthCheck.Api.Status.ToString();
                    strTexto += "\n   TimeStamp = " + resultHealthCheck.Api.TimeStamp.ToString();
                    strTexto += "\n   Qtd.Streamers = " + resultHealthCheck.Api.Stats.StreamersQtt.ToString();
                    strTexto += "\n   Qtd.Acceptors = " + resultHealthCheck.Api.Stats.AcceptorsQtt.ToString();
                    if (frm.chkHealthCheck.Checked)
                    {
                        // Analítico
                        strTexto += "\n\nSessões do Streamer (obtidas do acceptor/check):";
                        strTexto += "\n   Success = " + resultHealthCheck.Acceptor.success.ToString();
                        strTexto += "\n   Code = " + resultHealthCheck.Acceptor.code.ToString();
                        strTexto += "\n   ExpirationTime = " + resultHealthCheck.Acceptor.msg?.expirationTime;
                        strTexto += "\n   Shard = " + resultHealthCheck.Acceptor.msg?.shard.ToString();
                        strTexto += "\n";
                        if (resultHealthCheck.Acceptor.msg?.streamerSessionIds.Count > 0)
                        {
                            foreach (AcceptorCheckStreamerSession item in resultHealthCheck.Acceptor.msg?.streamerSessionIds)
                            {
                                strTexto += "\n   Streamer=" + item.streamerId + " Sessão=" + item.sessionId + " Valid=" + item.valid.ToString();
                            }
                        }
                        else
                        {
                            strTexto += "\n   Sem sessões no Streamer!!!";
                        }
                    }
                }
                strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                frm.lstHealthCheck.Text = strTexto;
            }
            catch (Exception ex)
            {
                frm.lstHealthCheck.Text = ex.Message;
            }

        }

        public void btnCheck_Click(object sender, EventArgs e)
        {
            frm.txtCheck.Clear();
            // Solicita Check
            try
            {
                string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                AcceptorCheckResponse resultCheck = new AcceptorCheckResponse();

                Task taskCheck = Task.Run(() => { resultCheck = frm.cmaStreamerFeed.AcceptorCheckSessions().Result; });
                taskCheck.Wait(10000);

                stopWatch.Stop();

                if (frm.boolCalcularTempo)
                {
                    strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                }
                if (frm.chkJson.Checked)
                {
                    strTexto += JsonConvert.SerializeObject(resultCheck, Formatting.Indented);
                }
                else
                {
                    // Analítico
                    strTexto += "\nSessões do Streamer (obtidas do acceptor/check):";
                    strTexto += "\n   Success = " + resultCheck.success.ToString();
                    strTexto += "\n   Code = " + resultCheck.code.ToString();
                    strTexto += "\n   ExpirationTime = " + resultCheck.msg?.expirationTime;
                    strTexto += "\n   Shard = " + resultCheck.msg?.shard.ToString();
                    strTexto += "\n";
                    if (resultCheck.msg?.streamerSessionIds.Count > 0 == true)
                    {
                        foreach (AcceptorCheckStreamerSession item in resultCheck.msg.streamerSessionIds)
                        {
                            strTexto += "\n   Streamer=" + item.streamerId + " Sessão=" + item.sessionId + " Valid=" + item.valid.ToString();
                        }
                    }
                    else
                    {
                        strTexto += "\n   Sem sessões no Streamer!!!";
                    }
                }
                strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                frm.txtCheck.Text = strTexto;
            }
            catch (Exception ex)
            {
                frm.txtCheck.Text = ex.Message;
            }
        }

        public void btnPing_Click(object sender, EventArgs e)
        {
            frm.txtPingRequest.Clear();
            // Solicita Ping
            try
            {
                string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                PingResponse resultPing = new PingResponse();

                //resultCheck = frm.cmaStreamerFeed.AcceptorCheckSessions().Result;
                Task taskCheck = Task.Run(() => { resultPing = frm.cmaStreamerFeed.PingRequest().Result; });
                taskCheck.Wait(10000);

                stopWatch.Stop();

                if (frm.boolCalcularTempo)
                {
                    strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                }

                strTexto += JsonConvert.SerializeObject(resultPing, Formatting.Indented);

                strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                frm.txtPingRequest.Text = strTexto;
            }
            catch (Exception ex)
            {
                frm.txtPingRequest.Text = ex.Message;
            }
        }

        public void btnAudit_Click(object sender, EventArgs e)
        {
            frm.txtAudit.Clear();
            // Solicita Audit
            try
            {
                if (!string.IsNullOrEmpty(frm.txtAdminUser.Text) && !string.IsNullOrEmpty(frm.txtAdminPwd.Text))
                {
                    string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    List<AuditResponse> resultAudit = new List<AuditResponse>();


                    //Task taskCheck = Task.Run(() => { resultAudit = frm.cmaStreamerFeed.Audit("admin", "calvin712").Result; });
                    Task taskCheck = Task.Run(() => { resultAudit = frm.cmaStreamerFeed.Audit(frm.txtAdminUser.Text, frm.txtAdminPwd.Text).Result; });
                    taskCheck.Wait(10000);

                    stopWatch.Stop();

                    if (frm.boolCalcularTempo)
                    {
                        strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                    }

                    strTexto += JsonConvert.SerializeObject(resultAudit, Formatting.Indented);

                    strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                    frm.txtAudit.Text = strTexto;
                }
                else
                {
                    frm.txtAudit.Text = "Os campos admin_user e admin_pwd são obrigatórios";
                }
            }
            catch (Exception ex)
            {
                frm.txtAudit.Text = ex.Message;
            }
        }

        public void btnInstrumentation_Click(object sender, EventArgs e)
        {
            frm.txtInstrumentation.Clear();
            // Solicita Audit
            try
            {
                if (frm.cboInstrumentation.SelectedIndex > -1 && !string.IsNullOrEmpty(frm.txtUserInstrumentation.Text) && !string.IsNullOrEmpty(frm.txtPasswordInstrumentation.Text))
                {
                    string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();

                    if (frm.cboInstrumentation.SelectedIndex == 0)//Instrumentation
                    {
                        InstrumentationResponse result = new InstrumentationResponse();

                        Task taskCheck = Task.Run(() => { result = frm.cmaStreamerFeed.Instrumentation(new InstrumentationParam() { 
                            StreamerId = frm.txtStreamerIdInstrumentation.Text,
                            Username = frm.txtUserInstrumentation.Text,
                            Password = frm.txtPasswordInstrumentation.Text,
                            Class = frm.txtInstrumentationClass.Text,
                            Icase = frm.chkInstrumentationIcase.Checked
                        }).Result; });
                        taskCheck.Wait(30000);

                        stopWatch.Stop();

                        if (frm.boolCalcularTempo)
                        {
                            strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                        }

                        strTexto += JsonConvert.SerializeObject(result, Formatting.Indented);
                    }
                    else
                    {
                        SessionInstrumentationResponse result = new SessionInstrumentationResponse();

                        Task taskCheck = Task.Run(() => {
                            result = frm.cmaStreamerFeed.SessionInstrumentation(new SessionInstrumentationParam()
                            {
                                StreamerId = frm.txtStreamerIdInstrumentation.Text,
                                Username = frm.txtUserInstrumentation.Text,
                                Password = frm.txtPasswordInstrumentation.Text,
                                Action = frm.txtSessioninstrumentationAction.Text,
                                StreamerSessionId = frm.txtSessionStreamerIdInstrumentation.Text,
                            }).Result;
                        });
                        taskCheck.Wait(30000);

                        stopWatch.Stop();

                        if (frm.boolCalcularTempo)
                        {
                            strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                        }

                        strTexto += JsonConvert.SerializeObject(result, Formatting.Indented);
                    }


                    strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                    frm.txtInstrumentation.Text = strTexto;
                }
                else
                {
                    frm.txtInstrumentation.Text = "Os campos Tipo, Username e Password são obrigatórios";
                }
            }
            catch (Exception ex)
            {
                frm.txtInstrumentation.Text = ex.Message;
            }
        }

        internal void cboInstrumentation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frm.cboInstrumentation.SelectedIndex == 0)
            {
                frm.txtSessionStreamerIdInstrumentation.Visible = false;
                frm.lblSessionStreamerId.Visible = false;
                frm.lblSessioninstrumentationAction.Visible = false;
                frm.txtSessioninstrumentationAction.Visible = false;

                frm.chkInstrumentationIcase.Visible = true;
                frm.lblInstrumentationClass.Visible = true;
                frm.txtInstrumentationClass.Visible = true;
            }
            else
            {
                frm.txtSessionStreamerIdInstrumentation.Visible = true;
                frm.lblSessionStreamerId.Visible = true;
                frm.lblSessioninstrumentationAction.Visible = true;
                frm.txtSessioninstrumentationAction.Visible = true;

                frm.chkInstrumentationIcase.Visible = false;
                frm.lblInstrumentationClass.Visible = false;
                frm.txtInstrumentationClass.Visible = false;
            }
        }
        #endregion

        #region Methods

        #endregion
    }
}
