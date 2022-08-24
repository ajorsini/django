using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public class ApiCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;
        private string EncryptedTokenReceivedFromAcceptor;
        private string DecryptedTokenReceivedFromAcceptor;

        public ApiCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void LoadTab()
        {
            EnableTabs(false);

            frm.txtInstanceName.Text = ConfigurationManager.AppSettings["InstanceName"];
            frm.txtAcceptorUrl.Text = ConfigurationManager.AppSettings["AcceptorUrl"];
            frm.txtDomainId.Text = ConfigurationManager.AppSettings["DomainId"];
            frm.txtUser.Text = ConfigurationManager.AppSettings["User"];
            frm.txtPassword.Text = ConfigurationManager.AppSettings["Password"];
            frm.txtService.Text = ConfigurationManager.AppSettings["Service"];
            frm.txtCustomerId.Text = ConfigurationManager.AppSettings["CustomerId"];
            frm.txtTransport.Text = ConfigurationManager.AppSettings["Transport"];

            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["Channel"]))
            {
                frm.txtChannel.Text = ConfigurationManager.AppSettings["Channel"];
            }
            // Informações de token
            if (ConfigurationManager.AppSettings["LoginTokenSecretKey"] != null)
            {
                frm.txtLoginTokenSecretKey.Text = ConfigurationManager.AppSettings["LoginTokenSecretKey"];
                frm.txtLoginTokenIvKey.Text = ConfigurationManager.AppSettings["LoginTokenIvKey"];
                frm.txtLoginTokenSaltKey.Text = ConfigurationManager.AppSettings["LoginTokenSaltKey"];
                frm.txtLoginTokenSaltIterations.Text = ConfigurationManager.AppSettings["LoginTokenSaltIterations"];
                frm.txtLoginTokenKeyLength.Text = ConfigurationManager.AppSettings["LoginTokenKeyLength"];
            }
        }

        public void btnInstantiate_Click(object sender, EventArgs e)
        {
            try
            {
                frm.btnInstantiate.Enabled = false;

                // Criar estrutura para os parâmetros
                var apiParameters = new CMA.StreamerFeed.Models.V1.InstanceParams();
                apiParameters.InstanceName = frm.txtInstanceName.Text;
                apiParameters.AcceptorUrl = frm.txtAcceptorUrl.Text;
                apiParameters.DomainId = frm.txtDomainId.Text;
                apiParameters.User = frm.txtUser.Text;
                apiParameters.Password = frm.txtPassword.Text;
                apiParameters.Service = frm.txtService.Text;
                apiParameters.CustomerId = frm.txtCustomerId.Text;
                apiParameters.Transport = frm.txtTransport.Text;

                if (!String.IsNullOrEmpty(frm.txtChannel.Text))
                {
                    apiParameters.Channel = frm.txtChannel.Text;
                }

                // Informações de token
                if (!string.IsNullOrEmpty(frm.txtLoginTokenSecretKey.Text))
                {
                    apiParameters.LoginTokenSecretKey = frm.txtLoginTokenSecretKey.Text;
                    apiParameters.LoginTokenIvKey = frm.txtLoginTokenIvKey.Text;
                    apiParameters.LoginTokenSaltKey = frm.txtLoginTokenSaltKey.Text;
                    apiParameters.LoginTokenSaltIterations = frm.txtLoginTokenSaltIterations.Text;
                    apiParameters.LoginTokenKeyLength = frm.txtLoginTokenKeyLength.Text;
                }

                // Instanciar a API do Streamer Feed
                frm.cmaStreamerFeed = CMA.StreamerFeed.Api.Runtime.Instantiate(apiParameters);

                frm.richTextInstantiate.Text = "Inicializando a API...";

                var checkApi = getHealthCheckRecursively();

                if (checkApi.Key == true)
                {

                    frm.richTextInstantiate.Text = "A Api foi instanciada com sucesso! \n\n Detalhes:\n\n";
                    frm.richTextInstantiate.Text += checkApi.Value;

                    string tokens = GetTokensDetails();

                    //frm.richTextInstantiate.Invoke(new MethodInvoker(delegate
                    //{
                    frm.richTextInstantiate.Text += tokens;
                    //}));

                    frm.btnDisconnect.Enabled = true;

                    EnableTabs(true);



                }
                else
                {
                    frm.btnInstantiate.Enabled = true;
                    frm.richTextInstantiate.Text = checkApi.Value;
                    
                    btnDisconnect_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                frm.btnInstantiate.Enabled = true;
                frm.richTextInstantiate.Text = ex.Message;
            }

        }

        public void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                frm.btnDisconnect.Enabled = false;

                frm.cmaStreamerFeed.Detach();

                frm.richTextInstantiate.Text += "\n\nA Api foi desconectada.";

                frm.btnInstantiate.Enabled = true;

                EnableTabs(false);
            }
            catch (Exception ex)
            {
                frm.btnDisconnect.Enabled = true;
                frm.richTextInstantiate.Text = ex.Message;
            }

        }
        #endregion

        #region Methods
        public void EnableTabs(bool enable)
        {
            foreach (TabPage page in frm.tabControl.TabPages)
            {
                if (page.Name != "tabInstantiate")
                {
                    foreach (Control ctl in page.Controls) ctl.Enabled = enable;
                }
            }

            if (!enable)
            {
                frm.tabControl.TabPages["tabInstantiate"].Select();
            }
        }

        private KeyValuePair<bool, string> getHealthCheckRecursively(int numberOfAttempts = 3, int milliseconds = 3000)
        {
            if (numberOfAttempts-- < 1)
            {
                return new KeyValuePair<bool, string>(false, "O número de tentativas de conexão ao acceptor, foi excedido. Verifique sua conexão com a internet. Ou contacte o Administrador do sistema.");
            }

            Task.Delay(milliseconds).Wait();

            var health = Task.Run(() => frm.cmaStreamerFeed.HealthCheck(true).Result).Result;

            if (health.Api.Status)
            {
                EncryptedTokenReceivedFromAcceptor = health.EncryptedTokenReceivedFromAcceptor;
                DecryptedTokenReceivedFromAcceptor = DecodeToken(EncryptedTokenReceivedFromAcceptor);

                return new KeyValuePair<bool, string>(true, JsonConvert.SerializeObject(health, Formatting.Indented));
            }
            else
                return getHealthCheckRecursively(numberOfAttempts, milliseconds);
        }

        private string DecodeToken(string encodedToken)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(encodedToken);

            return JsonConvert.SerializeObject(token.Payload);
        }

        private string GetTokensDetails()
        {
            var sb = new StringBuilder(256);

            var token = frm.cmaStreamerFeed.GetTokenSentToAcceptor();

            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("Detalhamento de tokens:");
            sb.AppendLine();

            if (!string.IsNullOrEmpty(token)) {
                sb.AppendLine("Token encriptado enviado para o Acceptor:");
                sb.AppendLine(token);
                sb.AppendLine();
                sb.AppendLine("Token decriptado enviado para o Acceptor:");
                sb.AppendLine(DecodeToken(token));
            } else
                sb.AppendLine("O Login foi efetuado sem utilização de token.");

            sb.AppendLine();
            sb.AppendLine("Token encriptado recebido do Acceptor:");
            sb.AppendLine(EncryptedTokenReceivedFromAcceptor);
            sb.AppendLine();
            sb.AppendLine("Token decriptado recebido do Acceptor:");
            sb.AppendLine(DecryptedTokenReceivedFromAcceptor);

            return sb.ToString();
        }

        #endregion
    }
}
