using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using CMA.StreamerFeed.Models.Interfaces;
using CMA.StreamerFeed.Models.V1;
using CMA.StreamerFeed.Models.V1.Acceptor;
using CMA.StreamerFeed.Models.V1.Marketdata.Symbol;
using CMA.StreamerFeed.Models.V1.Trading.ClientList;
using CMA.StreamerFeed.Models.V1.Trading.Order.OrderSingle;
using CMA.StreamerFeed.Models.V1.Trading.Order.OrderReplace;
using CMA.StreamerFeed.Models.V1.Trading.Order.OrderCancel;
using CMA.StreamerFeed.Models.V1.Trading.Portfolio;
using CMA.StreamerFeed.Models.V1.Trading.RuleVerifyQuotes;
using CMA.StreamerFeed.Models.V1.Trading.FinancialStatements;
using System.IO;
using CMA.StreamerFeedAPI.WinForm.Tester.Functionalities;
using Newtonsoft.Json;
using CMA.Streamerfeed.Standard.API.Models.V1.Acceptor;

namespace WinFormAPITester
{
    public partial class frmWinFormAPITester : Form
    {
        public IRuntimeInstance cmaStreamerFeed { get; set; }
        public bool boolCalcularTempo = false;
        protected QuotesCommands quotesCommands { get; set; }
        protected BookCommands bookCommands { get; set; }
        protected QuotesHistoryCommands quotesHistoryCommands { get; set; }
        protected OrderListCommands orderListCommands { get; set; }
        protected NewsCommands newsCommands { get; set; }
        protected HighlightsCommands highlightsCommands { get; set; }
        protected ApiCommands apiCommands { get; set; }
        protected MonitoringCommands monitoringCommands { get; set; }
        protected MarketSymbolInfoCommands marketSymbolInfoCommands { get; set; }
        protected SendOptionExerciseCommands sendOptionExerciseCommands { get; set; }
        protected ProviderCommands providerCommands { get; set; }
        protected LoadTestCommands loadTestCommands { get; set; }

        public frmWinFormAPITester()
        {
            quotesCommands = new QuotesCommands(this);
            bookCommands = new BookCommands(this);
            quotesHistoryCommands = new QuotesHistoryCommands(this);
            orderListCommands = new OrderListCommands(this);
            newsCommands = new NewsCommands(this);
            highlightsCommands = new HighlightsCommands(this);
            apiCommands = new ApiCommands(this);
            monitoringCommands = new MonitoringCommands(this);
            marketSymbolInfoCommands = new MarketSymbolInfoCommands(this);
            sendOptionExerciseCommands = new SendOptionExerciseCommands(this);
            providerCommands = new ProviderCommands(this);
            loadTestCommands = new LoadTestCommands(this);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSymbolMarket.SelectedIndex = 0;
            cboBookConsolidate.SelectedIndex = 1;
            cboQuotesHistoryPeriod.SelectedIndex = 7;
            txtQuotesHistoryDateFrom.Text = DateTime.Today.AddDays(-7).ToString("yyyy-MM-dd");
            txtQuotesHistoryDateTo.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtNewsDateFilter.Text = DateTime.Now.ToString("yyyy-MM-dd");
            cboOrderNewTypeOffer.SelectedIndex = 0;
            cboOrderNewSide.SelectedIndex = 0;
            cboOrderNewMarketId.SelectedIndex = 5;
            cboOrderReplaceTypeOffer.SelectedIndex = 0;
            cboOrderListListType.SelectedIndex = 0;
            cboOrderListOfferMarketIdFilter.SelectedIndex = 6;
            cboClientFilterType.SelectedIndex = 2;
            cboPortfolioPortfolioType.SelectedIndex = 1;
            cboPortfolioPortfolioMarketId.SelectedIndex = 6;
            cboRuleVerifyQuotesSide.SelectedIndex = 0;
            cboInstrumentation.SelectedIndex = 0;
            cboMarketIdSendOption.SelectedIndex = 5;

            // Removendo tabs de Book e News
            if (ConfigurationManager.AppSettings["QuotesAll"] == null || ConfigurationManager.AppSettings["QuotesAll"] != "S")
            {
                tabControl.TabPages.Remove(tabBook);
                tabControl.TabPages.Remove(tabNews);
                tabControl.TabPages.Remove(tabQuotesHistory);
            }
            // Removendo tab LoadTest
            if (ConfigurationManager.AppSettings["LoadTest"] == null || ConfigurationManager.AppSettings["LoadTest"] != "S")
            {
                tabControl.TabPages.Remove(tabLoadTest);
            }
            try
            {
                apiCommands.LoadTab();

                // Calcular tempo em ms
                if (ConfigurationManager.AppSettings["CalcularTempo"] != null)
                {
                    boolCalcularTempo = ConfigurationManager.AppSettings["CalcularTempo"].ToUpper() == "S";
                }
            }
            catch (Exception ex)
            {
                // Tratar exception
                lstQuotes.Text = ex.Message;
            }

            highlightsCommands.FillControls(this);
            providerCommands.FillControls();

        }

        #region Quotes
        private void btnQuotes_Click(object sender, EventArgs e)
        {
            quotesCommands.btnQuotes_Click(sender, e);
        }

        private void gridSubscriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            quotesCommands.gridSubscriptions_CellContentClick(sender, e);
        }
        #endregion

        #region Book
        private void btnBook_Click(object sender, EventArgs e)
        {
            bookCommands.btnBook_Click(sender, e);
        }

        public void gridSubscriptionsBook_DataGridViewCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            bookCommands.gridSubscriptionsBook_DataGridViewCellFormatting(sender, e);
        }
        #endregion

        #region QuotesHistory
        public void btnQuotesHistory_Click(object sender, EventArgs e)
        {
            quotesHistoryCommands.btnQuotesHistory_Click(sender, e);
        }
        #endregion

        #region News
        private void btnNews_Click(object sender, EventArgs e)
        {
            newsCommands.btnNews_Click(sender, e);
        }

        private void gridNews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            newsCommands.gridNews_CellContentClick(sender, e);
        }
        #endregion

        private void btnSymbol_Click(object sender, EventArgs e)
        {
            lstSymbol.Clear();
            if (Uteis.GetHealthCheckStatus(this) == false)
            {
                return;
            }
            // Parametriza símbolo
            SymbolSearchParam symbolSearchParam = new SymbolSearchParam();
            symbolSearchParam.SourceId = txtSymbolSourceID.Text;
            symbolSearchParam.SymbolID = txtSymbol.Text;
            symbolSearchParam.Description = txtSymbolDescription.Text;
            symbolSearchParam.Market = cboSymbolMarket.Text;
            symbolSearchParam.EnableTrace = chkEnableTrace.Checked;
            symbolSearchParam.Referer = DateTime.Now;
            // Solicitar símbolos
            cmaStreamerFeed.SymbolSearch(symbolSearchParam, 10000).Subscribe(
            async obs =>
            {
                try
                {
                    string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Result<List<SymbolSearchResult>> symbolSearchResult = await obs;
                    stopWatch.Stop();
                    if (boolCalcularTempo)
                    {
                        strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                    }
                    if (chkJson.Checked)
                    {
                        strTexto += symbolSearchResult.ToJSON();
                    }
                    else
                    {
                        if (symbolSearchResult.Data.Count > 0)
                        {
                            foreach (SymbolSearchResult item in symbolSearchResult.Data)
                            {
                                strTexto += item.Symbol + " ==>" + item.Market + "<== " + item.Description + "\n";
                            }
                        }
                        else
                        {
                            if (symbolSearchResult.Status.Success)
                            {
                                strTexto += "Nenhum registro retornado!";
                            }
                            else
                            {
                                strTexto += "Erro - Success=False Code=" + symbolSearchResult.Status.Code + " Message=" + symbolSearchResult.Status.Message;
                            }
                        }
                    }

                    if (chkEnableTrace.Checked)
                    {
                        strTexto += "\n\nTrace:" + symbolSearchResult.Trace?.ToJSON();
                    }

                    strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                    lstSymbol.Text = strTexto;
                }
                catch (Exception ex)
                {
                    lstSymbol.Text = ex.Message;
                }
            },
            ex => lstSymbol.Text = ex.Message
            ).Dispose();
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            lstClient.Clear();
            if (Uteis.GetHealthCheckStatus(this) == false)
            {
                return;
            }
            // Parametriza clientes
            ClientListParam clientListParam = new ClientListParam();
            if (txtClientAssessorId.Text != "")
            {
                long lngAux = 0;
                long.TryParse(txtClientAssessorId.Text, out lngAux);
                clientListParam.AssessorId = lngAux;
                txtClientAssessorId.Text = lngAux.ToString();
            }
            if (txtClientBranchId.Text != "")
            {
                long lngAux = 0;
                long.TryParse(txtClientBranchId.Text, out lngAux);
                clientListParam.BranchId = lngAux;
                txtClientBranchId.Text = lngAux.ToString();
            }
            clientListParam.FilterType = cboClientFilterType.Text;
            clientListParam.FilterData = txtClientFilterData.Text;
            clientListParam.EnableTrace = chkEnableTrace.Checked;
            clientListParam.Referer = DateTime.Now;
            // Solicitar clientes
            cmaStreamerFeed.Client(clientListParam, 10000).Subscribe(
            obs =>
            {
                try
                {
                    string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Result<List<ClientListResult>> clientListResult = obs.Result;
                    stopWatch.Stop();
                    if (boolCalcularTempo)
                    {
                        strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                    }
                    if (chkJson.Checked)
                    {
                        strTexto += clientListResult.ToJSON();
                    }
                    else
                    {
                        if (clientListResult.Data.Count > 0)
                        {
                            foreach (ClientListResult item in clientListResult.Data)
                            {
                                strTexto += "Id=" + item.Id
                                    + "  Mnemonic=" + item.Mnemonic
                                    + "  Name=" + item.Name
                                    + "  Enabled=" + item.Enabled
                                    + "  Email=" + item.Email
                                    + "\n";
                            }
                        }
                        else
                        {
                            if (clientListResult.Status.Success)
                            {
                                strTexto += "Nenhum registro retornado!";
                            }
                            else
                            {
                                strTexto += "Erro - Success=False Code=" + clientListResult.Status.Code + " Message=" + clientListResult.Status.Message;
                            }
                        }
                    }

                    if (chkEnableTrace.Checked)
                    {
                        strTexto += "\n\nTrace:" + clientListResult.Trace?.ToJSON();
                    }

                    strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                    lstClient.Text = strTexto;
                }
                catch (Exception ex)
                {
                    lstClient.Text = ex.Message;
                }
            },
            ex => lstClient.Text = ex.Message
            ).Dispose();
        }

        private void btnOrderNew_Click(object sender, EventArgs e)
        {
            lstOrderNew.Clear();
            if (Uteis.GetHealthCheckStatus(this) == false)
            {
                return;
            }
            // Parametriza ordem
            OrderSingleParam orderSingleParam = new OrderSingleParam();
            orderSingleParam.UserId.User = long.Parse(txtOrderNewUserId.Text);
            orderSingleParam.UserId.UserMne = txtOrderNewUserMne.Text;
            orderSingleParam.Symbol = txtOrderNewSymbol.Text;
            orderSingleParam.Side = cboOrderNewSide.Text;
            orderSingleParam.Qtty = txtOrderNewQtty.Text;
            orderSingleParam.Price = txtOrderNewPrice.Text;
            orderSingleParam.TypeOffer = cboOrderNewTypeOffer.Text;
            orderSingleParam.TriggerType = "None";
            orderSingleParam.ValidityType = "Today";
            orderSingleParam.Validity = DateTime.Now.ToString("yyyy-mm-dd");
            orderSingleParam.TypeMarket = cboOrderNewMarketId.Text;
            orderSingleParam.Confirmation = false;
            orderSingleParam.PlaceDateType = "Today";
            orderSingleParam.QuotesLastPrice = txtOrderNewQuotes.Text;
            if (cboOrderNewTypeOffer.Text == "Market")
            {
                // Necessário enviar cotação!
                orderSingleParam.QuotesLastPrice = "10.00";
            }
            orderSingleParam.QuotesTime = "10:00:00";
            orderSingleParam.IpRemote = ConfigurationManager.AppSettings["IpRemote"];
            orderSingleParam.HostName = ConfigurationManager.AppSettings["HostName"];
            orderSingleParam.Signature = ConfigurationManager.AppSettings["Signature"];
            orderSingleParam.TradeChannel = txtOrderNewTradeChannel.Text;
            orderSingleParam.EnableTrace = chkEnableTrace.Checked;
            orderSingleParam.Referer = DateTime.Now;
            // Enviar ordem para inclusão
            cmaStreamerFeed.Order(orderSingleParam, 10000).Subscribe(
            obs =>
            {
                try
                {
                    string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Result<OrderSingleResult> orderSingleResult = obs.Result;
                    stopWatch.Stop();
                    if (boolCalcularTempo)
                    {
                        strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                    }
                    if (chkJson.Checked)
                    {
                        strTexto += orderSingleResult.ToJSON();
                    }
                    else
                    {
                        if (orderSingleResult.Status.Success)
                        {
                            strTexto += "Order ID=" + orderSingleResult.Data.OrderId
                                       + (String.IsNullOrEmpty(orderSingleResult.Data.FractionaryOrderId) ? "" : (" - Order Fractionary ID = " + orderSingleResult.Data.FractionaryOrderId))
                                       + ": inclusão realizada com sucesso!";
                        }
                        else
                        {
                            strTexto += "Erro " + orderSingleResult.Status.Code + " - " + orderSingleResult.Status.Message;
                        }
                    }

                    if (chkEnableTrace.Checked)
                    {
                        strTexto += "\n\nTrace:" + orderSingleResult.Trace?.ToJSON();
                    }

                    strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                    lstOrderNew.Text = strTexto;
                }
                catch (Exception ex)
                {
                    lstOrderNew.Text = ex.Message;
                }
            },
            ex => lstOrderNew.Text = ex.Message
            ).Dispose();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            orderListCommands.btnOrderList_Click(sender, e);
        }

        private void btnPortfolio_Click(object sender, EventArgs e)
        {
            lstPortfolio.Clear();
            if (Uteis.GetHealthCheckStatus(this) == false)
            {
                return;
            }
            // Parametriza portfólio
            PortfolioParam portfolioParam = new PortfolioParam();
            portfolioParam.UserId.User = int.Parse(txtPortfolioUser.Text);
            portfolioParam.UserId.UserMne = txtPortfolioUserMne.Text;
            portfolioParam.PortfolioType = int.Parse(cboPortfolioPortfolioType.Text);
            if (cboPortfolioPortfolioMarketId.SelectedIndex > 0)
            {
                portfolioParam.MarketId = int.Parse(cboPortfolioPortfolioMarketId.Text);
            }
            portfolioParam.EnableTrace = chkEnableTrace.Checked;
            portfolioParam.Referer = DateTime.Now;
            // Solicitar portfólio
            cmaStreamerFeed.Portfolio(portfolioParam, 10000).Subscribe(
            obs =>
            {
                try
                {
                    string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Result<List<PortfolioResult>> portfolioResult = obs.Result;
                    stopWatch.Stop();
                    if (boolCalcularTempo)
                    {
                        strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                    }
                    if (chkJson.Checked)
                    {
                        strTexto += portfolioResult.ToJSON();
                    }
                    else
                    {
                        if (portfolioResult.Data.Count > 0)
                        {
                            foreach (PortfolioResult item in portfolioResult.Data)
                            {
                                strTexto += "SymbolID=" + item.Symbol.SymbolID
                                    + "  TotalQtty=" + item.TotalQtty
                                    + "  QttyBidC=" + item.QttyBidC
                                    + "  QttyAskC=" + item.QttyAskC
                                    + "  AvailableQtty=" + item.AvailableQtty
                                    + "\n";
                            }
                        }
                        else
                        {
                            if (portfolioResult.Status.Success)
                            {
                                strTexto += "Nenhum registro retornado!";
                            }
                            else
                            {
                                strTexto += "Erro - Success=False Code=" + portfolioResult.Status.Code + " Message=" + portfolioResult.Status.Message;
                            }
                        }
                    }

                    if (chkEnableTrace.Checked)
                    {
                        strTexto += "\n\nTrace:" + portfolioResult.Trace?.ToJSON();
                    }

                    strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                    lstPortfolio.Text = strTexto;
                }
                catch (Exception ex)
                {
                    lstPortfolio.Text = ex.Message;
                }
            },
            ex => lstPortfolio.Text = ex.Message
            ).Dispose();
        }

        private void btnOrderCancel_Click(object sender, EventArgs e)
        {
            lstOrderCancel.Clear();
            if (Uteis.GetHealthCheckStatus(this) == false)
            {
                return;
            }
            // Parametriza cancelamento
            OrderCancelParam orderCancelParam = new OrderCancelParam();
            orderCancelParam.UserId.User = long.Parse(txtlOrderCancelUser.Text);
            orderCancelParam.UserId.UserMne = txtOrderListClientMneFilter.Text;
            orderCancelParam.OfferId = txtOrderCancelOfferId.Text;
            orderCancelParam.IpRemote = ConfigurationManager.AppSettings["IpRemote"];
            orderCancelParam.HostName = ConfigurationManager.AppSettings["HostName"];
            orderCancelParam.Signature = ConfigurationManager.AppSettings["Signature"];
            orderCancelParam.EnableTrace = chkEnableTrace.Checked;
            orderCancelParam.Referer = DateTime.Now;
            // Solicita cancelamento
            cmaStreamerFeed.Order(orderCancelParam, 10000).Subscribe(
            obs =>
            {
                try
                {
                    string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Result<OrderCancelResult> orderCancelResult = obs.Result;
                    stopWatch.Stop();
                    if (boolCalcularTempo)
                    {
                        strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                    }
                    if (chkJson.Checked)
                    {
                        strTexto += orderCancelResult.ToJSON();
                    }
                    else
                    {
                        if (orderCancelResult.Status.Success)
                        {
                            strTexto += "Order ID=" + txtOrderCancelOfferId.Text + ": solicitação de cancelamento enviada com sucesso!";
                        }
                        else
                        {
                            strTexto += "Erro " + orderCancelResult.Status.Code + " - " + orderCancelResult.Status.Message;
                        }
                    }

                    if (chkEnableTrace.Checked)
                    {
                        strTexto += "\n\nTrace:" + orderCancelResult.Trace?.ToJSON();
                    }

                    strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                    lstOrderCancel.Text = strTexto;
                }
                catch (Exception ex)
                {
                    lstOrderCancel.Text = ex.Message;
                }
            },
            ex => lstOrderCancel.Text = ex.Message
            ).Dispose();
        }

        private void btnOrderRelace_Click(object sender, EventArgs e)
        {
            lstOrderReplace.Clear();
            if (Uteis.GetHealthCheckStatus(this) == false)
            {
                return;
            }
            // Parametriza alteração
            OrderReplaceParam orderReplaceParam = new OrderReplaceParam();
            orderReplaceParam.UserId.User = long.Parse(txtOrderReplaceUser.Text);
            orderReplaceParam.UserId.UserMne = txtOrderReplaceUserMne.Text;
            orderReplaceParam.OfferId = txtOrderReplaceOfferId.Text;
            orderReplaceParam.OriginalQtty = txtOrderReplaceOriginalQtty.Text;
            orderReplaceParam.Qtty = txtOrderReplaceQtty.Text;
            orderReplaceParam.Price = txtOrderReplacePrice.Text;
            orderReplaceParam.TypeOffer = cboOrderReplaceTypeOffer.Text;
            orderReplaceParam.TypeValidity = "Today";
            orderReplaceParam.Validity = DateTime.Now.ToString("yyyy-mm-dd");
            orderReplaceParam.Confirmation = false;
            orderReplaceParam.QuotesLastPrice = txtOrderReplaceQuotes.Text;
            orderReplaceParam.QuotesTime = "10:00:00";
            orderReplaceParam.IpRemote = ConfigurationManager.AppSettings["IpRemote"];
            orderReplaceParam.HostName = ConfigurationManager.AppSettings["HostName"];
            orderReplaceParam.Signature = ConfigurationManager.AppSettings["Signature"];
            orderReplaceParam.TradeChannel = txtOrderReplaceTradeChannel.Text;
            orderReplaceParam.EnableTrace = chkEnableTrace.Checked;
            orderReplaceParam.Referer = DateTime.Now;
            // Solicitação alteração
            cmaStreamerFeed.Order(orderReplaceParam, 10000).Subscribe(
            obs =>
            {
                try
                {
                    string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Result<OrderReplaceResult> orderReplaceResult = obs.Result;
                    stopWatch.Stop();
                    if (boolCalcularTempo)
                    {
                        strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                    }
                    if (chkJson.Checked)
                    {
                        strTexto += orderReplaceResult.ToJSON();
                    }
                    else
                    {
                        if (orderReplaceResult.Status.Success)
                        {
                            strTexto += "Order ID=" + txtOrderReplaceOfferId.Text + ": solicitação de alteração enviada com sucesso!";
                        }
                        else
                        {
                            strTexto += "Erro " + orderReplaceResult.Status.Code + " - " + orderReplaceResult.Status.Message;
                        }
                    }

                    if (chkEnableTrace.Checked)
                    {
                        strTexto += "\n\nTrace:" + orderReplaceResult.Trace?.ToJSON();
                    }

                    strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                    lstOrderReplace.Text = strTexto;
                }
                catch (Exception ex)
                {
                    lstOrderReplace.Text = ex.Message;
                }
            },
            ex => lstOrderReplace.Text = ex.Message
            ).Dispose();
        }

        private void cboOrderNewTypeOffer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOrderNewTypeOffer.SelectedIndex == 1)
                txtOrderNewPrice.Text = "0.00";
        }

        private void btnRuleVerifyQuotes_Click(object sender, EventArgs e)
        {
            lstRuleVerifyQuotes.Clear();
            if (Uteis.GetHealthCheckStatus(this) == false)
            {
                return;
            }
            // Parametriza regra
            RuleVerifyQuotesParam ruleVerifyQuotesParam = new RuleVerifyQuotesParam();
            ruleVerifyQuotesParam.UserId.User = int.Parse(txtRuleVerifyQuotesUser.Text);
            ruleVerifyQuotesParam.UserId.UserMne = txtRuleVerifyQuotesUserMne.Text;
            ruleVerifyQuotesParam.SourceID = txtRuleVerifyQuotesSourceID.Text;
            ruleVerifyQuotesParam.SymbolID = txtRuleVerifyQuotesSymbolID.Text;
            ruleVerifyQuotesParam.Side = cboRuleVerifyQuotesSide.Text;
            ruleVerifyQuotesParam.AfterMarket = chkRuleVerifyQuotesAfterMarket.Checked;
            ruleVerifyQuotesParam.EnableTrace = chkEnableTrace.Checked;
            ruleVerifyQuotesParam.Referer = DateTime.Now;
            // Solicitar regra
            cmaStreamerFeed.RuleVerifyQuotes(ruleVerifyQuotesParam, 10000).Subscribe(
            obs =>
            {
                try
                {
                    string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Result<RuleVerifyQuotesResult> ruleVerifyQuotesResult = obs.Result;
                    stopWatch.Stop();
                    if (boolCalcularTempo)
                    {
                        strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                    }
                    if (chkJson.Checked)
                    {
                        strTexto += ruleVerifyQuotesResult.ToJSON();
                    }
                    else
                    {
                        if (ruleVerifyQuotesResult.Status.Success)
                        {
                            strTexto += "LastTradePrice=" + ruleVerifyQuotesResult.Data.LastTradePrice
                                + "  LastTradeTime=" + ruleVerifyQuotesResult.Data.LastTradeTime
                                + "  PrevClosePrice=" + ruleVerifyQuotesResult.Data.PrevClosePrice
                                + "  PriceMinimum=" + ruleVerifyQuotesResult.Data.PriceMinimum
                                + "  PriceMaximum=" + ruleVerifyQuotesResult.Data.PriceMaximum
                                + "\n";
                        }
                        else
                        {
                            strTexto += "Erro - Success=False Code=" + ruleVerifyQuotesResult.Status.Code + " Message=" + ruleVerifyQuotesResult.Status.Message;
                        }
                    }

                    if (chkEnableTrace.Checked)
                    {
                        strTexto += "\n\nTrace:" + ruleVerifyQuotesResult.Trace?.ToJSON();
                    }

                    strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                    lstRuleVerifyQuotes.Text = strTexto;
                }
                catch (Exception ex)
                {
                    lstRuleVerifyQuotes.Text = ex.Message;
                }
            },
            ex => lstRuleVerifyQuotes.Text = ex.Message
            ).Dispose();
        }

        private void btnHealthCheck_Click(object sender, EventArgs e)
        {
            monitoringCommands.btnHealthCheck_Click(sender, e);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            monitoringCommands.btnCheck_Click(sender, e);
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            monitoringCommands.btnPing_Click(sender, e);
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            monitoringCommands.btnAudit_Click(sender, e);
        }

        private void btnInstrumentation_Click(object sender, EventArgs e)
        {
            monitoringCommands.btnInstrumentation_Click(sender, e);
        }

        private void cboInstrumentation_SelectedIndexChanged(object sender, EventArgs e)
        {
            monitoringCommands.cboInstrumentation_SelectedIndexChanged(sender, e);
        }

        private void btnFinancialStatements_Click(object sender, EventArgs e)
        {
            lstFinancialStatements.Clear();
            if (Uteis.GetHealthCheckStatus(this) == false)
            {
                return;
            }
            // Parametriza regra
            FinancialStatementsParam financialStatementsParam = new FinancialStatementsParam();
            financialStatementsParam.UserId.User = int.Parse(txtFinancialStatementsUser.Text);
            financialStatementsParam.UserId.UserMne = txtFinancialStatementsUserMne.Text;
            financialStatementsParam.EnableTrace = chkEnableTrace.Checked;
            financialStatementsParam.Referer = DateTime.Now;
            // Solicitar regra
            cmaStreamerFeed.FinancialStatements(financialStatementsParam, 10000).Subscribe(
            obs =>
            {
                try
                {
                    string strTexto = "==> INICIO " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==\n\n";
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Result<FinancialStatementsResult> financialStatementsResult = obs.Result;
                    stopWatch.Stop();
                    if (boolCalcularTempo)
                    {
                        strTexto += "Tempo (ms)=" + stopWatch.ElapsedMilliseconds + "\n\n";
                    }
                    if (chkJson.Checked)
                    {
                        strTexto += financialStatementsResult.ToJSON();
                    }
                    else
                    {
                        if (financialStatementsResult.Status.Success)
                        {
                            strTexto += "Data Atual=" + financialStatementsResult.Data.DtD0 + "\n"
                                + "Data Atual+1=" + financialStatementsResult.Data.DtD1 + "\n"
                                + "Data Atual+2=" + financialStatementsResult.Data.DtD2 + "\n"
                                + "Valor Disponível (Sinacor)=" + financialStatementsResult.Data.VlDisponivel + "\n"
                                + "Valor Total (Sinacor)=" + financialStatementsResult.Data.VlTotal + "\n"
                                + "Valor Projetado (Sinacor)=" + financialStatementsResult.Data.VlProjetado + "\n"
                                + "Valor Cpa BVSP-Vis Conf (OMS)=" + financialStatementsResult.Data.VisValueBidC + "\n"
                                + "Valor Vda BVSP-Vis Conf (OMS)=" + financialStatementsResult.Data.VisValueAskC + "\n"
                                + "Valor Cpa BVSP-Opc Conf (OMS)=" + financialStatementsResult.Data.OpcValueBidC + "\n"
                                + "Valor Vda BVSP-Opc Conf (OMS)=" + financialStatementsResult.Data.OpcValueAskC + "\n"
                                + "Valor Disponível BVSP-Vis (OMS)=" + financialStatementsResult.Data.VlDisponivelVis + "\n"
                                + "Valor Disponível BVSP-Opc (OMS)=" + financialStatementsResult.Data.VlDisponivelOpc + "\n"
                                + "Valor Disponível Resgate (OMS)=" + financialStatementsResult.Data.VlDisponivelRes + "\n"
                                + "Valor Limite Financeiro Inicial=" + financialStatementsResult.Data.LimitInitial + "\n"
                                + "Valor Limite Financeiro Atual=" + financialStatementsResult.Data.LimitCurrent + "\n"
                                + "Valor Limite Financeiro Final=" + financialStatementsResult.Data.LimitFinal + "\n"
                                + "Valor Limite de Crédito=" + financialStatementsResult.Data.LimitCredit + "\n";
                        }
                        else
                        {
                            strTexto += "Erro - Success=False Code=" + financialStatementsResult.Status.Code + " Message=" + financialStatementsResult.Status.Message;
                        }
                    }

                    if (chkEnableTrace.Checked)
                    {
                        strTexto += "\n\nTrace:" + financialStatementsResult.Trace?.ToJSON();
                    }

                    strTexto += "\n\n==> FIM " + DateTime.Now.ToString("HH:mm:ss.ffff") + " <==";
                    lstFinancialStatements.Text = strTexto;
                }
                catch (Exception ex)
                {
                    lstFinancialStatements.Text = ex.Message;
                }
            },
            ex => lstFinancialStatements.Text = ex.Message
            ).Dispose();
        }

        private void btnBuscarLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";

            string path = cboLogs.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(path))
            {
                txtLog.Text = "Não foi selecionado nenhum Log na combo!";

                return;
            }

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.UTF8))
            {
                List<string> logs = new List<string>();

                while (!sr.EndOfStream)
                {
                    logs.Add(sr.ReadLine());
                }

                logs.Reverse();

                if (cboQttLogs.SelectedItem == null || cboQttLogs.SelectedItem.ToString() == "Todos")
                {
                    foreach (string l in logs)
                    {
                        txtLog.Text += l + "\n";
                    }
                }
                else
                {
                    foreach (string l in logs.Take(Convert.ToInt32(cboQttLogs.SelectedItem)))
                    {
                        txtLog.Text += l + "\n";
                    }
                }
            }

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Text == "Log")//your specific tabname
            {
                if (cboQttLogs.SelectedValue == null)
                {
                    cboQttLogs.SelectedItem = "100";
                }

                string path = ConfigurationManager.AppSettings.Get("CMA.StreamerFeed.Api:serilog:write-to:File.path");

                if (string.IsNullOrEmpty(path))
                {
                    txtLog.Text = "Não foi encontrado valor para a chave CMA.StreamerFeed.Api:serilog:write-to:File.path!";

                    return;
                }

                string fileName = path.Split(new string[] { "\\" }, StringSplitOptions.None).Last();
                List<string> allfiles = Directory.GetFiles(path.Replace(fileName, ""), "*", SearchOption.AllDirectories).ToList();

                allfiles.Reverse();

                BindingSource bs = new BindingSource();
                bs.DataSource = allfiles;
                cboLogs.DataSource = bs;
            }
            else if (tabControl.SelectedTab.Text == "Postman")
            {
                string path = ConfigurationManager.AppSettings.Get("CMA.StreamerFeed.Api:Postman:File.path");

                if (string.IsNullOrEmpty(path))
                {
                    txtDownloadPostman.Text = "Não foi encontrado valor para a chave CMA.StreamerFeed.Api:Postman:File.path!";

                    return;
                }

                List<string> allfiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories).ToList();

                allfiles.Reverse();

                BindingSource bs = new BindingSource();
                bs.DataSource = allfiles;
                cboDownloadPostman.DataSource = bs;
            }
        }

        private void btnInstantiate_Click(object sender, EventArgs e)
        {
            apiCommands.btnInstantiate_Click(sender, e);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            apiCommands.btnDisconnect_Click(sender, e);
        }

        private void txtMaxResultHighlight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar));
        }

        private void btnBuscarHighlights_Click(object sender, EventArgs e)
        {
            highlightsCommands.btnBuscarHighlights_Click(sender, e);
        }

        private void btnDownloadPostman_Click(object sender, EventArgs e)
        {
            txtDownloadPostman.Text = "";

            string path = cboDownloadPostman.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(path))
            {
                txtDownloadPostman.Text = "Não foi selecionado nenhum arquivo para download!";

                return;
            }

            SavePostmanFileAs(path);

        }

        private void SavePostmanFileAs(string pathServerFile)
        {
            //verifica se existe algo digitado na caixa de texto
            if (string.IsNullOrEmpty(pathServerFile))
            {
                MessageBox.Show("Informe o caminho do arquivo no servidor");
                return;
            }

            var saveFileDialog1 = new SaveFileDialog();

            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo Postman";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = pathServerFile.Split('\\').Last() + DateTime.Now.ToString("_ddMMyyyy_HHmmss");
            //Define a extensão padrão como .json
            saveFileDialog1.DefaultExt = ".json";
            //define o diretório padrão
            //saveFileDialog1.InitialDirectory = @"c:\dados";
            //restaura o diretorio atual antes de fechar a janela
            //saveFileDialog1.RestoreDirectory = true;

            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult resultado = saveFileDialog1.ShowDialog();

            //Se o ousuário pressionar o botão Salvar
            if (resultado == DialogResult.OK)
            {
                try
                {
                    using (var src = File.OpenRead(pathServerFile))
                    using (var dest = File.OpenWrite(saveFileDialog1.FileName))
                    {
                        src.CopyTo(dest); //blocks until finished
                    }

                    txtDownloadPostman.Text = $"Arquivo salvo em \"{saveFileDialog1.FileName}\"";
                }
                catch (Exception ex) {
                    txtDownloadPostman.Text = $"Problema ao tentar salvar o arquivo no destino \"{saveFileDialog1.FileName}\" \n Exception: " + ex.Message;
                }
            }
            else
            {
                //exibe mensagem informando que a operação foi cancelada
                MessageBox.Show("Operação cancelada");
            }
        }

        private void tabMonitoring_Click(object sender, EventArgs e)
        {

        }

        private void btnMarketSymbolInfo_Click(object sender, EventArgs e)
        {
            marketSymbolInfoCommands.btnMarketSymbolInfo_Click(sender, e);
        }

        private void chkBookSign_CheckedChanged(object sender, EventArgs e)
        {
            bookCommands.chkBookSign_CheckedChanged(sender, e);
        }

        private void chkQuotesHistorySign_CheckedChanged(object sender, EventArgs e)
        {
            quotesHistoryCommands.chkQuotesHistorySign_CheckedChanged(sender, e);
        }

        private void btnSendOption_Click(object sender, EventArgs e)
        {
            sendOptionExerciseCommands.btnSendOption_Click(sender, e);

        }

        private void btnStartProvider_Click(object sender, EventArgs e)
        {
            providerCommands.btnStartProvider_Click(sender, e);
        }

        private void btnStopProvider_Click(object sender, EventArgs e)
        {
            providerCommands.btnStopProvider_Click(sender, e);
        }

        private void rbQuotesTemplate_CheckedChanged(object sender, EventArgs e)
        {
            providerCommands.rbQuotesTemplate_CheckedChanged(sender, e);
        }

        private void rbSpaceDelimitedFile_CheckedChanged(object sender, EventArgs e)
        {
            providerCommands.rbSpaceDelimitedFile_CheckedChanged(sender, e);
        }

        private void rbDatabase_CheckedChanged(object sender, EventArgs e)
        {
            providerCommands.rbDatabase_CheckedChanged(sender, e);
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            providerCommands.btnSelectFile_Click(sender, e);
        }

        private void btnSelectFileColumns_Click(object sender, EventArgs e)
        {
            providerCommands.btnSelectFileColumns_Click(sender, e);
        }

        private void chkSQLCustomFilter_CheckedChanged(object sender, EventArgs e)
        {
            providerCommands.chkSQLCustomFilter_CheckedChanged(sender, e);

        }

        private void btnAddLoadTest_Click(object sender, EventArgs e)
        {
            loadTestCommands.btnAddLoadTest_Click(sender, e);
        }

        private void gridSubscriptionsLoadTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadTestCommands.gridSubscriptions_CellContentClick(sender, e);
        }

        private void chkSignLoadTest_CheckedChanged(object sender, EventArgs e)
        {
            loadTestCommands.chkSignLoadTest_CheckedChanged(sender, e);
        }
    }
}
