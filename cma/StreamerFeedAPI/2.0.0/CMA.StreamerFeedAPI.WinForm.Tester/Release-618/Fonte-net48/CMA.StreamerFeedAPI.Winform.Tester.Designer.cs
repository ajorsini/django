namespace WinFormAPITester
{
    partial class frmWinFormAPITester
    {

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWinFormAPITester));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInstantiate = new System.Windows.Forms.TabPage();
            this.richTextInstantiate = new System.Windows.Forms.RichTextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnInstantiate = new System.Windows.Forms.Button();
            this.lblLoginTokenKeyLength = new System.Windows.Forms.Label();
            this.txtLoginTokenKeyLength = new System.Windows.Forms.TextBox();
            this.lblLoginTokenSaltIterations = new System.Windows.Forms.Label();
            this.txtLoginTokenSaltIterations = new System.Windows.Forms.TextBox();
            this.lblLoginTokenSaltKey = new System.Windows.Forms.Label();
            this.txtLoginTokenSaltKey = new System.Windows.Forms.TextBox();
            this.lblLoginTokenIvKey = new System.Windows.Forms.Label();
            this.txtLoginTokenIvKey = new System.Windows.Forms.TextBox();
            this.lblLoginTokenSecretKey = new System.Windows.Forms.Label();
            this.txtLoginTokenSecretKey = new System.Windows.Forms.TextBox();
            this.lblChannel = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblDomainId = new System.Windows.Forms.Label();
            this.txtDomainId = new System.Windows.Forms.TextBox();
            this.lblAcceptorUrl = new System.Windows.Forms.Label();
            this.txtAcceptorUrl = new System.Windows.Forms.TextBox();
            this.lblInstanceName = new System.Windows.Forms.Label();
            this.txtInstanceName = new System.Windows.Forms.TextBox();
            this.tabQuotes = new System.Windows.Forms.TabPage();
            this.gridSubscriptions = new System.Windows.Forms.DataGridView();
            this.HiddenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desassinar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkOnlyDiffQuotes = new System.Windows.Forms.CheckBox();
            this.chkSign = new System.Windows.Forms.CheckBox();
            this.lblQuotesClientMneMD = new System.Windows.Forms.Label();
            this.txtQuotesClientMneMD = new System.Windows.Forms.TextBox();
            this.lblQuotesSourceID = new System.Windows.Forms.Label();
            this.txtQuotesSourceID = new System.Windows.Forms.TextBox();
            this.lblQuotesSymbolID = new System.Windows.Forms.Label();
            this.lstQuotes = new System.Windows.Forms.RichTextBox();
            this.txtQuotesSymbolID = new System.Windows.Forms.TextBox();
            this.btnQuotes = new System.Windows.Forms.Button();
            this.tabSymbolSearch = new System.Windows.Forms.TabPage();
            this.cboSymbolMarket = new System.Windows.Forms.ComboBox();
            this.lblSymbolSourceID = new System.Windows.Forms.Label();
            this.txtSymbolSourceID = new System.Windows.Forms.TextBox();
            this.lblSymbolMarket = new System.Windows.Forms.Label();
            this.lblSymbolDescricao = new System.Windows.Forms.Label();
            this.txtSymbolDescription = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lstSymbol = new System.Windows.Forms.RichTextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btnSymbol = new System.Windows.Forms.Button();
            this.tabQuotesHistory = new System.Windows.Forms.TabPage();
            this.chkQuotesHistorySign = new System.Windows.Forms.CheckBox();
            this.formsPlotQuotesHistory = new ScottPlot.FormsPlot();
            this.lblQuotesHistoryDateTo = new System.Windows.Forms.Label();
            this.txtQuotesHistoryDateTo = new System.Windows.Forms.TextBox();
            this.lblQuotesHistoryDateFrom = new System.Windows.Forms.Label();
            this.txtQuotesHistoryDateFrom = new System.Windows.Forms.TextBox();
            this.lblQuotesHistoryCLientMneMD = new System.Windows.Forms.Label();
            this.txtQuotesHistoryCLientMneMD = new System.Windows.Forms.TextBox();
            this.cboQuotesHistoryPeriod = new System.Windows.Forms.ComboBox();
            this.lblQuotesHistoryPeriod = new System.Windows.Forms.Label();
            this.lblQuotesHistorySourceID = new System.Windows.Forms.Label();
            this.txtQuotesHistorySourceID = new System.Windows.Forms.TextBox();
            this.lblQuotesHistorySymbolID = new System.Windows.Forms.Label();
            this.lstQuotesHistory = new System.Windows.Forms.RichTextBox();
            this.txtQuotesHistorySymbolID = new System.Windows.Forms.TextBox();
            this.btnQuotesHistory = new System.Windows.Forms.Button();
            this.tabBook = new System.Windows.Forms.TabPage();
            this.gridSubscriptionsBook = new System.Windows.Forms.DataGridView();
            this.chkBookSign = new System.Windows.Forms.CheckBox();
            this.lblBookClientMneMD = new System.Windows.Forms.Label();
            this.txtBookClientMneMD = new System.Windows.Forms.TextBox();
            this.cboBookConsolidate = new System.Windows.Forms.ComboBox();
            this.lblBookConsolidate = new System.Windows.Forms.Label();
            this.lblBookDeep = new System.Windows.Forms.Label();
            this.txtBookDeep = new System.Windows.Forms.TextBox();
            this.lblBookSourceID = new System.Windows.Forms.Label();
            this.txtBookSourceID = new System.Windows.Forms.TextBox();
            this.lblBookSymbolID = new System.Windows.Forms.Label();
            this.lstBook = new System.Windows.Forms.RichTextBox();
            this.txtBookSymbolID = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.tabNews = new System.Windows.Forms.TabPage();
            this.gridNews = new System.Windows.Forms.DataGridView();
            this.HiddenIdNews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integra = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chkNewsSign = new System.Windows.Forms.CheckBox();
            this.lblNewsDateFilter = new System.Windows.Forms.Label();
            this.txtNewsDateFilter = new System.Windows.Forms.TextBox();
            this.lblNewsClientMneMD = new System.Windows.Forms.Label();
            this.txtNewsClientMneMD = new System.Windows.Forms.TextBox();
            this.lblNewsQuantity = new System.Windows.Forms.Label();
            this.txtNewsQuantity = new System.Windows.Forms.TextBox();
            this.lblNewsTextFilter = new System.Windows.Forms.Label();
            this.txtNewsTextFilter = new System.Windows.Forms.TextBox();
            this.lblNewsSubjectFilter = new System.Windows.Forms.Label();
            this.txtNewsSubjectFilter = new System.Windows.Forms.TextBox();
            this.lblNewsSourceID = new System.Windows.Forms.Label();
            this.txtNewsSourceID = new System.Windows.Forms.TextBox();
            this.lstNews = new System.Windows.Forms.RichTextBox();
            this.btnNews = new System.Windows.Forms.Button();
            this.tabHighlights = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHighLightsDateTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHighLightsDateFrom = new System.Windows.Forms.TextBox();
            this.chkHighlightsSign = new System.Windows.Forms.CheckBox();
            this.btnBuscarHighlights = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrokerHighlight = new System.Windows.Forms.TextBox();
            this.lblMaxResult = new System.Windows.Forms.Label();
            this.txtMaxResultHighlight = new System.Windows.Forms.TextBox();
            this.cboMarketHighlight = new System.Windows.Forms.ComboBox();
            this.lblMarketHighlight = new System.Windows.Forms.Label();
            this.cboTipoRelatorioHighlight = new System.Windows.Forms.ComboBox();
            this.lblTipoRelatorio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSourceHighlight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSymbolHighlight = new System.Windows.Forms.TextBox();
            this.gridHighlights = new System.Windows.Forms.DataGridView();
            this.lstHighlight = new System.Windows.Forms.RichTextBox();
            this.tabProvider = new System.Windows.Forms.TabPage();
            this.lblUsedTemplate = new System.Windows.Forms.Label();
            this.gbProviderConfigurations = new System.Windows.Forms.GroupBox();
            this.lblProviderSymbolsDB = new System.Windows.Forms.Label();
            this.lblLabelProviderSymbolsDB = new System.Windows.Forms.Label();
            this.txtProviderConfigurationSourceId = new System.Windows.Forms.TextBox();
            this.lblProviderConfigurationSourceId = new System.Windows.Forms.Label();
            this.txtProviderConfigurationColumns = new System.Windows.Forms.TextBox();
            this.lblProviderConfigurationColumns = new System.Windows.Forms.Label();
            this.txtUsedTemplate = new System.Windows.Forms.TextBox();
            this.txtSQLCustomFilter = new System.Windows.Forms.TextBox();
            this.chkSQLCustomFilter = new System.Windows.Forms.CheckBox();
            this.lblProviderTemplateColumnFilterValue = new System.Windows.Forms.Label();
            this.txtProviderTemplateColumnFilter = new System.Windows.Forms.TextBox();
            this.lblProviderTemplateColumnFilter = new System.Windows.Forms.Label();
            this.txtProviderTemplateTable = new System.Windows.Forms.TextBox();
            this.lblProviderTemplateTable = new System.Windows.Forms.Label();
            this.txtProviderQuotesTable = new System.Windows.Forms.TextBox();
            this.lblProviderQuotesTable = new System.Windows.Forms.Label();
            this.txtProviderQuotesColumns = new System.Windows.Forms.TextBox();
            this.lblProviderColumnsFile = new System.Windows.Forms.Label();
            this.lblProviderColumnsFileLabel = new System.Windows.Forms.Label();
            this.btnSelectFileColumns = new System.Windows.Forms.Button();
            this.lblProviderTableFilePathLabel = new System.Windows.Forms.Label();
            this.lblProviderTableFilePath = new System.Windows.Forms.Label();
            this.btnSelectFileTable = new System.Windows.Forms.Button();
            this.rbSpaceDelimitedFile = new System.Windows.Forms.RadioButton();
            this.rbDatabase = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.rbQuotesTemplate = new System.Windows.Forms.RadioButton();
            this.lblProvider = new System.Windows.Forms.Label();
            this.cboProvider = new System.Windows.Forms.ComboBox();
            this.txtProviderStatus = new System.Windows.Forms.RichTextBox();
            this.btnStopProvider = new System.Windows.Forms.Button();
            this.btnStartProvider = new System.Windows.Forms.Button();
            this.lblQuotesTemplate = new System.Windows.Forms.Label();
            this.lblSymbolProvider = new System.Windows.Forms.Label();
            this.txtSourceSymbolProvider = new System.Windows.Forms.TextBox();
            this.lblConnectionStringProvider = new System.Windows.Forms.Label();
            this.txtConnectionStringProvider = new System.Windows.Forms.TextBox();
            this.txtProviderTemplateColumn = new System.Windows.Forms.TextBox();
            this.lblProviderTemplateColumn = new System.Windows.Forms.Label();
            this.txtQuotesTemplate = new System.Windows.Forms.TextBox();
            this.txtProviderTemplateColumnFilterValue = new System.Windows.Forms.TextBox();
            this.tabClientList = new System.Windows.Forms.TabPage();
            this.cboClientFilterType = new System.Windows.Forms.ComboBox();
            this.lblClientAssessorId = new System.Windows.Forms.Label();
            this.txtClientAssessorId = new System.Windows.Forms.TextBox();
            this.txtClientFilterData = new System.Windows.Forms.TextBox();
            this.lblClientFilterData = new System.Windows.Forms.Label();
            this.lblClientFilterType = new System.Windows.Forms.Label();
            this.lblClientBranchId = new System.Windows.Forms.Label();
            this.lstClient = new System.Windows.Forms.RichTextBox();
            this.txtClientBranchId = new System.Windows.Forms.TextBox();
            this.btnClientList = new System.Windows.Forms.Button();
            this.tabOrderNew = new System.Windows.Forms.TabPage();
            this.lblOrderNewTradeChannel = new System.Windows.Forms.Label();
            this.txtOrderNewTradeChannel = new System.Windows.Forms.TextBox();
            this.cboOrderNewMarketId = new System.Windows.Forms.ComboBox();
            this.lblOrderNewMarketId = new System.Windows.Forms.Label();
            this.lblOrderNewQuotes = new System.Windows.Forms.Label();
            this.txtOrderNewQuotes = new System.Windows.Forms.TextBox();
            this.lblOrderNewUserMne = new System.Windows.Forms.Label();
            this.txtOrderNewUserMne = new System.Windows.Forms.TextBox();
            this.cboOrderNewSide = new System.Windows.Forms.ComboBox();
            this.cboOrderNewTypeOffer = new System.Windows.Forms.ComboBox();
            this.lblOrderNewTypeOffer = new System.Windows.Forms.Label();
            this.lblOrderNewPrice = new System.Windows.Forms.Label();
            this.txtOrderNewPrice = new System.Windows.Forms.TextBox();
            this.lblOrderNewQtty = new System.Windows.Forms.Label();
            this.txtOrderNewQtty = new System.Windows.Forms.TextBox();
            this.lblOrderNewSide = new System.Windows.Forms.Label();
            this.lblOrderNewUser = new System.Windows.Forms.Label();
            this.txtOrderNewUserId = new System.Windows.Forms.TextBox();
            this.lblOrderNewSymbol = new System.Windows.Forms.Label();
            this.lstOrderNew = new System.Windows.Forms.RichTextBox();
            this.txtOrderNewSymbol = new System.Windows.Forms.TextBox();
            this.btnOrderNew = new System.Windows.Forms.Button();
            this.tabOrderReplace = new System.Windows.Forms.TabPage();
            this.lblOrderReplaceTradeChannel = new System.Windows.Forms.Label();
            this.txtOrderReplaceTradeChannel = new System.Windows.Forms.TextBox();
            this.lblOrderReplaceQuotes = new System.Windows.Forms.Label();
            this.txtOrderReplaceQuotes = new System.Windows.Forms.TextBox();
            this.lblOrderReplaceUserMne = new System.Windows.Forms.Label();
            this.txtOrderReplaceUserMne = new System.Windows.Forms.TextBox();
            this.cboOrderReplaceTypeOffer = new System.Windows.Forms.ComboBox();
            this.lblOrderReplacePrice = new System.Windows.Forms.Label();
            this.txtOrderReplacePrice = new System.Windows.Forms.TextBox();
            this.lblOrderReplaceQtty = new System.Windows.Forms.Label();
            this.txtOrderReplaceQtty = new System.Windows.Forms.TextBox();
            this.lblOrderReplaceOriginalQtty = new System.Windows.Forms.Label();
            this.txtOrderReplaceOriginalQtty = new System.Windows.Forms.TextBox();
            this.lblOrderReplaceTypeOffer = new System.Windows.Forms.Label();
            this.lblOrderReplaceOfferId = new System.Windows.Forms.Label();
            this.txtOrderReplaceOfferId = new System.Windows.Forms.TextBox();
            this.lblOrderReplaceUser = new System.Windows.Forms.Label();
            this.txtOrderReplaceUser = new System.Windows.Forms.TextBox();
            this.lstOrderReplace = new System.Windows.Forms.RichTextBox();
            this.btnOrderReplace = new System.Windows.Forms.Button();
            this.tabOrderCancel = new System.Windows.Forms.TabPage();
            this.lblOrderCancelUserMne = new System.Windows.Forms.Label();
            this.txtOrderCancelUserMne = new System.Windows.Forms.TextBox();
            this.lblOrderCancelOferId = new System.Windows.Forms.Label();
            this.txtOrderCancelOfferId = new System.Windows.Forms.TextBox();
            this.lblOrderCancelUser = new System.Windows.Forms.Label();
            this.txtlOrderCancelUser = new System.Windows.Forms.TextBox();
            this.lstOrderCancel = new System.Windows.Forms.RichTextBox();
            this.btnOrderCancel = new System.Windows.Forms.Button();
            this.tabOrderList = new System.Windows.Forms.TabPage();
            this.gridOrderList = new System.Windows.Forms.DataGridView();
            this.cboOrderListOfferMarketIdFilter = new System.Windows.Forms.ComboBox();
            this.lblOrderListOfferMarketIdFilter = new System.Windows.Forms.Label();
            this.chkOrderListClientLinked = new System.Windows.Forms.CheckBox();
            this.lblOrderListClientMneFilter = new System.Windows.Forms.Label();
            this.txtOrderListClientMneFilter = new System.Windows.Forms.TextBox();
            this.cboOrderListListType = new System.Windows.Forms.ComboBox();
            this.lblOrderListDaysToList = new System.Windows.Forms.Label();
            this.txtOrderListDaysToList = new System.Windows.Forms.TextBox();
            this.lblOrderListListType = new System.Windows.Forms.Label();
            this.lblOrderListOfferOfferIdFilter1 = new System.Windows.Forms.Label();
            this.txtOrderListOfferIdFilter1 = new System.Windows.Forms.TextBox();
            this.lblOrderListOfferStatusFilter = new System.Windows.Forms.Label();
            this.txtOrderListOfferStatusFilter = new System.Windows.Forms.TextBox();
            this.lblOrderListClientIdFilter = new System.Windows.Forms.Label();
            this.txtOrderListClientIdFilter = new System.Windows.Forms.TextBox();
            this.lstOrderList = new System.Windows.Forms.RichTextBox();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.tabPortfolio = new System.Windows.Forms.TabPage();
            this.cboPortfolioPortfolioMarketId = new System.Windows.Forms.ComboBox();
            this.lblPortfolioPortfolioMarketId = new System.Windows.Forms.Label();
            this.lblPortfolioUserMne = new System.Windows.Forms.Label();
            this.txtPortfolioUserMne = new System.Windows.Forms.TextBox();
            this.cboPortfolioPortfolioType = new System.Windows.Forms.ComboBox();
            this.lblPortfolioPortfolioType = new System.Windows.Forms.Label();
            this.lblPortfolioUser = new System.Windows.Forms.Label();
            this.txtPortfolioUser = new System.Windows.Forms.TextBox();
            this.lstPortfolio = new System.Windows.Forms.RichTextBox();
            this.btnPortfolio = new System.Windows.Forms.Button();
            this.tabRuleVerifyQuotes = new System.Windows.Forms.TabPage();
            this.chkRuleVerifyQuotesAfterMarket = new System.Windows.Forms.CheckBox();
            this.cboRuleVerifyQuotesSide = new System.Windows.Forms.ComboBox();
            this.lblRuleVerifyQuotesSide = new System.Windows.Forms.Label();
            this.lblRuleVerifyQuotesSourceID = new System.Windows.Forms.Label();
            this.txtRuleVerifyQuotesSourceID = new System.Windows.Forms.TextBox();
            this.lblRuleVerifyQuotesSymbolID = new System.Windows.Forms.Label();
            this.txtRuleVerifyQuotesSymbolID = new System.Windows.Forms.TextBox();
            this.lblRuleVerifyQuotesUserMne = new System.Windows.Forms.Label();
            this.txtRuleVerifyQuotesUserMne = new System.Windows.Forms.TextBox();
            this.lblRuleVerifyQuotesUser = new System.Windows.Forms.Label();
            this.txtRuleVerifyQuotesUser = new System.Windows.Forms.TextBox();
            this.lstRuleVerifyQuotes = new System.Windows.Forms.RichTextBox();
            this.btnRuleVerifyQuotes = new System.Windows.Forms.Button();
            this.tabFinancialStatements = new System.Windows.Forms.TabPage();
            this.lstFinancialStatements = new System.Windows.Forms.RichTextBox();
            this.lblFinancialStatementsUserMne = new System.Windows.Forms.Label();
            this.txtFinancialStatementsUserMne = new System.Windows.Forms.TextBox();
            this.lblFinancialStatementsUser = new System.Windows.Forms.Label();
            this.txtFinancialStatementsUser = new System.Windows.Forms.TextBox();
            this.btnFinancialStatements = new System.Windows.Forms.Button();
            this.tabMarketSymbol = new System.Windows.Forms.TabPage();
            this.lblMarketSymbolSourceId = new System.Windows.Forms.Label();
            this.txtMarketSymbolSourceId = new System.Windows.Forms.TextBox();
            this.txtMarketSymbolInfo = new System.Windows.Forms.RichTextBox();
            this.lblSymbolId = new System.Windows.Forms.Label();
            this.txtMarketSymbolId = new System.Windows.Forms.TextBox();
            this.btnMarketSymbolInfo = new System.Windows.Forms.Button();
            this.tabSendOptionExercise = new System.Windows.Forms.TabPage();
            this.cboMarketIdSendOption = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUserMneSendOption = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUserSendOption = new System.Windows.Forms.TextBox();
            this.btnSendOption = new System.Windows.Forms.Button();
            this.txtResultSendOption = new System.Windows.Forms.RichTextBox();
            this.chkConfirmationSendOption = new System.Windows.Forms.CheckBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.txtSignatureSendOption = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQuantitySendOption = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSourceIdSendOption = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSymbolSendOption = new System.Windows.Forms.TextBox();
            this.tabMonitoring = new System.Windows.Forms.TabPage();
            this.lblSessioninstrumentationAction = new System.Windows.Forms.Label();
            this.txtSessioninstrumentationAction = new System.Windows.Forms.TextBox();
            this.chkInstrumentationIcase = new System.Windows.Forms.CheckBox();
            this.lblInstrumentationClass = new System.Windows.Forms.Label();
            this.txtInstrumentationClass = new System.Windows.Forms.TextBox();
            this.lblSessionStreamerId = new System.Windows.Forms.Label();
            this.txtSessionStreamerIdInstrumentation = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStreamerIdInstrumentation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPasswordInstrumentation = new System.Windows.Forms.TextBox();
            this.txtUserInstrumentation = new System.Windows.Forms.TextBox();
            this.cboInstrumentation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdminPwd = new System.Windows.Forms.TextBox();
            this.txtAdminUser = new System.Windows.Forms.TextBox();
            this.txtInstrumentation = new System.Windows.Forms.RichTextBox();
            this.btnInstrumentation = new System.Windows.Forms.Button();
            this.txtPingRequest = new System.Windows.Forms.RichTextBox();
            this.txtAudit = new System.Windows.Forms.RichTextBox();
            this.btnAudit = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.txtCheck = new System.Windows.Forms.RichTextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.chkHealthCheck = new System.Windows.Forms.CheckBox();
            this.lstHealthCheck = new System.Windows.Forms.RichTextBox();
            this.btnHealthCheck = new System.Windows.Forms.Button();
            this.tabLoadTest = new System.Windows.Forms.TabPage();
            this.txtMillisecondsToLoopingTest = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.rbTestQuotes = new System.Windows.Forms.RadioButton();
            this.rbTestOrder = new System.Windows.Forms.RadioButton();
            this.chkSignLoadTest = new System.Windows.Forms.CheckBox();
            this.txtLoadTest = new System.Windows.Forms.RichTextBox();
            this.numQtdAtores = new System.Windows.Forms.NumericUpDown();
            this.gridSubscriptionsLoadTest = new System.Windows.Forms.DataGridView();
            this.HiddenIdLoadTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnsignLoadTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LoadTestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QttActors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MillisecondsToRequestLooping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQttActors = new System.Windows.Forms.Label();
            this.btnAddLoadTest = new System.Windows.Forms.Button();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQttLogs = new System.Windows.Forms.Label();
            this.cboQttLogs = new System.Windows.Forms.ComboBox();
            this.cboLogs = new System.Windows.Forms.ComboBox();
            this.btnBuscarLog = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.tabPostman = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDownloadPostman = new System.Windows.Forms.ComboBox();
            this.btnDownloadPostman = new System.Windows.Forms.Button();
            this.txtDownloadPostman = new System.Windows.Forms.RichTextBox();
            this.chkJson = new System.Windows.Forms.CheckBox();
            this.chkEnableTrace = new System.Windows.Forms.CheckBox();
            this.openFileDialogProvider = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabInstantiate.SuspendLayout();
            this.tabQuotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubscriptions)).BeginInit();
            this.tabSymbolSearch.SuspendLayout();
            this.tabQuotesHistory.SuspendLayout();
            this.tabBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubscriptionsBook)).BeginInit();
            this.tabNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNews)).BeginInit();
            this.tabHighlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHighlights)).BeginInit();
            this.tabProvider.SuspendLayout();
            this.gbProviderConfigurations.SuspendLayout();
            this.tabClientList.SuspendLayout();
            this.tabOrderNew.SuspendLayout();
            this.tabOrderReplace.SuspendLayout();
            this.tabOrderCancel.SuspendLayout();
            this.tabOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderList)).BeginInit();
            this.tabPortfolio.SuspendLayout();
            this.tabRuleVerifyQuotes.SuspendLayout();
            this.tabFinancialStatements.SuspendLayout();
            this.tabMarketSymbol.SuspendLayout();
            this.tabSendOptionExercise.SuspendLayout();
            this.tabMonitoring.SuspendLayout();
            this.tabLoadTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMillisecondsToLoopingTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdAtores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubscriptionsLoadTest)).BeginInit();
            this.tabLog.SuspendLayout();
            this.tabPostman.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInstantiate);
            this.tabControl.Controls.Add(this.tabQuotes);
            this.tabControl.Controls.Add(this.tabSymbolSearch);
            this.tabControl.Controls.Add(this.tabQuotesHistory);
            this.tabControl.Controls.Add(this.tabBook);
            this.tabControl.Controls.Add(this.tabNews);
            this.tabControl.Controls.Add(this.tabHighlights);
            this.tabControl.Controls.Add(this.tabProvider);
            this.tabControl.Controls.Add(this.tabClientList);
            this.tabControl.Controls.Add(this.tabOrderNew);
            this.tabControl.Controls.Add(this.tabOrderReplace);
            this.tabControl.Controls.Add(this.tabOrderCancel);
            this.tabControl.Controls.Add(this.tabOrderList);
            this.tabControl.Controls.Add(this.tabPortfolio);
            this.tabControl.Controls.Add(this.tabRuleVerifyQuotes);
            this.tabControl.Controls.Add(this.tabFinancialStatements);
            this.tabControl.Controls.Add(this.tabMarketSymbol);
            this.tabControl.Controls.Add(this.tabSendOptionExercise);
            this.tabControl.Controls.Add(this.tabMonitoring);
            this.tabControl.Controls.Add(this.tabLoadTest);
            this.tabControl.Controls.Add(this.tabLog);
            this.tabControl.Controls.Add(this.tabPostman);
            this.tabControl.Location = new System.Drawing.Point(4, 7);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(833, 571);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabInstantiate
            // 
            this.tabInstantiate.Controls.Add(this.richTextInstantiate);
            this.tabInstantiate.Controls.Add(this.btnDisconnect);
            this.tabInstantiate.Controls.Add(this.btnInstantiate);
            this.tabInstantiate.Controls.Add(this.lblLoginTokenKeyLength);
            this.tabInstantiate.Controls.Add(this.txtLoginTokenKeyLength);
            this.tabInstantiate.Controls.Add(this.lblLoginTokenSaltIterations);
            this.tabInstantiate.Controls.Add(this.txtLoginTokenSaltIterations);
            this.tabInstantiate.Controls.Add(this.lblLoginTokenSaltKey);
            this.tabInstantiate.Controls.Add(this.txtLoginTokenSaltKey);
            this.tabInstantiate.Controls.Add(this.lblLoginTokenIvKey);
            this.tabInstantiate.Controls.Add(this.txtLoginTokenIvKey);
            this.tabInstantiate.Controls.Add(this.lblLoginTokenSecretKey);
            this.tabInstantiate.Controls.Add(this.txtLoginTokenSecretKey);
            this.tabInstantiate.Controls.Add(this.lblChannel);
            this.tabInstantiate.Controls.Add(this.txtChannel);
            this.tabInstantiate.Controls.Add(this.lblTransport);
            this.tabInstantiate.Controls.Add(this.txtTransport);
            this.tabInstantiate.Controls.Add(this.lblCustomerId);
            this.tabInstantiate.Controls.Add(this.txtCustomerId);
            this.tabInstantiate.Controls.Add(this.lblService);
            this.tabInstantiate.Controls.Add(this.txtService);
            this.tabInstantiate.Controls.Add(this.lblPassword);
            this.tabInstantiate.Controls.Add(this.txtPassword);
            this.tabInstantiate.Controls.Add(this.lblUser);
            this.tabInstantiate.Controls.Add(this.txtUser);
            this.tabInstantiate.Controls.Add(this.lblDomainId);
            this.tabInstantiate.Controls.Add(this.txtDomainId);
            this.tabInstantiate.Controls.Add(this.lblAcceptorUrl);
            this.tabInstantiate.Controls.Add(this.txtAcceptorUrl);
            this.tabInstantiate.Controls.Add(this.lblInstanceName);
            this.tabInstantiate.Controls.Add(this.txtInstanceName);
            this.tabInstantiate.Location = new System.Drawing.Point(4, 22);
            this.tabInstantiate.Name = "tabInstantiate";
            this.tabInstantiate.Size = new System.Drawing.Size(825, 545);
            this.tabInstantiate.TabIndex = 15;
            this.tabInstantiate.Text = "Inicialização";
            this.tabInstantiate.UseVisualStyleBackColor = true;
            // 
            // richTextInstantiate
            // 
            this.richTextInstantiate.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextInstantiate.Location = new System.Drawing.Point(15, 342);
            this.richTextInstantiate.Name = "richTextInstantiate";
            this.richTextInstantiate.Size = new System.Drawing.Size(796, 186);
            this.richTextInstantiate.TabIndex = 48;
            this.richTextInstantiate.Text = "";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Red;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDisconnect.Location = new System.Drawing.Point(585, 123);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(142, 40);
            this.btnDisconnect.TabIndex = 47;
            this.btnDisconnect.Text = "Desconectar";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnInstantiate
            // 
            this.btnInstantiate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInstantiate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstantiate.Location = new System.Drawing.Point(585, 45);
            this.btnInstantiate.Name = "btnInstantiate";
            this.btnInstantiate.Size = new System.Drawing.Size(142, 55);
            this.btnInstantiate.TabIndex = 46;
            this.btnInstantiate.Text = "Instanciar API";
            this.btnInstantiate.UseVisualStyleBackColor = false;
            this.btnInstantiate.Click += new System.EventHandler(this.btnInstantiate_Click);
            // 
            // lblLoginTokenKeyLength
            // 
            this.lblLoginTokenKeyLength.AutoSize = true;
            this.lblLoginTokenKeyLength.Location = new System.Drawing.Point(297, 282);
            this.lblLoginTokenKeyLength.Name = "lblLoginTokenKeyLength";
            this.lblLoginTokenKeyLength.Size = new System.Drawing.Size(115, 13);
            this.lblLoginTokenKeyLength.TabIndex = 44;
            this.lblLoginTokenKeyLength.Text = "LoginTokenKeyLength";
            // 
            // txtLoginTokenKeyLength
            // 
            this.txtLoginTokenKeyLength.Location = new System.Drawing.Point(300, 297);
            this.txtLoginTokenKeyLength.Name = "txtLoginTokenKeyLength";
            this.txtLoginTokenKeyLength.Size = new System.Drawing.Size(165, 20);
            this.txtLoginTokenKeyLength.TabIndex = 45;
            // 
            // lblLoginTokenSaltIterations
            // 
            this.lblLoginTokenSaltIterations.AutoSize = true;
            this.lblLoginTokenSaltIterations.Location = new System.Drawing.Point(297, 237);
            this.lblLoginTokenSaltIterations.Name = "lblLoginTokenSaltIterations";
            this.lblLoginTokenSaltIterations.Size = new System.Drawing.Size(125, 13);
            this.lblLoginTokenSaltIterations.TabIndex = 42;
            this.lblLoginTokenSaltIterations.Text = "LoginTokenSaltIterations";
            // 
            // txtLoginTokenSaltIterations
            // 
            this.txtLoginTokenSaltIterations.Location = new System.Drawing.Point(300, 252);
            this.txtLoginTokenSaltIterations.Name = "txtLoginTokenSaltIterations";
            this.txtLoginTokenSaltIterations.Size = new System.Drawing.Size(165, 20);
            this.txtLoginTokenSaltIterations.TabIndex = 43;
            // 
            // lblLoginTokenSaltKey
            // 
            this.lblLoginTokenSaltKey.AutoSize = true;
            this.lblLoginTokenSaltKey.Location = new System.Drawing.Point(297, 194);
            this.lblLoginTokenSaltKey.Name = "lblLoginTokenSaltKey";
            this.lblLoginTokenSaltKey.Size = new System.Drawing.Size(100, 13);
            this.lblLoginTokenSaltKey.TabIndex = 40;
            this.lblLoginTokenSaltKey.Text = "LoginTokenSaltKey";
            // 
            // txtLoginTokenSaltKey
            // 
            this.txtLoginTokenSaltKey.Location = new System.Drawing.Point(300, 209);
            this.txtLoginTokenSaltKey.Name = "txtLoginTokenSaltKey";
            this.txtLoginTokenSaltKey.Size = new System.Drawing.Size(165, 20);
            this.txtLoginTokenSaltKey.TabIndex = 41;
            // 
            // lblLoginTokenIvKey
            // 
            this.lblLoginTokenIvKey.AutoSize = true;
            this.lblLoginTokenIvKey.Location = new System.Drawing.Point(297, 150);
            this.lblLoginTokenIvKey.Name = "lblLoginTokenIvKey";
            this.lblLoginTokenIvKey.Size = new System.Drawing.Size(91, 13);
            this.lblLoginTokenIvKey.TabIndex = 38;
            this.lblLoginTokenIvKey.Text = "LoginTokenIvKey";
            // 
            // txtLoginTokenIvKey
            // 
            this.txtLoginTokenIvKey.Location = new System.Drawing.Point(300, 165);
            this.txtLoginTokenIvKey.Name = "txtLoginTokenIvKey";
            this.txtLoginTokenIvKey.Size = new System.Drawing.Size(165, 20);
            this.txtLoginTokenIvKey.TabIndex = 39;
            // 
            // lblLoginTokenSecretKey
            // 
            this.lblLoginTokenSecretKey.AutoSize = true;
            this.lblLoginTokenSecretKey.Location = new System.Drawing.Point(297, 108);
            this.lblLoginTokenSecretKey.Name = "lblLoginTokenSecretKey";
            this.lblLoginTokenSecretKey.Size = new System.Drawing.Size(113, 13);
            this.lblLoginTokenSecretKey.TabIndex = 36;
            this.lblLoginTokenSecretKey.Text = "LoginTokenSecretKey";
            // 
            // txtLoginTokenSecretKey
            // 
            this.txtLoginTokenSecretKey.Location = new System.Drawing.Point(300, 123);
            this.txtLoginTokenSecretKey.Name = "txtLoginTokenSecretKey";
            this.txtLoginTokenSecretKey.Size = new System.Drawing.Size(165, 20);
            this.txtLoginTokenSecretKey.TabIndex = 37;
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(297, 65);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(46, 13);
            this.lblChannel.TabIndex = 34;
            this.lblChannel.Text = "Channel";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(300, 80);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(165, 20);
            this.txtChannel.TabIndex = 35;
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(297, 23);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(52, 13);
            this.lblTransport.TabIndex = 32;
            this.lblTransport.Text = "Transport";
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(300, 38);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(165, 20);
            this.txtTransport.TabIndex = 33;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(12, 282);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(60, 13);
            this.lblCustomerId.TabIndex = 30;
            this.lblCustomerId.Text = "CustomerId";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(15, 297);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(165, 20);
            this.txtCustomerId.TabIndex = 31;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(12, 237);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(43, 13);
            this.lblService.TabIndex = 28;
            this.lblService.Text = "Service";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(15, 252);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(165, 20);
            this.txtService.TabIndex = 29;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 194);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 209);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 27;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 150);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 24;
            this.lblUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(15, 165);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(165, 20);
            this.txtUser.TabIndex = 25;
            // 
            // lblDomainId
            // 
            this.lblDomainId.AutoSize = true;
            this.lblDomainId.Location = new System.Drawing.Point(12, 108);
            this.lblDomainId.Name = "lblDomainId";
            this.lblDomainId.Size = new System.Drawing.Size(52, 13);
            this.lblDomainId.TabIndex = 22;
            this.lblDomainId.Text = "DomainId";
            // 
            // txtDomainId
            // 
            this.txtDomainId.Location = new System.Drawing.Point(15, 123);
            this.txtDomainId.Name = "txtDomainId";
            this.txtDomainId.Size = new System.Drawing.Size(165, 20);
            this.txtDomainId.TabIndex = 23;
            // 
            // lblAcceptorUrl
            // 
            this.lblAcceptorUrl.AutoSize = true;
            this.lblAcceptorUrl.Location = new System.Drawing.Point(12, 65);
            this.lblAcceptorUrl.Name = "lblAcceptorUrl";
            this.lblAcceptorUrl.Size = new System.Drawing.Size(63, 13);
            this.lblAcceptorUrl.TabIndex = 6;
            this.lblAcceptorUrl.Text = "AcceptorUrl";
            // 
            // txtAcceptorUrl
            // 
            this.txtAcceptorUrl.Location = new System.Drawing.Point(15, 80);
            this.txtAcceptorUrl.Name = "txtAcceptorUrl";
            this.txtAcceptorUrl.Size = new System.Drawing.Size(165, 20);
            this.txtAcceptorUrl.TabIndex = 7;
            // 
            // lblInstanceName
            // 
            this.lblInstanceName.AutoSize = true;
            this.lblInstanceName.Location = new System.Drawing.Point(12, 23);
            this.lblInstanceName.Name = "lblInstanceName";
            this.lblInstanceName.Size = new System.Drawing.Size(76, 13);
            this.lblInstanceName.TabIndex = 4;
            this.lblInstanceName.Text = "InstanceName";
            // 
            // txtInstanceName
            // 
            this.txtInstanceName.Location = new System.Drawing.Point(15, 38);
            this.txtInstanceName.Name = "txtInstanceName";
            this.txtInstanceName.Size = new System.Drawing.Size(165, 20);
            this.txtInstanceName.TabIndex = 5;
            // 
            // tabQuotes
            // 
            this.tabQuotes.Controls.Add(this.gridSubscriptions);
            this.tabQuotes.Controls.Add(this.chkOnlyDiffQuotes);
            this.tabQuotes.Controls.Add(this.chkSign);
            this.tabQuotes.Controls.Add(this.lblQuotesClientMneMD);
            this.tabQuotes.Controls.Add(this.txtQuotesClientMneMD);
            this.tabQuotes.Controls.Add(this.lblQuotesSourceID);
            this.tabQuotes.Controls.Add(this.txtQuotesSourceID);
            this.tabQuotes.Controls.Add(this.lblQuotesSymbolID);
            this.tabQuotes.Controls.Add(this.lstQuotes);
            this.tabQuotes.Controls.Add(this.txtQuotesSymbolID);
            this.tabQuotes.Controls.Add(this.btnQuotes);
            this.tabQuotes.Location = new System.Drawing.Point(4, 22);
            this.tabQuotes.Name = "tabQuotes";
            this.tabQuotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuotes.Size = new System.Drawing.Size(825, 545);
            this.tabQuotes.TabIndex = 0;
            this.tabQuotes.Text = "Quotes";
            this.tabQuotes.UseVisualStyleBackColor = true;
            // 
            // gridSubscriptions
            // 
            this.gridSubscriptions.AllowUserToAddRows = false;
            this.gridSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSubscriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HiddenId,
            this.Desassinar,
            this.Ativo});
            this.gridSubscriptions.Location = new System.Drawing.Point(15, 39);
            this.gridSubscriptions.Name = "gridSubscriptions";
            this.gridSubscriptions.RowHeadersVisible = false;
            this.gridSubscriptions.RowHeadersWidth = 62;
            this.gridSubscriptions.Size = new System.Drawing.Size(797, 274);
            this.gridSubscriptions.TabIndex = 11;
            this.gridSubscriptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSubscriptions_CellContentClick);
            // 
            // HiddenId
            // 
            this.HiddenId.Frozen = true;
            this.HiddenId.HeaderText = "HiddenId";
            this.HiddenId.MinimumWidth = 8;
            this.HiddenId.Name = "HiddenId";
            this.HiddenId.Visible = false;
            this.HiddenId.Width = 150;
            // 
            // Desassinar
            // 
            this.Desassinar.Frozen = true;
            this.Desassinar.HeaderText = "";
            this.Desassinar.MinimumWidth = 8;
            this.Desassinar.Name = "Desassinar";
            this.Desassinar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Desassinar.Width = 150;
            // 
            // Ativo
            // 
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.MinimumWidth = 8;
            this.Ativo.Name = "Ativo";
            this.Ativo.Width = 150;
            // 
            // chkOnlyDiffQuotes
            // 
            this.chkOnlyDiffQuotes.AutoSize = true;
            this.chkOnlyDiffQuotes.Location = new System.Drawing.Point(606, 13);
            this.chkOnlyDiffQuotes.Name = "chkOnlyDiffQuotes";
            this.chkOnlyDiffQuotes.Size = new System.Drawing.Size(76, 17);
            this.chkOnlyDiffQuotes.TabIndex = 10;
            this.chkOnlyDiffQuotes.Text = "Diferencial";
            this.chkOnlyDiffQuotes.UseVisualStyleBackColor = true;
            // 
            // chkSign
            // 
            this.chkSign.AutoSize = true;
            this.chkSign.Location = new System.Drawing.Point(540, 13);
            this.chkSign.Name = "chkSign";
            this.chkSign.Size = new System.Drawing.Size(60, 17);
            this.chkSign.TabIndex = 8;
            this.chkSign.Text = "Assinar";
            this.chkSign.UseVisualStyleBackColor = true;
            // 
            // lblQuotesClientMneMD
            // 
            this.lblQuotesClientMneMD.AutoSize = true;
            this.lblQuotesClientMneMD.Location = new System.Drawing.Point(376, 14);
            this.lblQuotesClientMneMD.Name = "lblQuotesClientMneMD";
            this.lblQuotesClientMneMD.Size = new System.Drawing.Size(71, 13);
            this.lblQuotesClientMneMD.TabIndex = 6;
            this.lblQuotesClientMneMD.Text = "ClientMneMD";
            // 
            // txtQuotesClientMneMD
            // 
            this.txtQuotesClientMneMD.Location = new System.Drawing.Point(453, 12);
            this.txtQuotesClientMneMD.Name = "txtQuotesClientMneMD";
            this.txtQuotesClientMneMD.Size = new System.Drawing.Size(60, 20);
            this.txtQuotesClientMneMD.TabIndex = 7;
            // 
            // lblQuotesSourceID
            // 
            this.lblQuotesSourceID.AutoSize = true;
            this.lblQuotesSourceID.Location = new System.Drawing.Point(12, 15);
            this.lblQuotesSourceID.Name = "lblQuotesSourceID";
            this.lblQuotesSourceID.Size = new System.Drawing.Size(52, 13);
            this.lblQuotesSourceID.TabIndex = 2;
            this.lblQuotesSourceID.Text = "SourceID";
            // 
            // txtQuotesSourceID
            // 
            this.txtQuotesSourceID.Location = new System.Drawing.Point(70, 11);
            this.txtQuotesSourceID.Name = "txtQuotesSourceID";
            this.txtQuotesSourceID.Size = new System.Drawing.Size(24, 20);
            this.txtQuotesSourceID.TabIndex = 3;
            this.txtQuotesSourceID.Text = "12";
            // 
            // lblQuotesSymbolID
            // 
            this.lblQuotesSymbolID.AutoSize = true;
            this.lblQuotesSymbolID.Location = new System.Drawing.Point(106, 15);
            this.lblQuotesSymbolID.Name = "lblQuotesSymbolID";
            this.lblQuotesSymbolID.Size = new System.Drawing.Size(52, 13);
            this.lblQuotesSymbolID.TabIndex = 4;
            this.lblQuotesSymbolID.Text = "SymbolID";
            // 
            // lstQuotes
            // 
            this.lstQuotes.Location = new System.Drawing.Point(15, 319);
            this.lstQuotes.Name = "lstQuotes";
            this.lstQuotes.ReadOnly = true;
            this.lstQuotes.Size = new System.Drawing.Size(797, 208);
            this.lstQuotes.TabIndex = 7;
            this.lstQuotes.Text = "";
            // 
            // txtQuotesSymbolID
            // 
            this.txtQuotesSymbolID.Location = new System.Drawing.Point(164, 11);
            this.txtQuotesSymbolID.Name = "txtQuotesSymbolID";
            this.txtQuotesSymbolID.Size = new System.Drawing.Size(196, 20);
            this.txtQuotesSymbolID.TabIndex = 5;
            this.txtQuotesSymbolID.Text = "PETR4,MGLU3";
            // 
            // btnQuotes
            // 
            this.btnQuotes.Location = new System.Drawing.Point(737, 10);
            this.btnQuotes.Name = "btnQuotes";
            this.btnQuotes.Size = new System.Drawing.Size(75, 23);
            this.btnQuotes.TabIndex = 7;
            this.btnQuotes.Text = "Buscar";
            this.btnQuotes.UseVisualStyleBackColor = true;
            this.btnQuotes.Click += new System.EventHandler(this.btnQuotes_Click);
            // 
            // tabSymbolSearch
            // 
            this.tabSymbolSearch.Controls.Add(this.cboSymbolMarket);
            this.tabSymbolSearch.Controls.Add(this.lblSymbolSourceID);
            this.tabSymbolSearch.Controls.Add(this.txtSymbolSourceID);
            this.tabSymbolSearch.Controls.Add(this.lblSymbolMarket);
            this.tabSymbolSearch.Controls.Add(this.lblSymbolDescricao);
            this.tabSymbolSearch.Controls.Add(this.txtSymbolDescription);
            this.tabSymbolSearch.Controls.Add(this.lblSymbol);
            this.tabSymbolSearch.Controls.Add(this.lstSymbol);
            this.tabSymbolSearch.Controls.Add(this.txtSymbol);
            this.tabSymbolSearch.Controls.Add(this.btnSymbol);
            this.tabSymbolSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSymbolSearch.Name = "tabSymbolSearch";
            this.tabSymbolSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSymbolSearch.Size = new System.Drawing.Size(825, 545);
            this.tabSymbolSearch.TabIndex = 1;
            this.tabSymbolSearch.Text = "SymbolSearch";
            this.tabSymbolSearch.UseVisualStyleBackColor = true;
            // 
            // cboSymbolMarket
            // 
            this.cboSymbolMarket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSymbolMarket.FormattingEnabled = true;
            this.cboSymbolMarket.Items.AddRange(new object[] {
            "",
            "E",
            "F",
            "G",
            "I",
            "J",
            "O",
            "R",
            "T",
            "U",
            "V",
            "X"});
            this.cboSymbolMarket.Location = new System.Drawing.Point(494, 12);
            this.cboSymbolMarket.Name = "cboSymbolMarket";
            this.cboSymbolMarket.Size = new System.Drawing.Size(44, 21);
            this.cboSymbolMarket.TabIndex = 7;
            // 
            // lblSymbolSourceID
            // 
            this.lblSymbolSourceID.AutoSize = true;
            this.lblSymbolSourceID.Location = new System.Drawing.Point(19, 16);
            this.lblSymbolSourceID.Name = "lblSymbolSourceID";
            this.lblSymbolSourceID.Size = new System.Drawing.Size(52, 13);
            this.lblSymbolSourceID.TabIndex = 0;
            this.lblSymbolSourceID.Text = "SourceID";
            // 
            // txtSymbolSourceID
            // 
            this.txtSymbolSourceID.Location = new System.Drawing.Point(77, 12);
            this.txtSymbolSourceID.Name = "txtSymbolSourceID";
            this.txtSymbolSourceID.Size = new System.Drawing.Size(24, 20);
            this.txtSymbolSourceID.TabIndex = 1;
            this.txtSymbolSourceID.Text = "12";
            // 
            // lblSymbolMarket
            // 
            this.lblSymbolMarket.AutoSize = true;
            this.lblSymbolMarket.Location = new System.Drawing.Point(449, 16);
            this.lblSymbolMarket.Name = "lblSymbolMarket";
            this.lblSymbolMarket.Size = new System.Drawing.Size(40, 13);
            this.lblSymbolMarket.TabIndex = 6;
            this.lblSymbolMarket.Text = "Market";
            // 
            // lblSymbolDescricao
            // 
            this.lblSymbolDescricao.AutoSize = true;
            this.lblSymbolDescricao.Location = new System.Drawing.Point(238, 16);
            this.lblSymbolDescricao.Name = "lblSymbolDescricao";
            this.lblSymbolDescricao.Size = new System.Drawing.Size(60, 13);
            this.lblSymbolDescricao.TabIndex = 4;
            this.lblSymbolDescricao.Text = "Description";
            // 
            // txtSymbolDescription
            // 
            this.txtSymbolDescription.Location = new System.Drawing.Point(299, 12);
            this.txtSymbolDescription.Name = "txtSymbolDescription";
            this.txtSymbolDescription.Size = new System.Drawing.Size(144, 20);
            this.txtSymbolDescription.TabIndex = 5;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(113, 16);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(41, 13);
            this.lblSymbol.TabIndex = 2;
            this.lblSymbol.Text = "Symbol";
            // 
            // lstSymbol
            // 
            this.lstSymbol.Location = new System.Drawing.Point(16, 38);
            this.lstSymbol.Name = "lstSymbol";
            this.lstSymbol.ReadOnly = true;
            this.lstSymbol.Size = new System.Drawing.Size(794, 489);
            this.lstSymbol.TabIndex = 9;
            this.lstSymbol.Text = "";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(160, 12);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(72, 20);
            this.txtSymbol.TabIndex = 3;
            this.txtSymbol.Text = "PETR4";
            // 
            // btnSymbol
            // 
            this.btnSymbol.Location = new System.Drawing.Point(735, 11);
            this.btnSymbol.Name = "btnSymbol";
            this.btnSymbol.Size = new System.Drawing.Size(75, 23);
            this.btnSymbol.TabIndex = 8;
            this.btnSymbol.Text = "Buscar";
            this.btnSymbol.UseVisualStyleBackColor = true;
            this.btnSymbol.Click += new System.EventHandler(this.btnSymbol_Click);
            // 
            // tabQuotesHistory
            // 
            this.tabQuotesHistory.Controls.Add(this.chkQuotesHistorySign);
            this.tabQuotesHistory.Controls.Add(this.formsPlotQuotesHistory);
            this.tabQuotesHistory.Controls.Add(this.lblQuotesHistoryDateTo);
            this.tabQuotesHistory.Controls.Add(this.txtQuotesHistoryDateTo);
            this.tabQuotesHistory.Controls.Add(this.lblQuotesHistoryDateFrom);
            this.tabQuotesHistory.Controls.Add(this.txtQuotesHistoryDateFrom);
            this.tabQuotesHistory.Controls.Add(this.lblQuotesHistoryCLientMneMD);
            this.tabQuotesHistory.Controls.Add(this.txtQuotesHistoryCLientMneMD);
            this.tabQuotesHistory.Controls.Add(this.cboQuotesHistoryPeriod);
            this.tabQuotesHistory.Controls.Add(this.lblQuotesHistoryPeriod);
            this.tabQuotesHistory.Controls.Add(this.lblQuotesHistorySourceID);
            this.tabQuotesHistory.Controls.Add(this.txtQuotesHistorySourceID);
            this.tabQuotesHistory.Controls.Add(this.lblQuotesHistorySymbolID);
            this.tabQuotesHistory.Controls.Add(this.lstQuotesHistory);
            this.tabQuotesHistory.Controls.Add(this.txtQuotesHistorySymbolID);
            this.tabQuotesHistory.Controls.Add(this.btnQuotesHistory);
            this.tabQuotesHistory.Location = new System.Drawing.Point(4, 22);
            this.tabQuotesHistory.Name = "tabQuotesHistory";
            this.tabQuotesHistory.Size = new System.Drawing.Size(825, 545);
            this.tabQuotesHistory.TabIndex = 12;
            this.tabQuotesHistory.Text = "HistoricalData";
            this.tabQuotesHistory.UseVisualStyleBackColor = true;
            // 
            // chkQuotesHistorySign
            // 
            this.chkQuotesHistorySign.AutoSize = true;
            this.chkQuotesHistorySign.Location = new System.Drawing.Point(678, 10);
            this.chkQuotesHistorySign.Name = "chkQuotesHistorySign";
            this.chkQuotesHistorySign.Size = new System.Drawing.Size(60, 17);
            this.chkQuotesHistorySign.TabIndex = 15;
            this.chkQuotesHistorySign.Text = "Assinar";
            this.chkQuotesHistorySign.UseVisualStyleBackColor = true;
            this.chkQuotesHistorySign.CheckedChanged += new System.EventHandler(this.chkQuotesHistorySign_CheckedChanged);
            // 
            // formsPlotQuotesHistory
            // 
            this.formsPlotQuotesHistory.Location = new System.Drawing.Point(22, 38);
            this.formsPlotQuotesHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formsPlotQuotesHistory.Name = "formsPlotQuotesHistory";
            this.formsPlotQuotesHistory.Size = new System.Drawing.Size(787, 296);
            this.formsPlotQuotesHistory.TabIndex = 14;
            // 
            // lblQuotesHistoryDateTo
            // 
            this.lblQuotesHistoryDateTo.AutoSize = true;
            this.lblQuotesHistoryDateTo.Location = new System.Drawing.Point(427, 14);
            this.lblQuotesHistoryDateTo.Name = "lblQuotesHistoryDateTo";
            this.lblQuotesHistoryDateTo.Size = new System.Drawing.Size(43, 13);
            this.lblQuotesHistoryDateTo.TabIndex = 8;
            this.lblQuotesHistoryDateTo.Text = "DateTo";
            // 
            // txtQuotesHistoryDateTo
            // 
            this.txtQuotesHistoryDateTo.Location = new System.Drawing.Point(472, 8);
            this.txtQuotesHistoryDateTo.Name = "txtQuotesHistoryDateTo";
            this.txtQuotesHistoryDateTo.Size = new System.Drawing.Size(60, 20);
            this.txtQuotesHistoryDateTo.TabIndex = 9;
            // 
            // lblQuotesHistoryDateFrom
            // 
            this.lblQuotesHistoryDateFrom.AutoSize = true;
            this.lblQuotesHistoryDateFrom.Location = new System.Drawing.Point(304, 13);
            this.lblQuotesHistoryDateFrom.Name = "lblQuotesHistoryDateFrom";
            this.lblQuotesHistoryDateFrom.Size = new System.Drawing.Size(53, 13);
            this.lblQuotesHistoryDateFrom.TabIndex = 6;
            this.lblQuotesHistoryDateFrom.Text = "DateFrom";
            // 
            // txtQuotesHistoryDateFrom
            // 
            this.txtQuotesHistoryDateFrom.Location = new System.Drawing.Point(359, 9);
            this.txtQuotesHistoryDateFrom.Name = "txtQuotesHistoryDateFrom";
            this.txtQuotesHistoryDateFrom.Size = new System.Drawing.Size(60, 20);
            this.txtQuotesHistoryDateFrom.TabIndex = 7;
            // 
            // lblQuotesHistoryCLientMneMD
            // 
            this.lblQuotesHistoryCLientMneMD.AutoSize = true;
            this.lblQuotesHistoryCLientMneMD.Location = new System.Drawing.Point(538, 12);
            this.lblQuotesHistoryCLientMneMD.Name = "lblQuotesHistoryCLientMneMD";
            this.lblQuotesHistoryCLientMneMD.Size = new System.Drawing.Size(71, 13);
            this.lblQuotesHistoryCLientMneMD.TabIndex = 10;
            this.lblQuotesHistoryCLientMneMD.Text = "ClientMneMD";
            // 
            // txtQuotesHistoryCLientMneMD
            // 
            this.txtQuotesHistoryCLientMneMD.Location = new System.Drawing.Point(612, 8);
            this.txtQuotesHistoryCLientMneMD.Name = "txtQuotesHistoryCLientMneMD";
            this.txtQuotesHistoryCLientMneMD.Size = new System.Drawing.Size(60, 20);
            this.txtQuotesHistoryCLientMneMD.TabIndex = 11;
            // 
            // cboQuotesHistoryPeriod
            // 
            this.cboQuotesHistoryPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuotesHistoryPeriod.FormattingEnabled = true;
            this.cboQuotesHistoryPeriod.Items.AddRange(new object[] {
            "1m",
            "5m",
            "10m",
            "20m",
            "30m",
            "1h",
            "3h",
            "1d",
            "5d",
            "weekly ",
            "monthly",
            "yearly"});
            this.cboQuotesHistoryPeriod.Location = new System.Drawing.Point(250, 8);
            this.cboQuotesHistoryPeriod.Name = "cboQuotesHistoryPeriod";
            this.cboQuotesHistoryPeriod.Size = new System.Drawing.Size(48, 21);
            this.cboQuotesHistoryPeriod.TabIndex = 5;
            // 
            // lblQuotesHistoryPeriod
            // 
            this.lblQuotesHistoryPeriod.AutoSize = true;
            this.lblQuotesHistoryPeriod.Location = new System.Drawing.Point(207, 12);
            this.lblQuotesHistoryPeriod.Name = "lblQuotesHistoryPeriod";
            this.lblQuotesHistoryPeriod.Size = new System.Drawing.Size(37, 13);
            this.lblQuotesHistoryPeriod.TabIndex = 4;
            this.lblQuotesHistoryPeriod.Text = "Period";
            // 
            // lblQuotesHistorySourceID
            // 
            this.lblQuotesHistorySourceID.AutoSize = true;
            this.lblQuotesHistorySourceID.Location = new System.Drawing.Point(3, 12);
            this.lblQuotesHistorySourceID.Name = "lblQuotesHistorySourceID";
            this.lblQuotesHistorySourceID.Size = new System.Drawing.Size(52, 13);
            this.lblQuotesHistorySourceID.TabIndex = 0;
            this.lblQuotesHistorySourceID.Text = "SourceID";
            // 
            // txtQuotesHistorySourceID
            // 
            this.txtQuotesHistorySourceID.Location = new System.Drawing.Point(57, 8);
            this.txtQuotesHistorySourceID.Name = "txtQuotesHistorySourceID";
            this.txtQuotesHistorySourceID.Size = new System.Drawing.Size(24, 20);
            this.txtQuotesHistorySourceID.TabIndex = 1;
            this.txtQuotesHistorySourceID.Text = "12";
            // 
            // lblQuotesHistorySymbolID
            // 
            this.lblQuotesHistorySymbolID.AutoSize = true;
            this.lblQuotesHistorySymbolID.Location = new System.Drawing.Point(86, 12);
            this.lblQuotesHistorySymbolID.Name = "lblQuotesHistorySymbolID";
            this.lblQuotesHistorySymbolID.Size = new System.Drawing.Size(52, 13);
            this.lblQuotesHistorySymbolID.TabIndex = 2;
            this.lblQuotesHistorySymbolID.Text = "SymbolID";
            // 
            // lstQuotesHistory
            // 
            this.lstQuotesHistory.Location = new System.Drawing.Point(22, 340);
            this.lstQuotesHistory.Name = "lstQuotesHistory";
            this.lstQuotesHistory.ReadOnly = true;
            this.lstQuotesHistory.Size = new System.Drawing.Size(787, 187);
            this.lstQuotesHistory.TabIndex = 13;
            this.lstQuotesHistory.Text = "";
            // 
            // txtQuotesHistorySymbolID
            // 
            this.txtQuotesHistorySymbolID.Location = new System.Drawing.Point(139, 8);
            this.txtQuotesHistorySymbolID.Name = "txtQuotesHistorySymbolID";
            this.txtQuotesHistorySymbolID.Size = new System.Drawing.Size(65, 20);
            this.txtQuotesHistorySymbolID.TabIndex = 3;
            this.txtQuotesHistorySymbolID.Text = "PETR4";
            // 
            // btnQuotesHistory
            // 
            this.btnQuotesHistory.Location = new System.Drawing.Point(744, 6);
            this.btnQuotesHistory.Name = "btnQuotesHistory";
            this.btnQuotesHistory.Size = new System.Drawing.Size(75, 23);
            this.btnQuotesHistory.TabIndex = 12;
            this.btnQuotesHistory.Text = "Buscar";
            this.btnQuotesHistory.UseVisualStyleBackColor = true;
            this.btnQuotesHistory.Click += new System.EventHandler(this.btnQuotesHistory_Click);
            // 
            // tabBook
            // 
            this.tabBook.Controls.Add(this.gridSubscriptionsBook);
            this.tabBook.Controls.Add(this.chkBookSign);
            this.tabBook.Controls.Add(this.lblBookClientMneMD);
            this.tabBook.Controls.Add(this.txtBookClientMneMD);
            this.tabBook.Controls.Add(this.cboBookConsolidate);
            this.tabBook.Controls.Add(this.lblBookConsolidate);
            this.tabBook.Controls.Add(this.lblBookDeep);
            this.tabBook.Controls.Add(this.txtBookDeep);
            this.tabBook.Controls.Add(this.lblBookSourceID);
            this.tabBook.Controls.Add(this.txtBookSourceID);
            this.tabBook.Controls.Add(this.lblBookSymbolID);
            this.tabBook.Controls.Add(this.lstBook);
            this.tabBook.Controls.Add(this.txtBookSymbolID);
            this.tabBook.Controls.Add(this.btnBook);
            this.tabBook.Location = new System.Drawing.Point(4, 22);
            this.tabBook.Name = "tabBook";
            this.tabBook.Size = new System.Drawing.Size(825, 545);
            this.tabBook.TabIndex = 8;
            this.tabBook.Text = "Book";
            this.tabBook.UseVisualStyleBackColor = true;
            // 
            // gridSubscriptionsBook
            // 
            this.gridSubscriptionsBook.AllowUserToAddRows = false;
            this.gridSubscriptionsBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSubscriptionsBook.Location = new System.Drawing.Point(26, 37);
            this.gridSubscriptionsBook.Name = "gridSubscriptionsBook";
            this.gridSubscriptionsBook.RowHeadersVisible = false;
            this.gridSubscriptionsBook.RowHeadersWidth = 62;
            this.gridSubscriptionsBook.Size = new System.Drawing.Size(787, 309);
            this.gridSubscriptionsBook.TabIndex = 14;
            this.gridSubscriptionsBook.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridSubscriptionsBook_DataGridViewCellFormatting);
            // 
            // chkBookSign
            // 
            this.chkBookSign.AutoSize = true;
            this.chkBookSign.Location = new System.Drawing.Point(640, 9);
            this.chkBookSign.Name = "chkBookSign";
            this.chkBookSign.Size = new System.Drawing.Size(60, 17);
            this.chkBookSign.TabIndex = 13;
            this.chkBookSign.Text = "Assinar";
            this.chkBookSign.UseVisualStyleBackColor = true;
            this.chkBookSign.CheckedChanged += new System.EventHandler(this.chkBookSign_CheckedChanged);
            // 
            // lblBookClientMneMD
            // 
            this.lblBookClientMneMD.AutoSize = true;
            this.lblBookClientMneMD.Location = new System.Drawing.Point(479, 13);
            this.lblBookClientMneMD.Name = "lblBookClientMneMD";
            this.lblBookClientMneMD.Size = new System.Drawing.Size(71, 13);
            this.lblBookClientMneMD.TabIndex = 8;
            this.lblBookClientMneMD.Text = "ClientMneMD";
            // 
            // txtBookClientMneMD
            // 
            this.txtBookClientMneMD.Location = new System.Drawing.Point(553, 9);
            this.txtBookClientMneMD.Name = "txtBookClientMneMD";
            this.txtBookClientMneMD.Size = new System.Drawing.Size(60, 20);
            this.txtBookClientMneMD.TabIndex = 9;
            // 
            // cboBookConsolidate
            // 
            this.cboBookConsolidate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookConsolidate.FormattingEnabled = true;
            this.cboBookConsolidate.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cboBookConsolidate.Location = new System.Drawing.Point(418, 9);
            this.cboBookConsolidate.Name = "cboBookConsolidate";
            this.cboBookConsolidate.Size = new System.Drawing.Size(50, 21);
            this.cboBookConsolidate.TabIndex = 7;
            // 
            // lblBookConsolidate
            // 
            this.lblBookConsolidate.AutoSize = true;
            this.lblBookConsolidate.Location = new System.Drawing.Point(350, 13);
            this.lblBookConsolidate.Name = "lblBookConsolidate";
            this.lblBookConsolidate.Size = new System.Drawing.Size(62, 13);
            this.lblBookConsolidate.TabIndex = 6;
            this.lblBookConsolidate.Text = "Consolidate";
            // 
            // lblBookDeep
            // 
            this.lblBookDeep.AutoSize = true;
            this.lblBookDeep.Location = new System.Drawing.Point(256, 13);
            this.lblBookDeep.Name = "lblBookDeep";
            this.lblBookDeep.Size = new System.Drawing.Size(33, 13);
            this.lblBookDeep.TabIndex = 4;
            this.lblBookDeep.Text = "Deep";
            // 
            // txtBookDeep
            // 
            this.txtBookDeep.Location = new System.Drawing.Point(290, 9);
            this.txtBookDeep.Name = "txtBookDeep";
            this.txtBookDeep.Size = new System.Drawing.Size(48, 20);
            this.txtBookDeep.TabIndex = 5;
            this.txtBookDeep.Text = "10";
            // 
            // lblBookSourceID
            // 
            this.lblBookSourceID.AutoSize = true;
            this.lblBookSourceID.Location = new System.Drawing.Point(23, 13);
            this.lblBookSourceID.Name = "lblBookSourceID";
            this.lblBookSourceID.Size = new System.Drawing.Size(52, 13);
            this.lblBookSourceID.TabIndex = 0;
            this.lblBookSourceID.Text = "SourceID";
            // 
            // txtBookSourceID
            // 
            this.txtBookSourceID.Location = new System.Drawing.Point(81, 9);
            this.txtBookSourceID.Name = "txtBookSourceID";
            this.txtBookSourceID.Size = new System.Drawing.Size(24, 20);
            this.txtBookSourceID.TabIndex = 1;
            this.txtBookSourceID.Text = "12";
            // 
            // lblBookSymbolID
            // 
            this.lblBookSymbolID.AutoSize = true;
            this.lblBookSymbolID.Location = new System.Drawing.Point(117, 13);
            this.lblBookSymbolID.Name = "lblBookSymbolID";
            this.lblBookSymbolID.Size = new System.Drawing.Size(52, 13);
            this.lblBookSymbolID.TabIndex = 2;
            this.lblBookSymbolID.Text = "SymbolID";
            // 
            // lstBook
            // 
            this.lstBook.Location = new System.Drawing.Point(26, 352);
            this.lstBook.Name = "lstBook";
            this.lstBook.ReadOnly = true;
            this.lstBook.Size = new System.Drawing.Size(787, 186);
            this.lstBook.TabIndex = 11;
            this.lstBook.Text = "";
            // 
            // txtBookSymbolID
            // 
            this.txtBookSymbolID.Location = new System.Drawing.Point(175, 9);
            this.txtBookSymbolID.Name = "txtBookSymbolID";
            this.txtBookSymbolID.Size = new System.Drawing.Size(65, 20);
            this.txtBookSymbolID.TabIndex = 3;
            this.txtBookSymbolID.Text = "PETR4";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(738, 8);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Buscar";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // tabNews
            // 
            this.tabNews.Controls.Add(this.gridNews);
            this.tabNews.Controls.Add(this.chkNewsSign);
            this.tabNews.Controls.Add(this.lblNewsDateFilter);
            this.tabNews.Controls.Add(this.txtNewsDateFilter);
            this.tabNews.Controls.Add(this.lblNewsClientMneMD);
            this.tabNews.Controls.Add(this.txtNewsClientMneMD);
            this.tabNews.Controls.Add(this.lblNewsQuantity);
            this.tabNews.Controls.Add(this.txtNewsQuantity);
            this.tabNews.Controls.Add(this.lblNewsTextFilter);
            this.tabNews.Controls.Add(this.txtNewsTextFilter);
            this.tabNews.Controls.Add(this.lblNewsSubjectFilter);
            this.tabNews.Controls.Add(this.txtNewsSubjectFilter);
            this.tabNews.Controls.Add(this.lblNewsSourceID);
            this.tabNews.Controls.Add(this.txtNewsSourceID);
            this.tabNews.Controls.Add(this.lstNews);
            this.tabNews.Controls.Add(this.btnNews);
            this.tabNews.Location = new System.Drawing.Point(4, 22);
            this.tabNews.Name = "tabNews";
            this.tabNews.Size = new System.Drawing.Size(825, 545);
            this.tabNews.TabIndex = 9;
            this.tabNews.Text = "News";
            this.tabNews.UseVisualStyleBackColor = true;
            // 
            // gridNews
            // 
            this.gridNews.AllowUserToAddRows = false;
            this.gridNews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HiddenIdNews,
            this.Integra});
            this.gridNews.Location = new System.Drawing.Point(8, 36);
            this.gridNews.Name = "gridNews";
            this.gridNews.RowHeadersVisible = false;
            this.gridNews.RowHeadersWidth = 62;
            this.gridNews.Size = new System.Drawing.Size(802, 309);
            this.gridNews.TabIndex = 18;
            this.gridNews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNews_CellContentClick);
            // 
            // HiddenIdNews
            // 
            this.HiddenIdNews.HeaderText = "";
            this.HiddenIdNews.MinimumWidth = 8;
            this.HiddenIdNews.Name = "HiddenIdNews";
            this.HiddenIdNews.Visible = false;
            this.HiddenIdNews.Width = 150;
            // 
            // Integra
            // 
            this.Integra.HeaderText = "";
            this.Integra.MinimumWidth = 8;
            this.Integra.Name = "Integra";
            this.Integra.Text = "Ver íntegra";
            this.Integra.Width = 8;
            // 
            // chkNewsSign
            // 
            this.chkNewsSign.AutoSize = true;
            this.chkNewsSign.Location = new System.Drawing.Point(709, 11);
            this.chkNewsSign.Name = "chkNewsSign";
            this.chkNewsSign.Size = new System.Drawing.Size(60, 17);
            this.chkNewsSign.TabIndex = 14;
            this.chkNewsSign.Text = "Assinar";
            this.chkNewsSign.UseVisualStyleBackColor = true;
            // 
            // lblNewsDateFilter
            // 
            this.lblNewsDateFilter.AutoSize = true;
            this.lblNewsDateFilter.Location = new System.Drawing.Point(446, 13);
            this.lblNewsDateFilter.Name = "lblNewsDateFilter";
            this.lblNewsDateFilter.Size = new System.Drawing.Size(52, 13);
            this.lblNewsDateFilter.TabIndex = 8;
            this.lblNewsDateFilter.Text = "DateFilter";
            // 
            // txtNewsDateFilter
            // 
            this.txtNewsDateFilter.Location = new System.Drawing.Point(498, 9);
            this.txtNewsDateFilter.Name = "txtNewsDateFilter";
            this.txtNewsDateFilter.Size = new System.Drawing.Size(68, 20);
            this.txtNewsDateFilter.TabIndex = 9;
            // 
            // lblNewsClientMneMD
            // 
            this.lblNewsClientMneMD.AutoSize = true;
            this.lblNewsClientMneMD.Location = new System.Drawing.Point(569, 13);
            this.lblNewsClientMneMD.Name = "lblNewsClientMneMD";
            this.lblNewsClientMneMD.Size = new System.Drawing.Size(71, 13);
            this.lblNewsClientMneMD.TabIndex = 10;
            this.lblNewsClientMneMD.Text = "ClientMneMD";
            // 
            // txtNewsClientMneMD
            // 
            this.txtNewsClientMneMD.Location = new System.Drawing.Point(641, 9);
            this.txtNewsClientMneMD.Name = "txtNewsClientMneMD";
            this.txtNewsClientMneMD.Size = new System.Drawing.Size(60, 20);
            this.txtNewsClientMneMD.TabIndex = 11;
            // 
            // lblNewsQuantity
            // 
            this.lblNewsQuantity.AutoSize = true;
            this.lblNewsQuantity.Location = new System.Drawing.Point(372, 13);
            this.lblNewsQuantity.Name = "lblNewsQuantity";
            this.lblNewsQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblNewsQuantity.TabIndex = 6;
            this.lblNewsQuantity.Text = "Quantity";
            // 
            // txtNewsQuantity
            // 
            this.txtNewsQuantity.Location = new System.Drawing.Point(419, 9);
            this.txtNewsQuantity.Name = "txtNewsQuantity";
            this.txtNewsQuantity.Size = new System.Drawing.Size(24, 20);
            this.txtNewsQuantity.TabIndex = 7;
            this.txtNewsQuantity.Text = "10";
            // 
            // lblNewsTextFilter
            // 
            this.lblNewsTextFilter.AutoSize = true;
            this.lblNewsTextFilter.Location = new System.Drawing.Point(234, 13);
            this.lblNewsTextFilter.Name = "lblNewsTextFilter";
            this.lblNewsTextFilter.Size = new System.Drawing.Size(50, 13);
            this.lblNewsTextFilter.TabIndex = 4;
            this.lblNewsTextFilter.Text = "TextFilter";
            // 
            // txtNewsTextFilter
            // 
            this.txtNewsTextFilter.Location = new System.Drawing.Point(285, 9);
            this.txtNewsTextFilter.Name = "txtNewsTextFilter";
            this.txtNewsTextFilter.Size = new System.Drawing.Size(82, 20);
            this.txtNewsTextFilter.TabIndex = 5;
            // 
            // lblNewsSubjectFilter
            // 
            this.lblNewsSubjectFilter.AutoSize = true;
            this.lblNewsSubjectFilter.Location = new System.Drawing.Point(84, 13);
            this.lblNewsSubjectFilter.Name = "lblNewsSubjectFilter";
            this.lblNewsSubjectFilter.Size = new System.Drawing.Size(65, 13);
            this.lblNewsSubjectFilter.TabIndex = 2;
            this.lblNewsSubjectFilter.Text = "SubjectFilter";
            // 
            // txtNewsSubjectFilter
            // 
            this.txtNewsSubjectFilter.Location = new System.Drawing.Point(149, 9);
            this.txtNewsSubjectFilter.Name = "txtNewsSubjectFilter";
            this.txtNewsSubjectFilter.Size = new System.Drawing.Size(82, 20);
            this.txtNewsSubjectFilter.TabIndex = 3;
            // 
            // lblNewsSourceID
            // 
            this.lblNewsSourceID.AutoSize = true;
            this.lblNewsSourceID.Location = new System.Drawing.Point(5, 13);
            this.lblNewsSourceID.Name = "lblNewsSourceID";
            this.lblNewsSourceID.Size = new System.Drawing.Size(52, 13);
            this.lblNewsSourceID.TabIndex = 0;
            this.lblNewsSourceID.Text = "SourceID";
            // 
            // txtNewsSourceID
            // 
            this.txtNewsSourceID.Location = new System.Drawing.Point(57, 9);
            this.txtNewsSourceID.Name = "txtNewsSourceID";
            this.txtNewsSourceID.Size = new System.Drawing.Size(24, 20);
            this.txtNewsSourceID.TabIndex = 1;
            this.txtNewsSourceID.Text = "12";
            // 
            // lstNews
            // 
            this.lstNews.Location = new System.Drawing.Point(8, 351);
            this.lstNews.Name = "lstNews";
            this.lstNews.ReadOnly = true;
            this.lstNews.Size = new System.Drawing.Size(802, 177);
            this.lstNews.TabIndex = 13;
            this.lstNews.Text = "";
            // 
            // btnNews
            // 
            this.btnNews.Location = new System.Drawing.Point(770, 7);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(55, 23);
            this.btnNews.TabIndex = 12;
            this.btnNews.Text = "Buscar";
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // tabHighlights
            // 
            this.tabHighlights.Controls.Add(this.label5);
            this.tabHighlights.Controls.Add(this.txtHighLightsDateTo);
            this.tabHighlights.Controls.Add(this.label6);
            this.tabHighlights.Controls.Add(this.txtHighLightsDateFrom);
            this.tabHighlights.Controls.Add(this.chkHighlightsSign);
            this.tabHighlights.Controls.Add(this.btnBuscarHighlights);
            this.tabHighlights.Controls.Add(this.label4);
            this.tabHighlights.Controls.Add(this.txtBrokerHighlight);
            this.tabHighlights.Controls.Add(this.lblMaxResult);
            this.tabHighlights.Controls.Add(this.txtMaxResultHighlight);
            this.tabHighlights.Controls.Add(this.cboMarketHighlight);
            this.tabHighlights.Controls.Add(this.lblMarketHighlight);
            this.tabHighlights.Controls.Add(this.cboTipoRelatorioHighlight);
            this.tabHighlights.Controls.Add(this.lblTipoRelatorio);
            this.tabHighlights.Controls.Add(this.label2);
            this.tabHighlights.Controls.Add(this.txtSourceHighlight);
            this.tabHighlights.Controls.Add(this.label3);
            this.tabHighlights.Controls.Add(this.txtSymbolHighlight);
            this.tabHighlights.Controls.Add(this.gridHighlights);
            this.tabHighlights.Controls.Add(this.lstHighlight);
            this.tabHighlights.Location = new System.Drawing.Point(4, 22);
            this.tabHighlights.Name = "tabHighlights";
            this.tabHighlights.Padding = new System.Windows.Forms.Padding(3);
            this.tabHighlights.Size = new System.Drawing.Size(825, 545);
            this.tabHighlights.TabIndex = 16;
            this.tabHighlights.Text = "Highlights";
            this.tabHighlights.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "DateTo";
            // 
            // txtHighLightsDateTo
            // 
            this.txtHighLightsDateTo.Location = new System.Drawing.Point(532, 36);
            this.txtHighLightsDateTo.Name = "txtHighLightsDateTo";
            this.txtHighLightsDateTo.Size = new System.Drawing.Size(60, 20);
            this.txtHighLightsDateTo.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "DateFrom";
            // 
            // txtHighLightsDateFrom
            // 
            this.txtHighLightsDateFrom.Location = new System.Drawing.Point(419, 37);
            this.txtHighLightsDateFrom.Name = "txtHighLightsDateFrom";
            this.txtHighLightsDateFrom.Size = new System.Drawing.Size(60, 20);
            this.txtHighLightsDateFrom.TabIndex = 53;
            // 
            // chkHighlightsSign
            // 
            this.chkHighlightsSign.AutoSize = true;
            this.chkHighlightsSign.Location = new System.Drawing.Point(608, 39);
            this.chkHighlightsSign.Name = "chkHighlightsSign";
            this.chkHighlightsSign.Size = new System.Drawing.Size(60, 17);
            this.chkHighlightsSign.TabIndex = 51;
            this.chkHighlightsSign.Text = "Assinar";
            this.chkHighlightsSign.UseVisualStyleBackColor = true;
            // 
            // btnBuscarHighlights
            // 
            this.btnBuscarHighlights.Location = new System.Drawing.Point(701, 19);
            this.btnBuscarHighlights.Name = "btnBuscarHighlights";
            this.btnBuscarHighlights.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarHighlights.TabIndex = 50;
            this.btnBuscarHighlights.Text = "Buscar";
            this.btnBuscarHighlights.UseVisualStyleBackColor = true;
            this.btnBuscarHighlights.Click += new System.EventHandler(this.btnBuscarHighlights_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Código da Corretora";
            // 
            // txtBrokerHighlight
            // 
            this.txtBrokerHighlight.Location = new System.Drawing.Point(277, 37);
            this.txtBrokerHighlight.Name = "txtBrokerHighlight";
            this.txtBrokerHighlight.Size = new System.Drawing.Size(72, 20);
            this.txtBrokerHighlight.TabIndex = 49;
            // 
            // lblMaxResult
            // 
            this.lblMaxResult.AutoSize = true;
            this.lblMaxResult.Location = new System.Drawing.Point(15, 44);
            this.lblMaxResult.Name = "lblMaxResult";
            this.lblMaxResult.Size = new System.Drawing.Size(63, 13);
            this.lblMaxResult.TabIndex = 46;
            this.lblMaxResult.Text = "Max Result.";
            // 
            // txtMaxResultHighlight
            // 
            this.txtMaxResultHighlight.Location = new System.Drawing.Point(82, 39);
            this.txtMaxResultHighlight.Name = "txtMaxResultHighlight";
            this.txtMaxResultHighlight.Size = new System.Drawing.Size(72, 20);
            this.txtMaxResultHighlight.TabIndex = 47;
            this.txtMaxResultHighlight.Text = "10";
            this.txtMaxResultHighlight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxResultHighlight_KeyPress);
            // 
            // cboMarketHighlight
            // 
            this.cboMarketHighlight.FormattingEnabled = true;
            this.cboMarketHighlight.Location = new System.Drawing.Point(532, 6);
            this.cboMarketHighlight.Name = "cboMarketHighlight";
            this.cboMarketHighlight.Size = new System.Drawing.Size(121, 21);
            this.cboMarketHighlight.TabIndex = 45;
            // 
            // lblMarketHighlight
            // 
            this.lblMarketHighlight.AutoSize = true;
            this.lblMarketHighlight.Location = new System.Drawing.Point(477, 9);
            this.lblMarketHighlight.Name = "lblMarketHighlight";
            this.lblMarketHighlight.Size = new System.Drawing.Size(49, 13);
            this.lblMarketHighlight.TabIndex = 44;
            this.lblMarketHighlight.Text = "Mercado";
            // 
            // cboTipoRelatorioHighlight
            // 
            this.cboTipoRelatorioHighlight.FormattingEnabled = true;
            this.cboTipoRelatorioHighlight.Location = new System.Drawing.Point(339, 6);
            this.cboTipoRelatorioHighlight.Name = "cboTipoRelatorioHighlight";
            this.cboTipoRelatorioHighlight.Size = new System.Drawing.Size(121, 21);
            this.cboTipoRelatorioHighlight.TabIndex = 43;
            // 
            // lblTipoRelatorio
            // 
            this.lblTipoRelatorio.AutoSize = true;
            this.lblTipoRelatorio.Location = new System.Drawing.Point(245, 9);
            this.lblTipoRelatorio.Name = "lblTipoRelatorio";
            this.lblTipoRelatorio.Size = new System.Drawing.Size(88, 13);
            this.lblTipoRelatorio.TabIndex = 42;
            this.lblTipoRelatorio.Text = "Tipo de Relatório";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "SourceID";
            // 
            // txtSourceHighlight
            // 
            this.txtSourceHighlight.Location = new System.Drawing.Point(73, 6);
            this.txtSourceHighlight.Name = "txtSourceHighlight";
            this.txtSourceHighlight.Size = new System.Drawing.Size(24, 20);
            this.txtSourceHighlight.TabIndex = 38;
            this.txtSourceHighlight.Text = "12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Symbol";
            // 
            // txtSymbolHighlight
            // 
            this.txtSymbolHighlight.Location = new System.Drawing.Point(156, 6);
            this.txtSymbolHighlight.Name = "txtSymbolHighlight";
            this.txtSymbolHighlight.Size = new System.Drawing.Size(72, 20);
            this.txtSymbolHighlight.TabIndex = 40;
            this.txtSymbolHighlight.Text = "PETR4";
            // 
            // gridHighlights
            // 
            this.gridHighlights.AllowUserToAddRows = false;
            this.gridHighlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHighlights.Location = new System.Drawing.Point(22, 71);
            this.gridHighlights.Name = "gridHighlights";
            this.gridHighlights.RowHeadersVisible = false;
            this.gridHighlights.RowHeadersWidth = 62;
            this.gridHighlights.Size = new System.Drawing.Size(787, 292);
            this.gridHighlights.TabIndex = 36;
            // 
            // lstHighlight
            // 
            this.lstHighlight.Location = new System.Drawing.Point(22, 369);
            this.lstHighlight.Name = "lstHighlight";
            this.lstHighlight.ReadOnly = true;
            this.lstHighlight.Size = new System.Drawing.Size(784, 159);
            this.lstHighlight.TabIndex = 35;
            this.lstHighlight.Text = "";
            // 
            // tabProvider
            // 
            this.tabProvider.Controls.Add(this.lblProviderTableFilePath);
            this.tabProvider.Controls.Add(this.lblProviderColumnsFile);
            this.tabProvider.Controls.Add(this.lblUsedTemplate);
            this.tabProvider.Controls.Add(this.gbProviderConfigurations);
            this.tabProvider.Controls.Add(this.txtUsedTemplate);
            this.tabProvider.Controls.Add(this.txtSQLCustomFilter);
            this.tabProvider.Controls.Add(this.chkSQLCustomFilter);
            this.tabProvider.Controls.Add(this.lblProviderTemplateColumnFilterValue);
            this.tabProvider.Controls.Add(this.txtProviderTemplateColumnFilter);
            this.tabProvider.Controls.Add(this.lblProviderTemplateColumnFilter);
            this.tabProvider.Controls.Add(this.txtProviderTemplateTable);
            this.tabProvider.Controls.Add(this.lblProviderTemplateTable);
            this.tabProvider.Controls.Add(this.txtProviderQuotesTable);
            this.tabProvider.Controls.Add(this.lblProviderQuotesTable);
            this.tabProvider.Controls.Add(this.txtProviderQuotesColumns);
            this.tabProvider.Controls.Add(this.lblProviderColumnsFileLabel);
            this.tabProvider.Controls.Add(this.btnSelectFileColumns);
            this.tabProvider.Controls.Add(this.lblProviderTableFilePathLabel);
            this.tabProvider.Controls.Add(this.btnSelectFileTable);
            this.tabProvider.Controls.Add(this.rbSpaceDelimitedFile);
            this.tabProvider.Controls.Add(this.rbDatabase);
            this.tabProvider.Controls.Add(this.label20);
            this.tabProvider.Controls.Add(this.rbQuotesTemplate);
            this.tabProvider.Controls.Add(this.lblProvider);
            this.tabProvider.Controls.Add(this.cboProvider);
            this.tabProvider.Controls.Add(this.txtProviderStatus);
            this.tabProvider.Controls.Add(this.btnStopProvider);
            this.tabProvider.Controls.Add(this.btnStartProvider);
            this.tabProvider.Controls.Add(this.lblQuotesTemplate);
            this.tabProvider.Controls.Add(this.lblSymbolProvider);
            this.tabProvider.Controls.Add(this.txtSourceSymbolProvider);
            this.tabProvider.Controls.Add(this.lblConnectionStringProvider);
            this.tabProvider.Controls.Add(this.txtConnectionStringProvider);
            this.tabProvider.Controls.Add(this.txtProviderTemplateColumn);
            this.tabProvider.Controls.Add(this.lblProviderTemplateColumn);
            this.tabProvider.Controls.Add(this.txtProviderTemplateColumnFilterValue);
            this.tabProvider.Controls.Add(this.txtQuotesTemplate);
            this.tabProvider.Location = new System.Drawing.Point(4, 22);
            this.tabProvider.Margin = new System.Windows.Forms.Padding(2);
            this.tabProvider.Name = "tabProvider";
            this.tabProvider.Padding = new System.Windows.Forms.Padding(2);
            this.tabProvider.Size = new System.Drawing.Size(825, 545);
            this.tabProvider.TabIndex = 20;
            this.tabProvider.Text = "Provider-DBFeed";
            this.tabProvider.UseVisualStyleBackColor = true;
            // 
            // lblUsedTemplate
            // 
            this.lblUsedTemplate.AutoSize = true;
            this.lblUsedTemplate.Location = new System.Drawing.Point(305, 104);
            this.lblUsedTemplate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsedTemplate.Name = "lblUsedTemplate";
            this.lblUsedTemplate.Size = new System.Drawing.Size(122, 13);
            this.lblUsedTemplate.TabIndex = 84;
            this.lblUsedTemplate.Text = "Template Fluid Utilizado:";
            this.lblUsedTemplate.Visible = false;
            // 
            // gbProviderConfigurations
            // 
            this.gbProviderConfigurations.Controls.Add(this.lblLabelProviderSymbolsDB);
            this.gbProviderConfigurations.Controls.Add(this.lblProviderSymbolsDB);
            this.gbProviderConfigurations.Controls.Add(this.txtProviderConfigurationSourceId);
            this.gbProviderConfigurations.Controls.Add(this.lblProviderConfigurationSourceId);
            this.gbProviderConfigurations.Controls.Add(this.txtProviderConfigurationColumns);
            this.gbProviderConfigurations.Controls.Add(this.lblProviderConfigurationColumns);
            this.gbProviderConfigurations.Location = new System.Drawing.Point(304, 97);
            this.gbProviderConfigurations.Margin = new System.Windows.Forms.Padding(2);
            this.gbProviderConfigurations.Name = "gbProviderConfigurations";
            this.gbProviderConfigurations.Padding = new System.Windows.Forms.Padding(2);
            this.gbProviderConfigurations.Size = new System.Drawing.Size(429, 95);
            this.gbProviderConfigurations.TabIndex = 83;
            this.gbProviderConfigurations.TabStop = false;
            this.gbProviderConfigurations.Text = "Configurações";
            this.gbProviderConfigurations.Visible = false;
            // 
            // lblProviderSymbolsDB
            // 
            this.lblProviderSymbolsDB.AutoSize = true;
            this.lblProviderSymbolsDB.Location = new System.Drawing.Point(137, 83);
            this.lblProviderSymbolsDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderSymbolsDB.MaximumSize = new System.Drawing.Size(0, 325);
            this.lblProviderSymbolsDB.Name = "lblProviderSymbolsDB";
            this.lblProviderSymbolsDB.Size = new System.Drawing.Size(0, 13);
            this.lblProviderSymbolsDB.TabIndex = 84;
            this.lblProviderSymbolsDB.Visible = false;
            // 
            // lblLabelProviderSymbolsDB
            // 
            this.lblLabelProviderSymbolsDB.Location = new System.Drawing.Point(9, 76);
            this.lblLabelProviderSymbolsDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabelProviderSymbolsDB.Name = "lblLabelProviderSymbolsDB";
            this.lblLabelProviderSymbolsDB.Size = new System.Drawing.Size(394, 13);
            this.lblLabelProviderSymbolsDB.TabIndex = 83;
            this.lblLabelProviderSymbolsDB.Text = "Ativos habilitados na BD: -";
            this.lblLabelProviderSymbolsDB.Visible = false;
            // 
            // txtProviderConfigurationSourceId
            // 
            this.txtProviderConfigurationSourceId.Location = new System.Drawing.Point(317, 52);
            this.txtProviderConfigurationSourceId.Margin = new System.Windows.Forms.Padding(2);
            this.txtProviderConfigurationSourceId.Name = "txtProviderConfigurationSourceId";
            this.txtProviderConfigurationSourceId.Size = new System.Drawing.Size(24, 20);
            this.txtProviderConfigurationSourceId.TabIndex = 82;
            this.txtProviderConfigurationSourceId.Text = "12";
            this.txtProviderConfigurationSourceId.Visible = false;
            // 
            // lblProviderConfigurationSourceId
            // 
            this.lblProviderConfigurationSourceId.AutoSize = true;
            this.lblProviderConfigurationSourceId.Location = new System.Drawing.Point(9, 55);
            this.lblProviderConfigurationSourceId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderConfigurationSourceId.Name = "lblProviderConfigurationSourceId";
            this.lblProviderConfigurationSourceId.Size = new System.Drawing.Size(307, 13);
            this.lblProviderConfigurationSourceId.TabIndex = 81;
            this.lblProviderConfigurationSourceId.Text = "SourceId (fixo para todos os códigos vindos da base de dados):";
            this.lblProviderConfigurationSourceId.Visible = false;
            // 
            // txtProviderConfigurationColumns
            // 
            this.txtProviderConfigurationColumns.Location = new System.Drawing.Point(131, 27);
            this.txtProviderConfigurationColumns.Margin = new System.Windows.Forms.Padding(2);
            this.txtProviderConfigurationColumns.Name = "txtProviderConfigurationColumns";
            this.txtProviderConfigurationColumns.Size = new System.Drawing.Size(275, 20);
            this.txtProviderConfigurationColumns.TabIndex = 80;
            this.txtProviderConfigurationColumns.Text = "COD_COL:ATV_CODIGO;FLG_COL:ATV_FLG_ATIVO;DTM_COL:ATV_DAT_DATAHORA;";
            this.txtProviderConfigurationColumns.Visible = false;
            // 
            // lblProviderConfigurationColumns
            // 
            this.lblProviderConfigurationColumns.AutoSize = true;
            this.lblProviderConfigurationColumns.Location = new System.Drawing.Point(9, 29);
            this.lblProviderConfigurationColumns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderConfigurationColumns.Name = "lblProviderConfigurationColumns";
            this.lblProviderConfigurationColumns.Size = new System.Drawing.Size(120, 13);
            this.lblProviderConfigurationColumns.TabIndex = 79;
            this.lblProviderConfigurationColumns.Text = "Colunas (Configuração):";
            this.lblProviderConfigurationColumns.Visible = false;
            // 
            // txtUsedTemplate
            // 
            this.txtUsedTemplate.Enabled = false;
            this.txtUsedTemplate.Location = new System.Drawing.Point(313, 122);
            this.txtUsedTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsedTemplate.Multiline = true;
            this.txtUsedTemplate.Name = "txtUsedTemplate";
            this.txtUsedTemplate.ReadOnly = true;
            this.txtUsedTemplate.Size = new System.Drawing.Size(401, 81);
            this.txtUsedTemplate.TabIndex = 75;
            this.txtUsedTemplate.Visible = false;
            // 
            // txtSQLCustomFilter
            // 
            this.txtSQLCustomFilter.Enabled = false;
            this.txtSQLCustomFilter.Location = new System.Drawing.Point(158, 211);
            this.txtSQLCustomFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtSQLCustomFilter.Multiline = true;
            this.txtSQLCustomFilter.Name = "txtSQLCustomFilter";
            this.txtSQLCustomFilter.Size = new System.Drawing.Size(559, 35);
            this.txtSQLCustomFilter.TabIndex = 74;
            this.txtSQLCustomFilter.Visible = false;
            // 
            // chkSQLCustomFilter
            // 
            this.chkSQLCustomFilter.AutoSize = true;
            this.chkSQLCustomFilter.Location = new System.Drawing.Point(19, 213);
            this.chkSQLCustomFilter.Margin = new System.Windows.Forms.Padding(2);
            this.chkSQLCustomFilter.Name = "chkSQLCustomFilter";
            this.chkSQLCustomFilter.Size = new System.Drawing.Size(135, 17);
            this.chkSQLCustomFilter.TabIndex = 73;
            this.chkSQLCustomFilter.Text = "Filtro SQL Customizado";
            this.chkSQLCustomFilter.UseVisualStyleBackColor = true;
            this.chkSQLCustomFilter.Visible = false;
            this.chkSQLCustomFilter.CheckedChanged += new System.EventHandler(this.chkSQLCustomFilter_CheckedChanged);
            // 
            // lblProviderTemplateColumnFilterValue
            // 
            this.lblProviderTemplateColumnFilterValue.AutoSize = true;
            this.lblProviderTemplateColumnFilterValue.Location = new System.Drawing.Point(16, 188);
            this.lblProviderTemplateColumnFilterValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderTemplateColumnFilterValue.Name = "lblProviderTemplateColumnFilterValue";
            this.lblProviderTemplateColumnFilterValue.Size = new System.Drawing.Size(65, 13);
            this.lblProviderTemplateColumnFilterValue.TabIndex = 71;
            this.lblProviderTemplateColumnFilterValue.Text = "Valor (Filtro):";
            this.lblProviderTemplateColumnFilterValue.Visible = false;
            // 
            // txtProviderTemplateColumnFilter
            // 
            this.txtProviderTemplateColumnFilter.Location = new System.Drawing.Point(114, 161);
            this.txtProviderTemplateColumnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtProviderTemplateColumnFilter.Name = "txtProviderTemplateColumnFilter";
            this.txtProviderTemplateColumnFilter.Size = new System.Drawing.Size(159, 20);
            this.txtProviderTemplateColumnFilter.TabIndex = 70;
            this.txtProviderTemplateColumnFilter.Visible = false;
            // 
            // lblProviderTemplateColumnFilter
            // 
            this.lblProviderTemplateColumnFilter.AutoSize = true;
            this.lblProviderTemplateColumnFilter.Location = new System.Drawing.Point(16, 162);
            this.lblProviderTemplateColumnFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderTemplateColumnFilter.Name = "lblProviderTemplateColumnFilter";
            this.lblProviderTemplateColumnFilter.Size = new System.Drawing.Size(74, 13);
            this.lblProviderTemplateColumnFilter.TabIndex = 69;
            this.lblProviderTemplateColumnFilter.Text = "Coluna (Filtro):";
            this.lblProviderTemplateColumnFilter.Visible = false;
            // 
            // txtProviderTemplateTable
            // 
            this.txtProviderTemplateTable.Location = new System.Drawing.Point(114, 106);
            this.txtProviderTemplateTable.Margin = new System.Windows.Forms.Padding(2);
            this.txtProviderTemplateTable.Name = "txtProviderTemplateTable";
            this.txtProviderTemplateTable.Size = new System.Drawing.Size(159, 20);
            this.txtProviderTemplateTable.TabIndex = 66;
            this.txtProviderTemplateTable.Visible = false;
            // 
            // lblProviderTemplateTable
            // 
            this.lblProviderTemplateTable.AutoSize = true;
            this.lblProviderTemplateTable.Location = new System.Drawing.Point(16, 108);
            this.lblProviderTemplateTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderTemplateTable.Name = "lblProviderTemplateTable";
            this.lblProviderTemplateTable.Size = new System.Drawing.Size(96, 13);
            this.lblProviderTemplateTable.TabIndex = 65;
            this.lblProviderTemplateTable.Text = "Tabela (Template):";
            this.lblProviderTemplateTable.Visible = false;
            // 
            // txtProviderQuotesTable
            // 
            this.txtProviderQuotesTable.Location = new System.Drawing.Point(120, 246);
            this.txtProviderQuotesTable.Margin = new System.Windows.Forms.Padding(2);
            this.txtProviderQuotesTable.Name = "txtProviderQuotesTable";
            this.txtProviderQuotesTable.Size = new System.Drawing.Size(159, 20);
            this.txtProviderQuotesTable.TabIndex = 64;
            this.txtProviderQuotesTable.Text = "BCSYS_ATIVO";
            this.txtProviderQuotesTable.Visible = false;
            // 
            // lblProviderQuotesTable
            // 
            this.lblProviderQuotesTable.AutoSize = true;
            this.lblProviderQuotesTable.Location = new System.Drawing.Point(22, 248);
            this.lblProviderQuotesTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderQuotesTable.Name = "lblProviderQuotesTable";
            this.lblProviderQuotesTable.Size = new System.Drawing.Size(92, 13);
            this.lblProviderQuotesTable.TabIndex = 63;
            this.lblProviderQuotesTable.Text = "Tabela (Cotação):";
            this.lblProviderQuotesTable.Visible = false;
            // 
            // txtProviderQuotesColumns
            // 
            this.txtProviderQuotesColumns.Location = new System.Drawing.Point(25, 211);
            this.txtProviderQuotesColumns.Margin = new System.Windows.Forms.Padding(2);
            this.txtProviderQuotesColumns.Name = "txtProviderQuotesColumns";
            this.txtProviderQuotesColumns.Size = new System.Drawing.Size(68, 20);
            this.txtProviderQuotesColumns.TabIndex = 62;
            this.txtProviderQuotesColumns.Visible = false;
            // 
            // lblProviderColumnsFile
            // 
            this.lblProviderColumnsFile.AutoSize = true;
            this.lblProviderColumnsFile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProviderColumnsFile.Location = new System.Drawing.Point(23, 211);
            this.lblProviderColumnsFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderColumnsFile.MaximumSize = new System.Drawing.Size(633, 0);
            this.lblProviderColumnsFile.Name = "lblProviderColumnsFile";
            this.lblProviderColumnsFile.Size = new System.Drawing.Size(13, 13);
            this.lblProviderColumnsFile.TabIndex = 61;
            this.lblProviderColumnsFile.Text = "?";
            this.lblProviderColumnsFile.Visible = false;
            // 
            // lblProviderColumnsFileLabel
            // 
            this.lblProviderColumnsFileLabel.AutoSize = true;
            this.lblProviderColumnsFileLabel.Location = new System.Drawing.Point(22, 196);
            this.lblProviderColumnsFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderColumnsFileLabel.Name = "lblProviderColumnsFileLabel";
            this.lblProviderColumnsFileLabel.Size = new System.Drawing.Size(144, 13);
            this.lblProviderColumnsFileLabel.TabIndex = 60;
            this.lblProviderColumnsFileLabel.Text = "Colunas a serem atualizadas:";
            this.lblProviderColumnsFileLabel.Visible = false;
            // 
            // btnSelectFileColumns
            // 
            this.btnSelectFileColumns.Location = new System.Drawing.Point(19, 165);
            this.btnSelectFileColumns.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectFileColumns.Name = "btnSelectFileColumns";
            this.btnSelectFileColumns.Size = new System.Drawing.Size(173, 21);
            this.btnSelectFileColumns.TabIndex = 59;
            this.btnSelectFileColumns.Text = "Selecione o arquivo columns.txt";
            this.btnSelectFileColumns.UseVisualStyleBackColor = true;
            this.btnSelectFileColumns.Visible = false;
            this.btnSelectFileColumns.Click += new System.EventHandler(this.btnSelectFileColumns_Click);
            // 
            // lblProviderTableFilePathLabel
            // 
            this.lblProviderTableFilePathLabel.AutoSize = true;
            this.lblProviderTableFilePathLabel.Location = new System.Drawing.Point(22, 130);
            this.lblProviderTableFilePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderTableFilePathLabel.Name = "lblProviderTableFilePathLabel";
            this.lblProviderTableFilePathLabel.Size = new System.Drawing.Size(184, 13);
            this.lblProviderTableFilePathLabel.TabIndex = 58;
            this.lblProviderTableFilePathLabel.Text = "Ativos selecionados (Source,Symbol):";
            this.lblProviderTableFilePathLabel.Visible = false;
            // 
            // lblProviderTableFilePath
            // 
            this.lblProviderTableFilePath.AutoSize = true;
            this.lblProviderTableFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblProviderTableFilePath.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProviderTableFilePath.Location = new System.Drawing.Point(22, 144);
            this.lblProviderTableFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderTableFilePath.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblProviderTableFilePath.Name = "lblProviderTableFilePath";
            this.lblProviderTableFilePath.Size = new System.Drawing.Size(13, 13);
            this.lblProviderTableFilePath.TabIndex = 57;
            this.lblProviderTableFilePath.Text = "?";
            this.lblProviderTableFilePath.Visible = false;
            // 
            // btnSelectFileTable
            // 
            this.btnSelectFileTable.Location = new System.Drawing.Point(19, 99);
            this.btnSelectFileTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectFileTable.Name = "btnSelectFileTable";
            this.btnSelectFileTable.Size = new System.Drawing.Size(173, 21);
            this.btnSelectFileTable.TabIndex = 11;
            this.btnSelectFileTable.Text = "Selecione o arquivo table.txt";
            this.btnSelectFileTable.UseVisualStyleBackColor = true;
            this.btnSelectFileTable.Visible = false;
            this.btnSelectFileTable.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // rbSpaceDelimitedFile
            // 
            this.rbSpaceDelimitedFile.AutoSize = true;
            this.rbSpaceDelimitedFile.Location = new System.Drawing.Point(229, 67);
            this.rbSpaceDelimitedFile.Margin = new System.Windows.Forms.Padding(2);
            this.rbSpaceDelimitedFile.Name = "rbSpaceDelimitedFile";
            this.rbSpaceDelimitedFile.Size = new System.Drawing.Size(135, 17);
            this.rbSpaceDelimitedFile.TabIndex = 56;
            this.rbSpaceDelimitedFile.TabStop = true;
            this.rbSpaceDelimitedFile.Text = "Delimited  File (BDSQL)";
            this.rbSpaceDelimitedFile.UseVisualStyleBackColor = true;
            this.rbSpaceDelimitedFile.CheckedChanged += new System.EventHandler(this.rbSpaceDelimitedFile_CheckedChanged);
            // 
            // rbDatabase
            // 
            this.rbDatabase.AutoSize = true;
            this.rbDatabase.Location = new System.Drawing.Point(383, 67);
            this.rbDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.rbDatabase.Name = "rbDatabase";
            this.rbDatabase.Size = new System.Drawing.Size(71, 17);
            this.rbDatabase.TabIndex = 55;
            this.rbDatabase.TabStop = true;
            this.rbDatabase.Text = "Database";
            this.rbDatabase.UseVisualStyleBackColor = true;
            this.rbDatabase.CheckedChanged += new System.EventHandler(this.rbDatabase_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 68);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "Get Template by:";
            // 
            // rbQuotesTemplate
            // 
            this.rbQuotesTemplate.AutoSize = true;
            this.rbQuotesTemplate.Location = new System.Drawing.Point(120, 67);
            this.rbQuotesTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.rbQuotesTemplate.Name = "rbQuotesTemplate";
            this.rbQuotesTemplate.Size = new System.Drawing.Size(103, 17);
            this.rbQuotesTemplate.TabIndex = 53;
            this.rbQuotesTemplate.TabStop = true;
            this.rbQuotesTemplate.Text = "QuotesTemplate";
            this.rbQuotesTemplate.UseVisualStyleBackColor = true;
            this.rbQuotesTemplate.CheckedChanged += new System.EventHandler(this.rbQuotesTemplate_CheckedChanged);
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(579, 22);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(46, 13);
            this.lblProvider.TabIndex = 52;
            this.lblProvider.Text = "Provider";
            // 
            // cboProvider
            // 
            this.cboProvider.FormattingEnabled = true;
            this.cboProvider.Location = new System.Drawing.Point(582, 37);
            this.cboProvider.Margin = new System.Windows.Forms.Padding(2);
            this.cboProvider.Name = "cboProvider";
            this.cboProvider.Size = new System.Drawing.Size(95, 21);
            this.cboProvider.TabIndex = 51;
            // 
            // txtProviderStatus
            // 
            this.txtProviderStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.txtProviderStatus.Location = new System.Drawing.Point(19, 285);
            this.txtProviderStatus.Name = "txtProviderStatus";
            this.txtProviderStatus.Size = new System.Drawing.Size(796, 241);
            this.txtProviderStatus.TabIndex = 50;
            this.txtProviderStatus.Text = "";
            // 
            // btnStopProvider
            // 
            this.btnStopProvider.BackColor = System.Drawing.Color.Red;
            this.btnStopProvider.Enabled = false;
            this.btnStopProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopProvider.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStopProvider.Location = new System.Drawing.Point(685, 60);
            this.btnStopProvider.Name = "btnStopProvider";
            this.btnStopProvider.Size = new System.Drawing.Size(129, 31);
            this.btnStopProvider.TabIndex = 49;
            this.btnStopProvider.Text = "Parar Provider";
            this.btnStopProvider.UseVisualStyleBackColor = false;
            this.btnStopProvider.Click += new System.EventHandler(this.btnStopProvider_Click);
            // 
            // btnStartProvider
            // 
            this.btnStartProvider.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStartProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartProvider.Location = new System.Drawing.Point(685, 13);
            this.btnStartProvider.Name = "btnStartProvider";
            this.btnStartProvider.Size = new System.Drawing.Size(129, 41);
            this.btnStartProvider.TabIndex = 48;
            this.btnStartProvider.Text = "Iniciar Provider";
            this.btnStartProvider.UseVisualStyleBackColor = false;
            this.btnStartProvider.Click += new System.EventHandler(this.btnStartProvider_Click);
            // 
            // lblQuotesTemplate
            // 
            this.lblQuotesTemplate.AutoSize = true;
            this.lblQuotesTemplate.Location = new System.Drawing.Point(16, 91);
            this.lblQuotesTemplate.Name = "lblQuotesTemplate";
            this.lblQuotesTemplate.Size = new System.Drawing.Size(116, 13);
            this.lblQuotesTemplate.TabIndex = 12;
            this.lblQuotesTemplate.Text = "QuotesTemplate (Fluid)";
            // 
            // lblSymbolProvider
            // 
            this.lblSymbolProvider.AutoSize = true;
            this.lblSymbolProvider.Location = new System.Drawing.Point(390, 22);
            this.lblSymbolProvider.Name = "lblSymbolProvider";
            this.lblSymbolProvider.Size = new System.Drawing.Size(97, 13);
            this.lblSymbolProvider.TabIndex = 10;
            this.lblSymbolProvider.Text = "SourceId|SymbolID";
            // 
            // txtSourceSymbolProvider
            // 
            this.txtSourceSymbolProvider.Location = new System.Drawing.Point(393, 37);
            this.txtSourceSymbolProvider.Name = "txtSourceSymbolProvider";
            this.txtSourceSymbolProvider.Size = new System.Drawing.Size(173, 20);
            this.txtSourceSymbolProvider.TabIndex = 11;
            this.txtSourceSymbolProvider.Text = "12|PETR4,12|MGLU3";
            // 
            // lblConnectionStringProvider
            // 
            this.lblConnectionStringProvider.AutoSize = true;
            this.lblConnectionStringProvider.Location = new System.Drawing.Point(16, 22);
            this.lblConnectionStringProvider.Name = "lblConnectionStringProvider";
            this.lblConnectionStringProvider.Size = new System.Drawing.Size(91, 13);
            this.lblConnectionStringProvider.TabIndex = 6;
            this.lblConnectionStringProvider.Text = "Connection String";
            // 
            // txtConnectionStringProvider
            // 
            this.txtConnectionStringProvider.Location = new System.Drawing.Point(19, 37);
            this.txtConnectionStringProvider.Name = "txtConnectionStringProvider";
            this.txtConnectionStringProvider.Size = new System.Drawing.Size(345, 20);
            this.txtConnectionStringProvider.TabIndex = 7;
            this.txtConnectionStringProvider.Text = "Server=127.0.0.1;Port=3306;Database=bdsql;Uid=root;Pwd=cma123;SslMode=none;";
            // 
            // txtProviderTemplateColumn
            // 
            this.txtProviderTemplateColumn.Location = new System.Drawing.Point(114, 135);
            this.txtProviderTemplateColumn.Margin = new System.Windows.Forms.Padding(2);
            this.txtProviderTemplateColumn.Name = "txtProviderTemplateColumn";
            this.txtProviderTemplateColumn.Size = new System.Drawing.Size(159, 20);
            this.txtProviderTemplateColumn.TabIndex = 68;
            this.txtProviderTemplateColumn.Visible = false;
            // 
            // lblProviderTemplateColumn
            // 
            this.lblProviderTemplateColumn.AutoSize = true;
            this.lblProviderTemplateColumn.Location = new System.Drawing.Point(16, 136);
            this.lblProviderTemplateColumn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProviderTemplateColumn.Name = "lblProviderTemplateColumn";
            this.lblProviderTemplateColumn.Size = new System.Drawing.Size(96, 13);
            this.lblProviderTemplateColumn.TabIndex = 67;
            this.lblProviderTemplateColumn.Text = "Coluna (Template):";
            this.lblProviderTemplateColumn.Visible = false;
            // 
            // txtQuotesTemplate
            // 
            this.txtQuotesTemplate.Location = new System.Drawing.Point(19, 106);
            this.txtQuotesTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuotesTemplate.Multiline = true;
            this.txtQuotesTemplate.Name = "txtQuotesTemplate";
            this.txtQuotesTemplate.Size = new System.Drawing.Size(795, 150);
            this.txtQuotesTemplate.TabIndex = 13;
            // 
            // txtProviderTemplateColumnFilterValue
            // 
            this.txtProviderTemplateColumnFilterValue.Location = new System.Drawing.Point(114, 187);
            this.txtProviderTemplateColumnFilterValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtProviderTemplateColumnFilterValue.Name = "txtProviderTemplateColumnFilterValue";
            this.txtProviderTemplateColumnFilterValue.Size = new System.Drawing.Size(159, 20);
            this.txtProviderTemplateColumnFilterValue.TabIndex = 72;
            this.txtProviderTemplateColumnFilterValue.Visible = false;
            // 
            // tabClientList
            // 
            this.tabClientList.Controls.Add(this.cboClientFilterType);
            this.tabClientList.Controls.Add(this.lblClientAssessorId);
            this.tabClientList.Controls.Add(this.txtClientAssessorId);
            this.tabClientList.Controls.Add(this.txtClientFilterData);
            this.tabClientList.Controls.Add(this.lblClientFilterData);
            this.tabClientList.Controls.Add(this.lblClientFilterType);
            this.tabClientList.Controls.Add(this.lblClientBranchId);
            this.tabClientList.Controls.Add(this.lstClient);
            this.tabClientList.Controls.Add(this.txtClientBranchId);
            this.tabClientList.Controls.Add(this.btnClientList);
            this.tabClientList.Location = new System.Drawing.Point(4, 22);
            this.tabClientList.Name = "tabClientList";
            this.tabClientList.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientList.Size = new System.Drawing.Size(825, 545);
            this.tabClientList.TabIndex = 2;
            this.tabClientList.Text = "ClientList";
            this.tabClientList.UseVisualStyleBackColor = true;
            // 
            // cboClientFilterType
            // 
            this.cboClientFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientFilterType.FormattingEnabled = true;
            this.cboClientFilterType.Items.AddRange(new object[] {
            "C",
            "D",
            "I"});
            this.cboClientFilterType.Location = new System.Drawing.Point(283, 11);
            this.cboClientFilterType.Name = "cboClientFilterType";
            this.cboClientFilterType.Size = new System.Drawing.Size(35, 21);
            this.cboClientFilterType.TabIndex = 5;
            // 
            // lblClientAssessorId
            // 
            this.lblClientAssessorId.AutoSize = true;
            this.lblClientAssessorId.Location = new System.Drawing.Point(20, 15);
            this.lblClientAssessorId.Name = "lblClientAssessorId";
            this.lblClientAssessorId.Size = new System.Drawing.Size(58, 13);
            this.lblClientAssessorId.TabIndex = 0;
            this.lblClientAssessorId.Text = "AssessorId";
            // 
            // txtClientAssessorId
            // 
            this.txtClientAssessorId.Location = new System.Drawing.Point(79, 11);
            this.txtClientAssessorId.Name = "txtClientAssessorId";
            this.txtClientAssessorId.Size = new System.Drawing.Size(36, 20);
            this.txtClientAssessorId.TabIndex = 1;
            // 
            // txtClientFilterData
            // 
            this.txtClientFilterData.Location = new System.Drawing.Point(383, 11);
            this.txtClientFilterData.Name = "txtClientFilterData";
            this.txtClientFilterData.Size = new System.Drawing.Size(168, 20);
            this.txtClientFilterData.TabIndex = 7;
            this.txtClientFilterData.Text = "123456789";
            // 
            // lblClientFilterData
            // 
            this.lblClientFilterData.AutoSize = true;
            this.lblClientFilterData.Location = new System.Drawing.Point(325, 15);
            this.lblClientFilterData.Name = "lblClientFilterData";
            this.lblClientFilterData.Size = new System.Drawing.Size(52, 13);
            this.lblClientFilterData.TabIndex = 6;
            this.lblClientFilterData.Text = "FilterData";
            // 
            // lblClientFilterType
            // 
            this.lblClientFilterType.AutoSize = true;
            this.lblClientFilterType.Location = new System.Drawing.Point(228, 15);
            this.lblClientFilterType.Name = "lblClientFilterType";
            this.lblClientFilterType.Size = new System.Drawing.Size(53, 13);
            this.lblClientFilterType.TabIndex = 4;
            this.lblClientFilterType.Text = "FilterType";
            // 
            // lblClientBranchId
            // 
            this.lblClientBranchId.AutoSize = true;
            this.lblClientBranchId.Location = new System.Drawing.Point(126, 15);
            this.lblClientBranchId.Name = "lblClientBranchId";
            this.lblClientBranchId.Size = new System.Drawing.Size(50, 13);
            this.lblClientBranchId.TabIndex = 2;
            this.lblClientBranchId.Text = "BranchId";
            // 
            // lstClient
            // 
            this.lstClient.Location = new System.Drawing.Point(17, 37);
            this.lstClient.Name = "lstClient";
            this.lstClient.ReadOnly = true;
            this.lstClient.Size = new System.Drawing.Size(789, 492);
            this.lstClient.TabIndex = 9;
            this.lstClient.Text = "";
            // 
            // txtClientBranchId
            // 
            this.txtClientBranchId.Location = new System.Drawing.Point(176, 11);
            this.txtClientBranchId.Name = "txtClientBranchId";
            this.txtClientBranchId.Size = new System.Drawing.Size(43, 20);
            this.txtClientBranchId.TabIndex = 3;
            // 
            // btnClientList
            // 
            this.btnClientList.Location = new System.Drawing.Point(731, 10);
            this.btnClientList.Name = "btnClientList";
            this.btnClientList.Size = new System.Drawing.Size(75, 23);
            this.btnClientList.TabIndex = 8;
            this.btnClientList.Text = "Buscar";
            this.btnClientList.UseVisualStyleBackColor = true;
            this.btnClientList.Click += new System.EventHandler(this.btnClientList_Click);
            // 
            // tabOrderNew
            // 
            this.tabOrderNew.Controls.Add(this.lblOrderNewTradeChannel);
            this.tabOrderNew.Controls.Add(this.txtOrderNewTradeChannel);
            this.tabOrderNew.Controls.Add(this.cboOrderNewMarketId);
            this.tabOrderNew.Controls.Add(this.lblOrderNewMarketId);
            this.tabOrderNew.Controls.Add(this.lblOrderNewQuotes);
            this.tabOrderNew.Controls.Add(this.txtOrderNewQuotes);
            this.tabOrderNew.Controls.Add(this.lblOrderNewUserMne);
            this.tabOrderNew.Controls.Add(this.txtOrderNewUserMne);
            this.tabOrderNew.Controls.Add(this.cboOrderNewSide);
            this.tabOrderNew.Controls.Add(this.cboOrderNewTypeOffer);
            this.tabOrderNew.Controls.Add(this.lblOrderNewTypeOffer);
            this.tabOrderNew.Controls.Add(this.lblOrderNewPrice);
            this.tabOrderNew.Controls.Add(this.txtOrderNewPrice);
            this.tabOrderNew.Controls.Add(this.lblOrderNewQtty);
            this.tabOrderNew.Controls.Add(this.txtOrderNewQtty);
            this.tabOrderNew.Controls.Add(this.lblOrderNewSide);
            this.tabOrderNew.Controls.Add(this.lblOrderNewUser);
            this.tabOrderNew.Controls.Add(this.txtOrderNewUserId);
            this.tabOrderNew.Controls.Add(this.lblOrderNewSymbol);
            this.tabOrderNew.Controls.Add(this.lstOrderNew);
            this.tabOrderNew.Controls.Add(this.txtOrderNewSymbol);
            this.tabOrderNew.Controls.Add(this.btnOrderNew);
            this.tabOrderNew.Location = new System.Drawing.Point(4, 22);
            this.tabOrderNew.Name = "tabOrderNew";
            this.tabOrderNew.Size = new System.Drawing.Size(825, 545);
            this.tabOrderNew.TabIndex = 3;
            this.tabOrderNew.Text = "OrderNew";
            this.tabOrderNew.UseVisualStyleBackColor = true;
            // 
            // lblOrderNewTradeChannel
            // 
            this.lblOrderNewTradeChannel.AutoSize = true;
            this.lblOrderNewTradeChannel.Location = new System.Drawing.Point(462, 41);
            this.lblOrderNewTradeChannel.Name = "lblOrderNewTradeChannel";
            this.lblOrderNewTradeChannel.Size = new System.Drawing.Size(74, 13);
            this.lblOrderNewTradeChannel.TabIndex = 18;
            this.lblOrderNewTradeChannel.Text = "TradeChannel";
            // 
            // txtOrderNewTradeChannel
            // 
            this.txtOrderNewTradeChannel.Location = new System.Drawing.Point(541, 37);
            this.txtOrderNewTradeChannel.MaxLength = 3;
            this.txtOrderNewTradeChannel.Name = "txtOrderNewTradeChannel";
            this.txtOrderNewTradeChannel.Size = new System.Drawing.Size(38, 20);
            this.txtOrderNewTradeChannel.TabIndex = 19;
            // 
            // cboOrderNewMarketId
            // 
            this.cboOrderNewMarketId.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2"});
            this.cboOrderNewMarketId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderNewMarketId.FormattingEnabled = true;
            this.cboOrderNewMarketId.Items.AddRange(new object[] {
            "9010",
            "9020",
            "9030",
            "9040",
            "9050",
            "12010",
            "12020",
            "12030"});
            this.cboOrderNewMarketId.Location = new System.Drawing.Point(289, 10);
            this.cboOrderNewMarketId.Name = "cboOrderNewMarketId";
            this.cboOrderNewMarketId.Size = new System.Drawing.Size(60, 21);
            this.cboOrderNewMarketId.TabIndex = 5;
            // 
            // lblOrderNewMarketId
            // 
            this.lblOrderNewMarketId.AutoSize = true;
            this.lblOrderNewMarketId.Location = new System.Drawing.Point(223, 14);
            this.lblOrderNewMarketId.Name = "lblOrderNewMarketId";
            this.lblOrderNewMarketId.Size = new System.Drawing.Size(64, 13);
            this.lblOrderNewMarketId.TabIndex = 4;
            this.lblOrderNewMarketId.Text = "TypeMarket";
            // 
            // lblOrderNewQuotes
            // 
            this.lblOrderNewQuotes.AutoSize = true;
            this.lblOrderNewQuotes.Location = new System.Drawing.Point(341, 40);
            this.lblOrderNewQuotes.Name = "lblOrderNewQuotes";
            this.lblOrderNewQuotes.Size = new System.Drawing.Size(47, 13);
            this.lblOrderNewQuotes.TabIndex = 16;
            this.lblOrderNewQuotes.Text = "Cotação";
            // 
            // txtOrderNewQuotes
            // 
            this.txtOrderNewQuotes.Location = new System.Drawing.Point(393, 36);
            this.txtOrderNewQuotes.Name = "txtOrderNewQuotes";
            this.txtOrderNewQuotes.Size = new System.Drawing.Size(46, 20);
            this.txtOrderNewQuotes.TabIndex = 17;
            this.txtOrderNewQuotes.Text = "15.45";
            // 
            // lblOrderNewUserMne
            // 
            this.lblOrderNewUserMne.AutoSize = true;
            this.lblOrderNewUserMne.Location = new System.Drawing.Point(103, 14);
            this.lblOrderNewUserMne.Name = "lblOrderNewUserMne";
            this.lblOrderNewUserMne.Size = new System.Drawing.Size(50, 13);
            this.lblOrderNewUserMne.TabIndex = 2;
            this.lblOrderNewUserMne.Text = "UserMne";
            // 
            // txtOrderNewUserMne
            // 
            this.txtOrderNewUserMne.Location = new System.Drawing.Point(156, 10);
            this.txtOrderNewUserMne.Name = "txtOrderNewUserMne";
            this.txtOrderNewUserMne.Size = new System.Drawing.Size(62, 20);
            this.txtOrderNewUserMne.TabIndex = 3;
            this.txtOrderNewUserMne.Text = "00001";
            // 
            // cboOrderNewSide
            // 
            this.cboOrderNewSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderNewSide.FormattingEnabled = true;
            this.cboOrderNewSide.Items.AddRange(new object[] {
            "B",
            "S"});
            this.cboOrderNewSide.Location = new System.Drawing.Point(491, 11);
            this.cboOrderNewSide.Name = "cboOrderNewSide";
            this.cboOrderNewSide.Size = new System.Drawing.Size(39, 21);
            this.cboOrderNewSide.TabIndex = 9;
            // 
            // cboOrderNewTypeOffer
            // 
            this.cboOrderNewTypeOffer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderNewTypeOffer.FormattingEnabled = true;
            this.cboOrderNewTypeOffer.Items.AddRange(new object[] {
            "Limit",
            "Market"});
            this.cboOrderNewTypeOffer.Location = new System.Drawing.Point(154, 36);
            this.cboOrderNewTypeOffer.Name = "cboOrderNewTypeOffer";
            this.cboOrderNewTypeOffer.Size = new System.Drawing.Size(83, 21);
            this.cboOrderNewTypeOffer.TabIndex = 13;
            this.cboOrderNewTypeOffer.SelectedIndexChanged += new System.EventHandler(this.cboOrderNewTypeOffer_SelectedIndexChanged);
            // 
            // lblOrderNewTypeOffer
            // 
            this.lblOrderNewTypeOffer.AutoSize = true;
            this.lblOrderNewTypeOffer.Location = new System.Drawing.Point(97, 40);
            this.lblOrderNewTypeOffer.Name = "lblOrderNewTypeOffer";
            this.lblOrderNewTypeOffer.Size = new System.Drawing.Size(54, 13);
            this.lblOrderNewTypeOffer.TabIndex = 12;
            this.lblOrderNewTypeOffer.Text = "TypeOffer";
            // 
            // lblOrderNewPrice
            // 
            this.lblOrderNewPrice.AutoSize = true;
            this.lblOrderNewPrice.Location = new System.Drawing.Point(243, 40);
            this.lblOrderNewPrice.Name = "lblOrderNewPrice";
            this.lblOrderNewPrice.Size = new System.Drawing.Size(31, 13);
            this.lblOrderNewPrice.TabIndex = 14;
            this.lblOrderNewPrice.Text = "Price";
            // 
            // txtOrderNewPrice
            // 
            this.txtOrderNewPrice.Location = new System.Drawing.Point(278, 36);
            this.txtOrderNewPrice.Name = "txtOrderNewPrice";
            this.txtOrderNewPrice.Size = new System.Drawing.Size(46, 20);
            this.txtOrderNewPrice.TabIndex = 15;
            this.txtOrderNewPrice.Text = "15.45";
            // 
            // lblOrderNewQtty
            // 
            this.lblOrderNewQtty.AutoSize = true;
            this.lblOrderNewQtty.Location = new System.Drawing.Point(17, 40);
            this.lblOrderNewQtty.Name = "lblOrderNewQtty";
            this.lblOrderNewQtty.Size = new System.Drawing.Size(26, 13);
            this.lblOrderNewQtty.TabIndex = 10;
            this.lblOrderNewQtty.Text = "Qtty";
            // 
            // txtOrderNewQtty
            // 
            this.txtOrderNewQtty.Location = new System.Drawing.Point(45, 36);
            this.txtOrderNewQtty.Name = "txtOrderNewQtty";
            this.txtOrderNewQtty.Size = new System.Drawing.Size(52, 20);
            this.txtOrderNewQtty.TabIndex = 11;
            this.txtOrderNewQtty.Text = "100";
            // 
            // lblOrderNewSide
            // 
            this.lblOrderNewSide.AutoSize = true;
            this.lblOrderNewSide.Location = new System.Drawing.Point(461, 15);
            this.lblOrderNewSide.Name = "lblOrderNewSide";
            this.lblOrderNewSide.Size = new System.Drawing.Size(28, 13);
            this.lblOrderNewSide.TabIndex = 8;
            this.lblOrderNewSide.Text = "Side";
            // 
            // lblOrderNewUser
            // 
            this.lblOrderNewUser.AutoSize = true;
            this.lblOrderNewUser.Location = new System.Drawing.Point(15, 14);
            this.lblOrderNewUser.Name = "lblOrderNewUser";
            this.lblOrderNewUser.Size = new System.Drawing.Size(29, 13);
            this.lblOrderNewUser.TabIndex = 0;
            this.lblOrderNewUser.Text = "User";
            // 
            // txtOrderNewUserId
            // 
            this.txtOrderNewUserId.Location = new System.Drawing.Point(49, 10);
            this.txtOrderNewUserId.Name = "txtOrderNewUserId";
            this.txtOrderNewUserId.Size = new System.Drawing.Size(48, 20);
            this.txtOrderNewUserId.TabIndex = 1;
            this.txtOrderNewUserId.Text = "0";
            // 
            // lblOrderNewSymbol
            // 
            this.lblOrderNewSymbol.AutoSize = true;
            this.lblOrderNewSymbol.Location = new System.Drawing.Point(356, 15);
            this.lblOrderNewSymbol.Name = "lblOrderNewSymbol";
            this.lblOrderNewSymbol.Size = new System.Drawing.Size(41, 13);
            this.lblOrderNewSymbol.TabIndex = 6;
            this.lblOrderNewSymbol.Text = "Symbol";
            // 
            // lstOrderNew
            // 
            this.lstOrderNew.Location = new System.Drawing.Point(18, 63);
            this.lstOrderNew.Name = "lstOrderNew";
            this.lstOrderNew.ReadOnly = true;
            this.lstOrderNew.Size = new System.Drawing.Size(792, 463);
            this.lstOrderNew.TabIndex = 19;
            this.lstOrderNew.Text = "";
            // 
            // txtOrderNewSymbol
            // 
            this.txtOrderNewSymbol.Location = new System.Drawing.Point(399, 11);
            this.txtOrderNewSymbol.Name = "txtOrderNewSymbol";
            this.txtOrderNewSymbol.Size = new System.Drawing.Size(56, 20);
            this.txtOrderNewSymbol.TabIndex = 7;
            this.txtOrderNewSymbol.Text = "PETR4";
            // 
            // btnOrderNew
            // 
            this.btnOrderNew.Location = new System.Drawing.Point(726, 20);
            this.btnOrderNew.Name = "btnOrderNew";
            this.btnOrderNew.Size = new System.Drawing.Size(84, 23);
            this.btnOrderNew.TabIndex = 18;
            this.btnOrderNew.Text = "Enviar Ordem";
            this.btnOrderNew.UseVisualStyleBackColor = true;
            this.btnOrderNew.Click += new System.EventHandler(this.btnOrderNew_Click);
            // 
            // tabOrderReplace
            // 
            this.tabOrderReplace.Controls.Add(this.lblOrderReplaceTradeChannel);
            this.tabOrderReplace.Controls.Add(this.txtOrderReplaceTradeChannel);
            this.tabOrderReplace.Controls.Add(this.lblOrderReplaceQuotes);
            this.tabOrderReplace.Controls.Add(this.txtOrderReplaceQuotes);
            this.tabOrderReplace.Controls.Add(this.lblOrderReplaceUserMne);
            this.tabOrderReplace.Controls.Add(this.txtOrderReplaceUserMne);
            this.tabOrderReplace.Controls.Add(this.cboOrderReplaceTypeOffer);
            this.tabOrderReplace.Controls.Add(this.lblOrderReplacePrice);
            this.tabOrderReplace.Controls.Add(this.txtOrderReplacePrice);
            this.tabOrderReplace.Controls.Add(this.lblOrderReplaceQtty);
            this.tabOrderReplace.Controls.Add(this.txtOrderReplaceQtty);
            this.tabOrderReplace.Controls.Add(this.lblOrderReplaceOriginalQtty);
            this.tabOrderReplace.Controls.Add(this.txtOrderReplaceOriginalQtty);
            this.tabOrderReplace.Controls.Add(this.lblOrderReplaceTypeOffer);
            this.tabOrderReplace.Controls.Add(this.lblOrderReplaceOfferId);
            this.tabOrderReplace.Controls.Add(this.txtOrderReplaceOfferId);
            this.tabOrderReplace.Controls.Add(this.lblOrderReplaceUser);
            this.tabOrderReplace.Controls.Add(this.txtOrderReplaceUser);
            this.tabOrderReplace.Controls.Add(this.lstOrderReplace);
            this.tabOrderReplace.Controls.Add(this.btnOrderReplace);
            this.tabOrderReplace.Location = new System.Drawing.Point(4, 22);
            this.tabOrderReplace.Name = "tabOrderReplace";
            this.tabOrderReplace.Size = new System.Drawing.Size(825, 545);
            this.tabOrderReplace.TabIndex = 6;
            this.tabOrderReplace.Text = "OrderReplace";
            this.tabOrderReplace.UseVisualStyleBackColor = true;
            // 
            // lblOrderReplaceTradeChannel
            // 
            this.lblOrderReplaceTradeChannel.AutoSize = true;
            this.lblOrderReplaceTradeChannel.Location = new System.Drawing.Point(439, 43);
            this.lblOrderReplaceTradeChannel.Name = "lblOrderReplaceTradeChannel";
            this.lblOrderReplaceTradeChannel.Size = new System.Drawing.Size(74, 13);
            this.lblOrderReplaceTradeChannel.TabIndex = 16;
            this.lblOrderReplaceTradeChannel.Text = "TradeChannel";
            // 
            // txtOrderReplaceTradeChannel
            // 
            this.txtOrderReplaceTradeChannel.Location = new System.Drawing.Point(518, 39);
            this.txtOrderReplaceTradeChannel.MaxLength = 3;
            this.txtOrderReplaceTradeChannel.Name = "txtOrderReplaceTradeChannel";
            this.txtOrderReplaceTradeChannel.Size = new System.Drawing.Size(38, 20);
            this.txtOrderReplaceTradeChannel.TabIndex = 17;
            // 
            // lblOrderReplaceQuotes
            // 
            this.lblOrderReplaceQuotes.AutoSize = true;
            this.lblOrderReplaceQuotes.Location = new System.Drawing.Point(330, 43);
            this.lblOrderReplaceQuotes.Name = "lblOrderReplaceQuotes";
            this.lblOrderReplaceQuotes.Size = new System.Drawing.Size(47, 13);
            this.lblOrderReplaceQuotes.TabIndex = 14;
            this.lblOrderReplaceQuotes.Text = "Cotação";
            // 
            // txtOrderReplaceQuotes
            // 
            this.txtOrderReplaceQuotes.Location = new System.Drawing.Point(382, 39);
            this.txtOrderReplaceQuotes.Name = "txtOrderReplaceQuotes";
            this.txtOrderReplaceQuotes.Size = new System.Drawing.Size(46, 20);
            this.txtOrderReplaceQuotes.TabIndex = 15;
            this.txtOrderReplaceQuotes.Text = "15.45";
            // 
            // lblOrderReplaceUserMne
            // 
            this.lblOrderReplaceUserMne.AutoSize = true;
            this.lblOrderReplaceUserMne.Location = new System.Drawing.Point(102, 13);
            this.lblOrderReplaceUserMne.Name = "lblOrderReplaceUserMne";
            this.lblOrderReplaceUserMne.Size = new System.Drawing.Size(50, 13);
            this.lblOrderReplaceUserMne.TabIndex = 2;
            this.lblOrderReplaceUserMne.Text = "UserMne";
            // 
            // txtOrderReplaceUserMne
            // 
            this.txtOrderReplaceUserMne.Location = new System.Drawing.Point(155, 9);
            this.txtOrderReplaceUserMne.Name = "txtOrderReplaceUserMne";
            this.txtOrderReplaceUserMne.Size = new System.Drawing.Size(64, 20);
            this.txtOrderReplaceUserMne.TabIndex = 3;
            this.txtOrderReplaceUserMne.Text = "00001";
            // 
            // cboOrderReplaceTypeOffer
            // 
            this.cboOrderReplaceTypeOffer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderReplaceTypeOffer.FormattingEnabled = true;
            this.cboOrderReplaceTypeOffer.Items.AddRange(new object[] {
            "Limit",
            "Market"});
            this.cboOrderReplaceTypeOffer.Location = new System.Drawing.Point(396, 9);
            this.cboOrderReplaceTypeOffer.Name = "cboOrderReplaceTypeOffer";
            this.cboOrderReplaceTypeOffer.Size = new System.Drawing.Size(83, 21);
            this.cboOrderReplaceTypeOffer.TabIndex = 7;
            // 
            // lblOrderReplacePrice
            // 
            this.lblOrderReplacePrice.AutoSize = true;
            this.lblOrderReplacePrice.Location = new System.Drawing.Point(239, 43);
            this.lblOrderReplacePrice.Name = "lblOrderReplacePrice";
            this.lblOrderReplacePrice.Size = new System.Drawing.Size(31, 13);
            this.lblOrderReplacePrice.TabIndex = 12;
            this.lblOrderReplacePrice.Text = "Price";
            // 
            // txtOrderReplacePrice
            // 
            this.txtOrderReplacePrice.Location = new System.Drawing.Point(273, 39);
            this.txtOrderReplacePrice.Name = "txtOrderReplacePrice";
            this.txtOrderReplacePrice.Size = new System.Drawing.Size(46, 20);
            this.txtOrderReplacePrice.TabIndex = 13;
            this.txtOrderReplacePrice.Text = "15.45";
            // 
            // lblOrderReplaceQtty
            // 
            this.lblOrderReplaceQtty.AutoSize = true;
            this.lblOrderReplaceQtty.Location = new System.Drawing.Point(145, 43);
            this.lblOrderReplaceQtty.Name = "lblOrderReplaceQtty";
            this.lblOrderReplaceQtty.Size = new System.Drawing.Size(26, 13);
            this.lblOrderReplaceQtty.TabIndex = 10;
            this.lblOrderReplaceQtty.Text = "Qtty";
            // 
            // txtOrderReplaceQtty
            // 
            this.txtOrderReplaceQtty.Location = new System.Drawing.Point(176, 39);
            this.txtOrderReplaceQtty.Name = "txtOrderReplaceQtty";
            this.txtOrderReplaceQtty.Size = new System.Drawing.Size(46, 20);
            this.txtOrderReplaceQtty.TabIndex = 11;
            this.txtOrderReplaceQtty.Text = "200";
            // 
            // lblOrderReplaceOriginalQtty
            // 
            this.lblOrderReplaceOriginalQtty.AutoSize = true;
            this.lblOrderReplaceOriginalQtty.Location = new System.Drawing.Point(18, 43);
            this.lblOrderReplaceOriginalQtty.Name = "lblOrderReplaceOriginalQtty";
            this.lblOrderReplaceOriginalQtty.Size = new System.Drawing.Size(61, 13);
            this.lblOrderReplaceOriginalQtty.TabIndex = 8;
            this.lblOrderReplaceOriginalQtty.Text = "OriginalQtty";
            // 
            // txtOrderReplaceOriginalQtty
            // 
            this.txtOrderReplaceOriginalQtty.Location = new System.Drawing.Point(83, 39);
            this.txtOrderReplaceOriginalQtty.Name = "txtOrderReplaceOriginalQtty";
            this.txtOrderReplaceOriginalQtty.Size = new System.Drawing.Size(46, 20);
            this.txtOrderReplaceOriginalQtty.TabIndex = 9;
            this.txtOrderReplaceOriginalQtty.Text = "100";
            // 
            // lblOrderReplaceTypeOffer
            // 
            this.lblOrderReplaceTypeOffer.AutoSize = true;
            this.lblOrderReplaceTypeOffer.Location = new System.Drawing.Point(339, 13);
            this.lblOrderReplaceTypeOffer.Name = "lblOrderReplaceTypeOffer";
            this.lblOrderReplaceTypeOffer.Size = new System.Drawing.Size(54, 13);
            this.lblOrderReplaceTypeOffer.TabIndex = 6;
            this.lblOrderReplaceTypeOffer.Text = "TypeOffer";
            // 
            // lblOrderReplaceOfferId
            // 
            this.lblOrderReplaceOfferId.AutoSize = true;
            this.lblOrderReplaceOfferId.Location = new System.Drawing.Point(225, 13);
            this.lblOrderReplaceOfferId.Name = "lblOrderReplaceOfferId";
            this.lblOrderReplaceOfferId.Size = new System.Drawing.Size(39, 13);
            this.lblOrderReplaceOfferId.TabIndex = 4;
            this.lblOrderReplaceOfferId.Text = "OfferId";
            // 
            // txtOrderReplaceOfferId
            // 
            this.txtOrderReplaceOfferId.Location = new System.Drawing.Point(265, 9);
            this.txtOrderReplaceOfferId.Name = "txtOrderReplaceOfferId";
            this.txtOrderReplaceOfferId.Size = new System.Drawing.Size(68, 20);
            this.txtOrderReplaceOfferId.TabIndex = 5;
            this.txtOrderReplaceOfferId.Text = "1";
            // 
            // lblOrderReplaceUser
            // 
            this.lblOrderReplaceUser.AutoSize = true;
            this.lblOrderReplaceUser.Location = new System.Drawing.Point(15, 13);
            this.lblOrderReplaceUser.Name = "lblOrderReplaceUser";
            this.lblOrderReplaceUser.Size = new System.Drawing.Size(29, 13);
            this.lblOrderReplaceUser.TabIndex = 0;
            this.lblOrderReplaceUser.Text = "User";
            // 
            // txtOrderReplaceUser
            // 
            this.txtOrderReplaceUser.Location = new System.Drawing.Point(48, 9);
            this.txtOrderReplaceUser.Name = "txtOrderReplaceUser";
            this.txtOrderReplaceUser.Size = new System.Drawing.Size(48, 20);
            this.txtOrderReplaceUser.TabIndex = 1;
            this.txtOrderReplaceUser.Text = "0";
            // 
            // lstOrderReplace
            // 
            this.lstOrderReplace.Location = new System.Drawing.Point(18, 66);
            this.lstOrderReplace.Name = "lstOrderReplace";
            this.lstOrderReplace.ReadOnly = true;
            this.lstOrderReplace.Size = new System.Drawing.Size(796, 463);
            this.lstOrderReplace.TabIndex = 17;
            this.lstOrderReplace.Text = "";
            // 
            // btnOrderReplace
            // 
            this.btnOrderReplace.Location = new System.Drawing.Point(699, 22);
            this.btnOrderReplace.Name = "btnOrderReplace";
            this.btnOrderReplace.Size = new System.Drawing.Size(115, 23);
            this.btnOrderReplace.TabIndex = 16;
            this.btnOrderReplace.Text = "Solicitar Alteração";
            this.btnOrderReplace.UseVisualStyleBackColor = true;
            this.btnOrderReplace.Click += new System.EventHandler(this.btnOrderRelace_Click);
            // 
            // tabOrderCancel
            // 
            this.tabOrderCancel.Controls.Add(this.lblOrderCancelUserMne);
            this.tabOrderCancel.Controls.Add(this.txtOrderCancelUserMne);
            this.tabOrderCancel.Controls.Add(this.lblOrderCancelOferId);
            this.tabOrderCancel.Controls.Add(this.txtOrderCancelOfferId);
            this.tabOrderCancel.Controls.Add(this.lblOrderCancelUser);
            this.tabOrderCancel.Controls.Add(this.txtlOrderCancelUser);
            this.tabOrderCancel.Controls.Add(this.lstOrderCancel);
            this.tabOrderCancel.Controls.Add(this.btnOrderCancel);
            this.tabOrderCancel.Location = new System.Drawing.Point(4, 22);
            this.tabOrderCancel.Name = "tabOrderCancel";
            this.tabOrderCancel.Size = new System.Drawing.Size(825, 545);
            this.tabOrderCancel.TabIndex = 5;
            this.tabOrderCancel.Text = "OrderCancel";
            this.tabOrderCancel.UseVisualStyleBackColor = true;
            // 
            // lblOrderCancelUserMne
            // 
            this.lblOrderCancelUserMne.AutoSize = true;
            this.lblOrderCancelUserMne.Location = new System.Drawing.Point(107, 13);
            this.lblOrderCancelUserMne.Name = "lblOrderCancelUserMne";
            this.lblOrderCancelUserMne.Size = new System.Drawing.Size(50, 13);
            this.lblOrderCancelUserMne.TabIndex = 2;
            this.lblOrderCancelUserMne.Text = "UserMne";
            // 
            // txtOrderCancelUserMne
            // 
            this.txtOrderCancelUserMne.Location = new System.Drawing.Point(160, 9);
            this.txtOrderCancelUserMne.Name = "txtOrderCancelUserMne";
            this.txtOrderCancelUserMne.Size = new System.Drawing.Size(60, 20);
            this.txtOrderCancelUserMne.TabIndex = 3;
            this.txtOrderCancelUserMne.Text = "00001";
            // 
            // lblOrderCancelOferId
            // 
            this.lblOrderCancelOferId.AutoSize = true;
            this.lblOrderCancelOferId.Location = new System.Drawing.Point(226, 13);
            this.lblOrderCancelOferId.Name = "lblOrderCancelOferId";
            this.lblOrderCancelOferId.Size = new System.Drawing.Size(39, 13);
            this.lblOrderCancelOferId.TabIndex = 4;
            this.lblOrderCancelOferId.Text = "OfferId";
            // 
            // txtOrderCancelOfferId
            // 
            this.txtOrderCancelOfferId.Location = new System.Drawing.Point(269, 9);
            this.txtOrderCancelOfferId.Name = "txtOrderCancelOfferId";
            this.txtOrderCancelOfferId.Size = new System.Drawing.Size(70, 20);
            this.txtOrderCancelOfferId.TabIndex = 5;
            this.txtOrderCancelOfferId.Text = "1";
            // 
            // lblOrderCancelUser
            // 
            this.lblOrderCancelUser.AutoSize = true;
            this.lblOrderCancelUser.Location = new System.Drawing.Point(15, 13);
            this.lblOrderCancelUser.Name = "lblOrderCancelUser";
            this.lblOrderCancelUser.Size = new System.Drawing.Size(29, 13);
            this.lblOrderCancelUser.TabIndex = 0;
            this.lblOrderCancelUser.Text = "User";
            // 
            // txtlOrderCancelUser
            // 
            this.txtlOrderCancelUser.Location = new System.Drawing.Point(49, 9);
            this.txtlOrderCancelUser.Name = "txtlOrderCancelUser";
            this.txtlOrderCancelUser.Size = new System.Drawing.Size(48, 20);
            this.txtlOrderCancelUser.TabIndex = 1;
            this.txtlOrderCancelUser.Text = "0";
            // 
            // lstOrderCancel
            // 
            this.lstOrderCancel.Location = new System.Drawing.Point(18, 38);
            this.lstOrderCancel.Name = "lstOrderCancel";
            this.lstOrderCancel.ReadOnly = true;
            this.lstOrderCancel.Size = new System.Drawing.Size(794, 493);
            this.lstOrderCancel.TabIndex = 7;
            this.lstOrderCancel.Text = "";
            // 
            // btnOrderCancel
            // 
            this.btnOrderCancel.Location = new System.Drawing.Point(680, 9);
            this.btnOrderCancel.Name = "btnOrderCancel";
            this.btnOrderCancel.Size = new System.Drawing.Size(132, 23);
            this.btnOrderCancel.TabIndex = 6;
            this.btnOrderCancel.Text = "Solicitar Cancelamento";
            this.btnOrderCancel.UseVisualStyleBackColor = true;
            this.btnOrderCancel.Click += new System.EventHandler(this.btnOrderCancel_Click);
            // 
            // tabOrderList
            // 
            this.tabOrderList.Controls.Add(this.gridOrderList);
            this.tabOrderList.Controls.Add(this.cboOrderListOfferMarketIdFilter);
            this.tabOrderList.Controls.Add(this.lblOrderListOfferMarketIdFilter);
            this.tabOrderList.Controls.Add(this.chkOrderListClientLinked);
            this.tabOrderList.Controls.Add(this.lblOrderListClientMneFilter);
            this.tabOrderList.Controls.Add(this.txtOrderListClientMneFilter);
            this.tabOrderList.Controls.Add(this.cboOrderListListType);
            this.tabOrderList.Controls.Add(this.lblOrderListDaysToList);
            this.tabOrderList.Controls.Add(this.txtOrderListDaysToList);
            this.tabOrderList.Controls.Add(this.lblOrderListListType);
            this.tabOrderList.Controls.Add(this.lblOrderListOfferOfferIdFilter1);
            this.tabOrderList.Controls.Add(this.txtOrderListOfferIdFilter1);
            this.tabOrderList.Controls.Add(this.lblOrderListOfferStatusFilter);
            this.tabOrderList.Controls.Add(this.txtOrderListOfferStatusFilter);
            this.tabOrderList.Controls.Add(this.lblOrderListClientIdFilter);
            this.tabOrderList.Controls.Add(this.txtOrderListClientIdFilter);
            this.tabOrderList.Controls.Add(this.lstOrderList);
            this.tabOrderList.Controls.Add(this.btnOrderList);
            this.tabOrderList.Location = new System.Drawing.Point(4, 22);
            this.tabOrderList.Name = "tabOrderList";
            this.tabOrderList.Size = new System.Drawing.Size(825, 545);
            this.tabOrderList.TabIndex = 4;
            this.tabOrderList.Text = "OrderList";
            this.tabOrderList.UseVisualStyleBackColor = true;
            // 
            // gridOrderList
            // 
            this.gridOrderList.AllowUserToAddRows = false;
            this.gridOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderList.Location = new System.Drawing.Point(21, 67);
            this.gridOrderList.Name = "gridOrderList";
            this.gridOrderList.RowHeadersVisible = false;
            this.gridOrderList.RowHeadersWidth = 62;
            this.gridOrderList.Size = new System.Drawing.Size(787, 309);
            this.gridOrderList.TabIndex = 17;
            // 
            // cboOrderListOfferMarketIdFilter
            // 
            this.cboOrderListOfferMarketIdFilter.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2"});
            this.cboOrderListOfferMarketIdFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderListOfferMarketIdFilter.FormattingEnabled = true;
            this.cboOrderListOfferMarketIdFilter.Items.AddRange(new object[] {
            "",
            "9010",
            "9020",
            "9030",
            "9040",
            "9050",
            "12010",
            "12020",
            "12030"});
            this.cboOrderListOfferMarketIdFilter.Location = new System.Drawing.Point(501, 9);
            this.cboOrderListOfferMarketIdFilter.Name = "cboOrderListOfferMarketIdFilter";
            this.cboOrderListOfferMarketIdFilter.Size = new System.Drawing.Size(60, 21);
            this.cboOrderListOfferMarketIdFilter.TabIndex = 7;
            // 
            // lblOrderListOfferMarketIdFilter
            // 
            this.lblOrderListOfferMarketIdFilter.AutoSize = true;
            this.lblOrderListOfferMarketIdFilter.Location = new System.Drawing.Point(429, 13);
            this.lblOrderListOfferMarketIdFilter.Name = "lblOrderListOfferMarketIdFilter";
            this.lblOrderListOfferMarketIdFilter.Size = new System.Drawing.Size(71, 13);
            this.lblOrderListOfferMarketIdFilter.TabIndex = 6;
            this.lblOrderListOfferMarketIdFilter.Text = "MarketIdFilter";
            // 
            // chkOrderListClientLinked
            // 
            this.chkOrderListClientLinked.AutoSize = true;
            this.chkOrderListClientLinked.Location = new System.Drawing.Point(375, 42);
            this.chkOrderListClientLinked.Name = "chkOrderListClientLinked";
            this.chkOrderListClientLinked.Size = new System.Drawing.Size(138, 17);
            this.chkOrderListClientLinked.TabIndex = 14;
            this.chkOrderListClientLinked.Text = "OrderListClientLinked=3";
            this.chkOrderListClientLinked.UseVisualStyleBackColor = true;
            // 
            // lblOrderListClientMneFilter
            // 
            this.lblOrderListClientMneFilter.AutoSize = true;
            this.lblOrderListClientMneFilter.Location = new System.Drawing.Point(134, 13);
            this.lblOrderListClientMneFilter.Name = "lblOrderListClientMneFilter";
            this.lblOrderListClientMneFilter.Size = new System.Drawing.Size(76, 13);
            this.lblOrderListClientMneFilter.TabIndex = 2;
            this.lblOrderListClientMneFilter.Text = "ClientMneFilter";
            // 
            // txtOrderListClientMneFilter
            // 
            this.txtOrderListClientMneFilter.Location = new System.Drawing.Point(212, 9);
            this.txtOrderListClientMneFilter.Name = "txtOrderListClientMneFilter";
            this.txtOrderListClientMneFilter.Size = new System.Drawing.Size(68, 20);
            this.txtOrderListClientMneFilter.TabIndex = 3;
            this.txtOrderListClientMneFilter.Text = "00001";
            // 
            // cboOrderListListType
            // 
            this.cboOrderListListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderListListType.FormattingEnabled = true;
            this.cboOrderListListType.Items.AddRange(new object[] {
            "G",
            "F"});
            this.cboOrderListListType.Location = new System.Drawing.Point(64, 40);
            this.cboOrderListListType.Name = "cboOrderListListType";
            this.cboOrderListListType.Size = new System.Drawing.Size(38, 21);
            this.cboOrderListListType.TabIndex = 9;
            // 
            // lblOrderListDaysToList
            // 
            this.lblOrderListDaysToList.AutoSize = true;
            this.lblOrderListDaysToList.Location = new System.Drawing.Point(266, 44);
            this.lblOrderListDaysToList.Name = "lblOrderListDaysToList";
            this.lblOrderListDaysToList.Size = new System.Drawing.Size(60, 13);
            this.lblOrderListDaysToList.TabIndex = 12;
            this.lblOrderListDaysToList.Text = "DaysToList";
            // 
            // txtOrderListDaysToList
            // 
            this.txtOrderListDaysToList.Location = new System.Drawing.Point(327, 40);
            this.txtOrderListDaysToList.Name = "txtOrderListDaysToList";
            this.txtOrderListDaysToList.Size = new System.Drawing.Size(17, 20);
            this.txtOrderListDaysToList.TabIndex = 13;
            this.txtOrderListDaysToList.Text = "1";
            // 
            // lblOrderListListType
            // 
            this.lblOrderListListType.AutoSize = true;
            this.lblOrderListListType.Location = new System.Drawing.Point(18, 44);
            this.lblOrderListListType.Name = "lblOrderListListType";
            this.lblOrderListListType.Size = new System.Drawing.Size(47, 13);
            this.lblOrderListListType.TabIndex = 8;
            this.lblOrderListListType.Text = "ListType";
            // 
            // lblOrderListOfferOfferIdFilter1
            // 
            this.lblOrderListOfferOfferIdFilter1.AutoSize = true;
            this.lblOrderListOfferOfferIdFilter1.Location = new System.Drawing.Point(108, 44);
            this.lblOrderListOfferOfferIdFilter1.Name = "lblOrderListOfferOfferIdFilter1";
            this.lblOrderListOfferOfferIdFilter1.Size = new System.Drawing.Size(67, 13);
            this.lblOrderListOfferOfferIdFilter1.TabIndex = 10;
            this.lblOrderListOfferOfferIdFilter1.Text = "OfferIdFilter1";
            // 
            // txtOrderListOfferIdFilter1
            // 
            this.txtOrderListOfferIdFilter1.Location = new System.Drawing.Point(176, 40);
            this.txtOrderListOfferIdFilter1.Name = "txtOrderListOfferIdFilter1";
            this.txtOrderListOfferIdFilter1.Size = new System.Drawing.Size(81, 20);
            this.txtOrderListOfferIdFilter1.TabIndex = 11;
            // 
            // lblOrderListOfferStatusFilter
            // 
            this.lblOrderListOfferStatusFilter.AutoSize = true;
            this.lblOrderListOfferStatusFilter.Location = new System.Drawing.Point(286, 13);
            this.lblOrderListOfferStatusFilter.Name = "lblOrderListOfferStatusFilter";
            this.lblOrderListOfferStatusFilter.Size = new System.Drawing.Size(82, 13);
            this.lblOrderListOfferStatusFilter.TabIndex = 4;
            this.lblOrderListOfferStatusFilter.Text = "OfferStatusFilter";
            // 
            // txtOrderListOfferStatusFilter
            // 
            this.txtOrderListOfferStatusFilter.Location = new System.Drawing.Point(370, 9);
            this.txtOrderListOfferStatusFilter.Name = "txtOrderListOfferStatusFilter";
            this.txtOrderListOfferStatusFilter.Size = new System.Drawing.Size(46, 20);
            this.txtOrderListOfferStatusFilter.TabIndex = 5;
            this.txtOrderListOfferStatusFilter.Text = "PECXV";
            // 
            // lblOrderListClientIdFilter
            // 
            this.lblOrderListClientIdFilter.AutoSize = true;
            this.lblOrderListClientIdFilter.Location = new System.Drawing.Point(15, 13);
            this.lblOrderListClientIdFilter.Name = "lblOrderListClientIdFilter";
            this.lblOrderListClientIdFilter.Size = new System.Drawing.Size(64, 13);
            this.lblOrderListClientIdFilter.TabIndex = 0;
            this.lblOrderListClientIdFilter.Text = "ClientIdFilter";
            // 
            // txtOrderListClientIdFilter
            // 
            this.txtOrderListClientIdFilter.Location = new System.Drawing.Point(80, 9);
            this.txtOrderListClientIdFilter.Name = "txtOrderListClientIdFilter";
            this.txtOrderListClientIdFilter.Size = new System.Drawing.Size(48, 20);
            this.txtOrderListClientIdFilter.TabIndex = 1;
            this.txtOrderListClientIdFilter.Text = "0";
            // 
            // lstOrderList
            // 
            this.lstOrderList.Location = new System.Drawing.Point(21, 382);
            this.lstOrderList.Name = "lstOrderList";
            this.lstOrderList.ReadOnly = true;
            this.lstOrderList.Size = new System.Drawing.Size(784, 148);
            this.lstOrderList.TabIndex = 16;
            this.lstOrderList.Text = "";
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(721, 33);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(84, 23);
            this.btnOrderList.TabIndex = 15;
            this.btnOrderList.Text = "Listar Ordens";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // tabPortfolio
            // 
            this.tabPortfolio.Controls.Add(this.cboPortfolioPortfolioMarketId);
            this.tabPortfolio.Controls.Add(this.lblPortfolioPortfolioMarketId);
            this.tabPortfolio.Controls.Add(this.lblPortfolioUserMne);
            this.tabPortfolio.Controls.Add(this.txtPortfolioUserMne);
            this.tabPortfolio.Controls.Add(this.cboPortfolioPortfolioType);
            this.tabPortfolio.Controls.Add(this.lblPortfolioPortfolioType);
            this.tabPortfolio.Controls.Add(this.lblPortfolioUser);
            this.tabPortfolio.Controls.Add(this.txtPortfolioUser);
            this.tabPortfolio.Controls.Add(this.lstPortfolio);
            this.tabPortfolio.Controls.Add(this.btnPortfolio);
            this.tabPortfolio.Location = new System.Drawing.Point(4, 22);
            this.tabPortfolio.Name = "tabPortfolio";
            this.tabPortfolio.Size = new System.Drawing.Size(825, 545);
            this.tabPortfolio.TabIndex = 7;
            this.tabPortfolio.Text = "Portfolio";
            this.tabPortfolio.UseVisualStyleBackColor = true;
            // 
            // cboPortfolioPortfolioMarketId
            // 
            this.cboPortfolioPortfolioMarketId.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2"});
            this.cboPortfolioPortfolioMarketId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPortfolioPortfolioMarketId.FormattingEnabled = true;
            this.cboPortfolioPortfolioMarketId.Items.AddRange(new object[] {
            "",
            "9010",
            "9020",
            "9030",
            "9040",
            "9050",
            "12010",
            "12020",
            "12030"});
            this.cboPortfolioPortfolioMarketId.Location = new System.Drawing.Point(376, 9);
            this.cboPortfolioPortfolioMarketId.Name = "cboPortfolioPortfolioMarketId";
            this.cboPortfolioPortfolioMarketId.Size = new System.Drawing.Size(60, 21);
            this.cboPortfolioPortfolioMarketId.TabIndex = 8;
            // 
            // lblPortfolioPortfolioMarketId
            // 
            this.lblPortfolioPortfolioMarketId.AutoSize = true;
            this.lblPortfolioPortfolioMarketId.Location = new System.Drawing.Point(321, 13);
            this.lblPortfolioPortfolioMarketId.Name = "lblPortfolioPortfolioMarketId";
            this.lblPortfolioPortfolioMarketId.Size = new System.Drawing.Size(49, 13);
            this.lblPortfolioPortfolioMarketId.TabIndex = 7;
            this.lblPortfolioPortfolioMarketId.Text = "MarketId";
            // 
            // lblPortfolioUserMne
            // 
            this.lblPortfolioUserMne.AutoSize = true;
            this.lblPortfolioUserMne.Location = new System.Drawing.Point(96, 13);
            this.lblPortfolioUserMne.Name = "lblPortfolioUserMne";
            this.lblPortfolioUserMne.Size = new System.Drawing.Size(50, 13);
            this.lblPortfolioUserMne.TabIndex = 3;
            this.lblPortfolioUserMne.Text = "UserMne";
            // 
            // txtPortfolioUserMne
            // 
            this.txtPortfolioUserMne.Location = new System.Drawing.Point(149, 9);
            this.txtPortfolioUserMne.Name = "txtPortfolioUserMne";
            this.txtPortfolioUserMne.Size = new System.Drawing.Size(48, 20);
            this.txtPortfolioUserMne.TabIndex = 4;
            this.txtPortfolioUserMne.Text = "00001";
            // 
            // cboPortfolioPortfolioType
            // 
            this.cboPortfolioPortfolioType.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2"});
            this.cboPortfolioPortfolioType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPortfolioPortfolioType.FormattingEnabled = true;
            this.cboPortfolioPortfolioType.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboPortfolioPortfolioType.Location = new System.Drawing.Point(276, 9);
            this.cboPortfolioPortfolioType.Name = "cboPortfolioPortfolioType";
            this.cboPortfolioPortfolioType.Size = new System.Drawing.Size(35, 21);
            this.cboPortfolioPortfolioType.TabIndex = 6;
            // 
            // lblPortfolioPortfolioType
            // 
            this.lblPortfolioPortfolioType.AutoSize = true;
            this.lblPortfolioPortfolioType.Location = new System.Drawing.Point(201, 13);
            this.lblPortfolioPortfolioType.Name = "lblPortfolioPortfolioType";
            this.lblPortfolioPortfolioType.Size = new System.Drawing.Size(69, 13);
            this.lblPortfolioPortfolioType.TabIndex = 5;
            this.lblPortfolioPortfolioType.Text = "PortfolioType";
            // 
            // lblPortfolioUser
            // 
            this.lblPortfolioUser.AutoSize = true;
            this.lblPortfolioUser.Location = new System.Drawing.Point(15, 13);
            this.lblPortfolioUser.Name = "lblPortfolioUser";
            this.lblPortfolioUser.Size = new System.Drawing.Size(29, 13);
            this.lblPortfolioUser.TabIndex = 1;
            this.lblPortfolioUser.Text = "User";
            // 
            // txtPortfolioUser
            // 
            this.txtPortfolioUser.Location = new System.Drawing.Point(46, 9);
            this.txtPortfolioUser.Name = "txtPortfolioUser";
            this.txtPortfolioUser.Size = new System.Drawing.Size(48, 20);
            this.txtPortfolioUser.TabIndex = 2;
            this.txtPortfolioUser.Text = "0";
            // 
            // lstPortfolio
            // 
            this.lstPortfolio.Location = new System.Drawing.Point(18, 38);
            this.lstPortfolio.Name = "lstPortfolio";
            this.lstPortfolio.ReadOnly = true;
            this.lstPortfolio.Size = new System.Drawing.Size(792, 492);
            this.lstPortfolio.TabIndex = 0;
            this.lstPortfolio.Text = "";
            // 
            // btnPortfolio
            // 
            this.btnPortfolio.Location = new System.Drawing.Point(726, 8);
            this.btnPortfolio.Name = "btnPortfolio";
            this.btnPortfolio.Size = new System.Drawing.Size(84, 23);
            this.btnPortfolio.TabIndex = 9;
            this.btnPortfolio.Text = "Listar Portfolio";
            this.btnPortfolio.UseVisualStyleBackColor = true;
            this.btnPortfolio.Click += new System.EventHandler(this.btnPortfolio_Click);
            // 
            // tabRuleVerifyQuotes
            // 
            this.tabRuleVerifyQuotes.Controls.Add(this.chkRuleVerifyQuotesAfterMarket);
            this.tabRuleVerifyQuotes.Controls.Add(this.cboRuleVerifyQuotesSide);
            this.tabRuleVerifyQuotes.Controls.Add(this.lblRuleVerifyQuotesSide);
            this.tabRuleVerifyQuotes.Controls.Add(this.lblRuleVerifyQuotesSourceID);
            this.tabRuleVerifyQuotes.Controls.Add(this.txtRuleVerifyQuotesSourceID);
            this.tabRuleVerifyQuotes.Controls.Add(this.lblRuleVerifyQuotesSymbolID);
            this.tabRuleVerifyQuotes.Controls.Add(this.txtRuleVerifyQuotesSymbolID);
            this.tabRuleVerifyQuotes.Controls.Add(this.lblRuleVerifyQuotesUserMne);
            this.tabRuleVerifyQuotes.Controls.Add(this.txtRuleVerifyQuotesUserMne);
            this.tabRuleVerifyQuotes.Controls.Add(this.lblRuleVerifyQuotesUser);
            this.tabRuleVerifyQuotes.Controls.Add(this.txtRuleVerifyQuotesUser);
            this.tabRuleVerifyQuotes.Controls.Add(this.lstRuleVerifyQuotes);
            this.tabRuleVerifyQuotes.Controls.Add(this.btnRuleVerifyQuotes);
            this.tabRuleVerifyQuotes.Location = new System.Drawing.Point(4, 22);
            this.tabRuleVerifyQuotes.Name = "tabRuleVerifyQuotes";
            this.tabRuleVerifyQuotes.Size = new System.Drawing.Size(825, 545);
            this.tabRuleVerifyQuotes.TabIndex = 10;
            this.tabRuleVerifyQuotes.Text = "RuleVerifyQuotes";
            this.tabRuleVerifyQuotes.UseVisualStyleBackColor = true;
            // 
            // chkRuleVerifyQuotesAfterMarket
            // 
            this.chkRuleVerifyQuotesAfterMarket.AutoSize = true;
            this.chkRuleVerifyQuotesAfterMarket.Location = new System.Drawing.Point(526, 11);
            this.chkRuleVerifyQuotesAfterMarket.Name = "chkRuleVerifyQuotesAfterMarket";
            this.chkRuleVerifyQuotesAfterMarket.Size = new System.Drawing.Size(81, 17);
            this.chkRuleVerifyQuotesAfterMarket.TabIndex = 10;
            this.chkRuleVerifyQuotesAfterMarket.Text = "AfterMarket";
            this.chkRuleVerifyQuotesAfterMarket.UseVisualStyleBackColor = true;
            // 
            // cboRuleVerifyQuotesSide
            // 
            this.cboRuleVerifyQuotesSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRuleVerifyQuotesSide.FormattingEnabled = true;
            this.cboRuleVerifyQuotesSide.Items.AddRange(new object[] {
            "B",
            "S"});
            this.cboRuleVerifyQuotesSide.Location = new System.Drawing.Point(464, 9);
            this.cboRuleVerifyQuotesSide.Name = "cboRuleVerifyQuotesSide";
            this.cboRuleVerifyQuotesSide.Size = new System.Drawing.Size(39, 21);
            this.cboRuleVerifyQuotesSide.TabIndex = 9;
            // 
            // lblRuleVerifyQuotesSide
            // 
            this.lblRuleVerifyQuotesSide.AutoSize = true;
            this.lblRuleVerifyQuotesSide.Location = new System.Drawing.Point(434, 13);
            this.lblRuleVerifyQuotesSide.Name = "lblRuleVerifyQuotesSide";
            this.lblRuleVerifyQuotesSide.Size = new System.Drawing.Size(28, 13);
            this.lblRuleVerifyQuotesSide.TabIndex = 8;
            this.lblRuleVerifyQuotesSide.Text = "Side";
            // 
            // lblRuleVerifyQuotesSourceID
            // 
            this.lblRuleVerifyQuotesSourceID.AutoSize = true;
            this.lblRuleVerifyQuotesSourceID.Location = new System.Drawing.Point(209, 13);
            this.lblRuleVerifyQuotesSourceID.Name = "lblRuleVerifyQuotesSourceID";
            this.lblRuleVerifyQuotesSourceID.Size = new System.Drawing.Size(52, 13);
            this.lblRuleVerifyQuotesSourceID.TabIndex = 4;
            this.lblRuleVerifyQuotesSourceID.Text = "SourceID";
            // 
            // txtRuleVerifyQuotesSourceID
            // 
            this.txtRuleVerifyQuotesSourceID.Location = new System.Drawing.Point(264, 9);
            this.txtRuleVerifyQuotesSourceID.Name = "txtRuleVerifyQuotesSourceID";
            this.txtRuleVerifyQuotesSourceID.Size = new System.Drawing.Size(24, 20);
            this.txtRuleVerifyQuotesSourceID.TabIndex = 5;
            this.txtRuleVerifyQuotesSourceID.Text = "12";
            // 
            // lblRuleVerifyQuotesSymbolID
            // 
            this.lblRuleVerifyQuotesSymbolID.AutoSize = true;
            this.lblRuleVerifyQuotesSymbolID.Location = new System.Drawing.Point(303, 13);
            this.lblRuleVerifyQuotesSymbolID.Name = "lblRuleVerifyQuotesSymbolID";
            this.lblRuleVerifyQuotesSymbolID.Size = new System.Drawing.Size(52, 13);
            this.lblRuleVerifyQuotesSymbolID.TabIndex = 6;
            this.lblRuleVerifyQuotesSymbolID.Text = "SymbolID";
            // 
            // txtRuleVerifyQuotesSymbolID
            // 
            this.txtRuleVerifyQuotesSymbolID.Location = new System.Drawing.Point(358, 9);
            this.txtRuleVerifyQuotesSymbolID.Name = "txtRuleVerifyQuotesSymbolID";
            this.txtRuleVerifyQuotesSymbolID.Size = new System.Drawing.Size(57, 20);
            this.txtRuleVerifyQuotesSymbolID.TabIndex = 7;
            this.txtRuleVerifyQuotesSymbolID.Text = "PETR4";
            // 
            // lblRuleVerifyQuotesUserMne
            // 
            this.lblRuleVerifyQuotesUserMne.AutoSize = true;
            this.lblRuleVerifyQuotesUserMne.Location = new System.Drawing.Point(98, 13);
            this.lblRuleVerifyQuotesUserMne.Name = "lblRuleVerifyQuotesUserMne";
            this.lblRuleVerifyQuotesUserMne.Size = new System.Drawing.Size(50, 13);
            this.lblRuleVerifyQuotesUserMne.TabIndex = 2;
            this.lblRuleVerifyQuotesUserMne.Text = "UserMne";
            // 
            // txtRuleVerifyQuotesUserMne
            // 
            this.txtRuleVerifyQuotesUserMne.Location = new System.Drawing.Point(151, 9);
            this.txtRuleVerifyQuotesUserMne.Name = "txtRuleVerifyQuotesUserMne";
            this.txtRuleVerifyQuotesUserMne.Size = new System.Drawing.Size(48, 20);
            this.txtRuleVerifyQuotesUserMne.TabIndex = 3;
            this.txtRuleVerifyQuotesUserMne.Text = "00001";
            // 
            // lblRuleVerifyQuotesUser
            // 
            this.lblRuleVerifyQuotesUser.AutoSize = true;
            this.lblRuleVerifyQuotesUser.Location = new System.Drawing.Point(17, 13);
            this.lblRuleVerifyQuotesUser.Name = "lblRuleVerifyQuotesUser";
            this.lblRuleVerifyQuotesUser.Size = new System.Drawing.Size(29, 13);
            this.lblRuleVerifyQuotesUser.TabIndex = 0;
            this.lblRuleVerifyQuotesUser.Text = "User";
            // 
            // txtRuleVerifyQuotesUser
            // 
            this.txtRuleVerifyQuotesUser.Location = new System.Drawing.Point(48, 9);
            this.txtRuleVerifyQuotesUser.Name = "txtRuleVerifyQuotesUser";
            this.txtRuleVerifyQuotesUser.Size = new System.Drawing.Size(48, 20);
            this.txtRuleVerifyQuotesUser.TabIndex = 1;
            this.txtRuleVerifyQuotesUser.Text = "0";
            // 
            // lstRuleVerifyQuotes
            // 
            this.lstRuleVerifyQuotes.Location = new System.Drawing.Point(20, 39);
            this.lstRuleVerifyQuotes.Name = "lstRuleVerifyQuotes";
            this.lstRuleVerifyQuotes.ReadOnly = true;
            this.lstRuleVerifyQuotes.Size = new System.Drawing.Size(792, 489);
            this.lstRuleVerifyQuotes.TabIndex = 12;
            this.lstRuleVerifyQuotes.Text = "";
            // 
            // btnRuleVerifyQuotes
            // 
            this.btnRuleVerifyQuotes.Location = new System.Drawing.Point(728, 8);
            this.btnRuleVerifyQuotes.Name = "btnRuleVerifyQuotes";
            this.btnRuleVerifyQuotes.Size = new System.Drawing.Size(84, 23);
            this.btnRuleVerifyQuotes.TabIndex = 11;
            this.btnRuleVerifyQuotes.Text = "Listar Regra";
            this.btnRuleVerifyQuotes.UseVisualStyleBackColor = true;
            this.btnRuleVerifyQuotes.Click += new System.EventHandler(this.btnRuleVerifyQuotes_Click);
            // 
            // tabFinancialStatements
            // 
            this.tabFinancialStatements.Controls.Add(this.lstFinancialStatements);
            this.tabFinancialStatements.Controls.Add(this.lblFinancialStatementsUserMne);
            this.tabFinancialStatements.Controls.Add(this.txtFinancialStatementsUserMne);
            this.tabFinancialStatements.Controls.Add(this.lblFinancialStatementsUser);
            this.tabFinancialStatements.Controls.Add(this.txtFinancialStatementsUser);
            this.tabFinancialStatements.Controls.Add(this.btnFinancialStatements);
            this.tabFinancialStatements.Location = new System.Drawing.Point(4, 22);
            this.tabFinancialStatements.Name = "tabFinancialStatements";
            this.tabFinancialStatements.Size = new System.Drawing.Size(825, 545);
            this.tabFinancialStatements.TabIndex = 13;
            this.tabFinancialStatements.Text = "FinancialStatements";
            this.tabFinancialStatements.UseVisualStyleBackColor = true;
            // 
            // lstFinancialStatements
            // 
            this.lstFinancialStatements.Location = new System.Drawing.Point(20, 37);
            this.lstFinancialStatements.Name = "lstFinancialStatements";
            this.lstFinancialStatements.ReadOnly = true;
            this.lstFinancialStatements.Size = new System.Drawing.Size(792, 492);
            this.lstFinancialStatements.TabIndex = 18;
            this.lstFinancialStatements.Text = "";
            // 
            // lblFinancialStatementsUserMne
            // 
            this.lblFinancialStatementsUserMne.AutoSize = true;
            this.lblFinancialStatementsUserMne.Location = new System.Drawing.Point(98, 13);
            this.lblFinancialStatementsUserMne.Name = "lblFinancialStatementsUserMne";
            this.lblFinancialStatementsUserMne.Size = new System.Drawing.Size(50, 13);
            this.lblFinancialStatementsUserMne.TabIndex = 15;
            this.lblFinancialStatementsUserMne.Text = "UserMne";
            // 
            // txtFinancialStatementsUserMne
            // 
            this.txtFinancialStatementsUserMne.Location = new System.Drawing.Point(151, 9);
            this.txtFinancialStatementsUserMne.Name = "txtFinancialStatementsUserMne";
            this.txtFinancialStatementsUserMne.Size = new System.Drawing.Size(48, 20);
            this.txtFinancialStatementsUserMne.TabIndex = 16;
            this.txtFinancialStatementsUserMne.Text = "00001";
            // 
            // lblFinancialStatementsUser
            // 
            this.lblFinancialStatementsUser.AutoSize = true;
            this.lblFinancialStatementsUser.Location = new System.Drawing.Point(17, 13);
            this.lblFinancialStatementsUser.Name = "lblFinancialStatementsUser";
            this.lblFinancialStatementsUser.Size = new System.Drawing.Size(29, 13);
            this.lblFinancialStatementsUser.TabIndex = 13;
            this.lblFinancialStatementsUser.Text = "User";
            // 
            // txtFinancialStatementsUser
            // 
            this.txtFinancialStatementsUser.Location = new System.Drawing.Point(48, 9);
            this.txtFinancialStatementsUser.Name = "txtFinancialStatementsUser";
            this.txtFinancialStatementsUser.Size = new System.Drawing.Size(48, 20);
            this.txtFinancialStatementsUser.TabIndex = 14;
            this.txtFinancialStatementsUser.Text = "0";
            // 
            // btnFinancialStatements
            // 
            this.btnFinancialStatements.Location = new System.Drawing.Point(716, 8);
            this.btnFinancialStatements.Name = "btnFinancialStatements";
            this.btnFinancialStatements.Size = new System.Drawing.Size(96, 23);
            this.btnFinancialStatements.TabIndex = 17;
            this.btnFinancialStatements.Text = "Listar Financeiro";
            this.btnFinancialStatements.UseVisualStyleBackColor = true;
            this.btnFinancialStatements.Click += new System.EventHandler(this.btnFinancialStatements_Click);
            // 
            // tabMarketSymbol
            // 
            this.tabMarketSymbol.Controls.Add(this.lblMarketSymbolSourceId);
            this.tabMarketSymbol.Controls.Add(this.txtMarketSymbolSourceId);
            this.tabMarketSymbol.Controls.Add(this.txtMarketSymbolInfo);
            this.tabMarketSymbol.Controls.Add(this.lblSymbolId);
            this.tabMarketSymbol.Controls.Add(this.txtMarketSymbolId);
            this.tabMarketSymbol.Controls.Add(this.btnMarketSymbolInfo);
            this.tabMarketSymbol.Location = new System.Drawing.Point(4, 22);
            this.tabMarketSymbol.Margin = new System.Windows.Forms.Padding(2);
            this.tabMarketSymbol.Name = "tabMarketSymbol";
            this.tabMarketSymbol.Padding = new System.Windows.Forms.Padding(2);
            this.tabMarketSymbol.Size = new System.Drawing.Size(825, 545);
            this.tabMarketSymbol.TabIndex = 18;
            this.tabMarketSymbol.Text = "MarketSymbol";
            this.tabMarketSymbol.UseVisualStyleBackColor = true;
            // 
            // lblMarketSymbolSourceId
            // 
            this.lblMarketSymbolSourceId.AutoSize = true;
            this.lblMarketSymbolSourceId.Location = new System.Drawing.Point(179, 12);
            this.lblMarketSymbolSourceId.Name = "lblMarketSymbolSourceId";
            this.lblMarketSymbolSourceId.Size = new System.Drawing.Size(53, 13);
            this.lblMarketSymbolSourceId.TabIndex = 24;
            this.lblMarketSymbolSourceId.Text = "SourceId:";
            // 
            // txtMarketSymbolSourceId
            // 
            this.txtMarketSymbolSourceId.Location = new System.Drawing.Point(181, 29);
            this.txtMarketSymbolSourceId.Name = "txtMarketSymbolSourceId";
            this.txtMarketSymbolSourceId.Size = new System.Drawing.Size(40, 20);
            this.txtMarketSymbolSourceId.TabIndex = 23;
            this.txtMarketSymbolSourceId.Text = "12";
            // 
            // txtMarketSymbolInfo
            // 
            this.txtMarketSymbolInfo.Location = new System.Drawing.Point(17, 65);
            this.txtMarketSymbolInfo.Name = "txtMarketSymbolInfo";
            this.txtMarketSymbolInfo.ReadOnly = true;
            this.txtMarketSymbolInfo.Size = new System.Drawing.Size(794, 462);
            this.txtMarketSymbolInfo.TabIndex = 22;
            this.txtMarketSymbolInfo.Text = "";
            // 
            // lblSymbolId
            // 
            this.lblSymbolId.AutoSize = true;
            this.lblSymbolId.Location = new System.Drawing.Point(14, 13);
            this.lblSymbolId.Name = "lblSymbolId";
            this.lblSymbolId.Size = new System.Drawing.Size(144, 13);
            this.lblSymbolId.TabIndex = 21;
            this.lblSymbolId.Text = "SymbolId(s)(sep. por vírgula):";
            // 
            // txtMarketSymbolId
            // 
            this.txtMarketSymbolId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarketSymbolId.Location = new System.Drawing.Point(17, 29);
            this.txtMarketSymbolId.Name = "txtMarketSymbolId";
            this.txtMarketSymbolId.Size = new System.Drawing.Size(141, 20);
            this.txtMarketSymbolId.TabIndex = 20;
            this.txtMarketSymbolId.Text = "PETR4,MGLU3";
            // 
            // btnMarketSymbolInfo
            // 
            this.btnMarketSymbolInfo.Location = new System.Drawing.Point(262, 13);
            this.btnMarketSymbolInfo.Name = "btnMarketSymbolInfo";
            this.btnMarketSymbolInfo.Size = new System.Drawing.Size(133, 34);
            this.btnMarketSymbolInfo.TabIndex = 18;
            this.btnMarketSymbolInfo.Text = "Solicitar Informação de mercado";
            this.btnMarketSymbolInfo.UseVisualStyleBackColor = true;
            this.btnMarketSymbolInfo.Click += new System.EventHandler(this.btnMarketSymbolInfo_Click);
            // 
            // tabSendOptionExercise
            // 
            this.tabSendOptionExercise.Controls.Add(this.cboMarketIdSendOption);
            this.tabSendOptionExercise.Controls.Add(this.label18);
            this.tabSendOptionExercise.Controls.Add(this.txtUserMneSendOption);
            this.tabSendOptionExercise.Controls.Add(this.label19);
            this.tabSendOptionExercise.Controls.Add(this.txtUserSendOption);
            this.tabSendOptionExercise.Controls.Add(this.btnSendOption);
            this.tabSendOptionExercise.Controls.Add(this.txtResultSendOption);
            this.tabSendOptionExercise.Controls.Add(this.chkConfirmationSendOption);
            this.tabSendOptionExercise.Controls.Add(this.lblSignature);
            this.tabSendOptionExercise.Controls.Add(this.txtSignatureSendOption);
            this.tabSendOptionExercise.Controls.Add(this.label17);
            this.tabSendOptionExercise.Controls.Add(this.label16);
            this.tabSendOptionExercise.Controls.Add(this.txtQuantitySendOption);
            this.tabSendOptionExercise.Controls.Add(this.label14);
            this.tabSendOptionExercise.Controls.Add(this.txtSourceIdSendOption);
            this.tabSendOptionExercise.Controls.Add(this.label15);
            this.tabSendOptionExercise.Controls.Add(this.txtSymbolSendOption);
            this.tabSendOptionExercise.Location = new System.Drawing.Point(4, 22);
            this.tabSendOptionExercise.Margin = new System.Windows.Forms.Padding(2);
            this.tabSendOptionExercise.Name = "tabSendOptionExercise";
            this.tabSendOptionExercise.Padding = new System.Windows.Forms.Padding(2);
            this.tabSendOptionExercise.Size = new System.Drawing.Size(825, 545);
            this.tabSendOptionExercise.TabIndex = 19;
            this.tabSendOptionExercise.Text = "SendOptionExercise";
            this.tabSendOptionExercise.UseVisualStyleBackColor = true;
            // 
            // cboMarketIdSendOption
            // 
            this.cboMarketIdSendOption.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2"});
            this.cboMarketIdSendOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarketIdSendOption.FormattingEnabled = true;
            this.cboMarketIdSendOption.Items.AddRange(new object[] {
            "9010",
            "9020",
            "9030",
            "9040",
            "9050",
            "12010",
            "12020",
            "12030"});
            this.cboMarketIdSendOption.Location = new System.Drawing.Point(397, 12);
            this.cboMarketIdSendOption.Name = "cboMarketIdSendOption";
            this.cboMarketIdSendOption.Size = new System.Drawing.Size(60, 21);
            this.cboMarketIdSendOption.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(105, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "UserMne";
            // 
            // txtUserMneSendOption
            // 
            this.txtUserMneSendOption.Location = new System.Drawing.Point(157, 37);
            this.txtUserMneSendOption.Name = "txtUserMneSendOption";
            this.txtUserMneSendOption.Size = new System.Drawing.Size(64, 20);
            this.txtUserMneSendOption.TabIndex = 28;
            this.txtUserMneSendOption.Text = "00001";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "User";
            // 
            // txtUserSendOption
            // 
            this.txtUserSendOption.Location = new System.Drawing.Point(51, 37);
            this.txtUserSendOption.Name = "txtUserSendOption";
            this.txtUserSendOption.Size = new System.Drawing.Size(48, 20);
            this.txtUserSendOption.TabIndex = 26;
            this.txtUserSendOption.Text = "0";
            // 
            // btnSendOption
            // 
            this.btnSendOption.Location = new System.Drawing.Point(681, 12);
            this.btnSendOption.Name = "btnSendOption";
            this.btnSendOption.Size = new System.Drawing.Size(125, 20);
            this.btnSendOption.TabIndex = 24;
            this.btnSendOption.Text = "Exercer Opção";
            this.btnSendOption.UseVisualStyleBackColor = true;
            this.btnSendOption.Click += new System.EventHandler(this.btnSendOption_Click);
            // 
            // txtResultSendOption
            // 
            this.txtResultSendOption.Location = new System.Drawing.Point(13, 60);
            this.txtResultSendOption.Name = "txtResultSendOption";
            this.txtResultSendOption.ReadOnly = true;
            this.txtResultSendOption.Size = new System.Drawing.Size(794, 469);
            this.txtResultSendOption.TabIndex = 23;
            this.txtResultSendOption.Text = "";
            // 
            // chkConfirmationSendOption
            // 
            this.chkConfirmationSendOption.AutoSize = true;
            this.chkConfirmationSendOption.Location = new System.Drawing.Point(606, 17);
            this.chkConfirmationSendOption.Name = "chkConfirmationSendOption";
            this.chkConfirmationSendOption.Size = new System.Drawing.Size(70, 17);
            this.chkConfirmationSendOption.TabIndex = 18;
            this.chkConfirmationSendOption.Text = "Confirmar";
            this.chkConfirmationSendOption.UseVisualStyleBackColor = true;
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(463, 18);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(52, 13);
            this.lblSignature.TabIndex = 16;
            this.lblSignature.Text = "Signature";
            // 
            // txtSignatureSendOption
            // 
            this.txtSignatureSendOption.Location = new System.Drawing.Point(527, 13);
            this.txtSignatureSendOption.Name = "txtSignatureSendOption";
            this.txtSignatureSendOption.Size = new System.Drawing.Size(55, 20);
            this.txtSignatureSendOption.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(354, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Market";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(240, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Quantidade";
            // 
            // txtQuantitySendOption
            // 
            this.txtQuantitySendOption.Location = new System.Drawing.Point(305, 14);
            this.txtQuantitySendOption.Name = "txtQuantitySendOption";
            this.txtQuantitySendOption.Size = new System.Drawing.Size(37, 20);
            this.txtQuantitySendOption.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "SourceID";
            // 
            // txtSourceIdSendOption
            // 
            this.txtSourceIdSendOption.Location = new System.Drawing.Point(75, 14);
            this.txtSourceIdSendOption.Name = "txtSourceIdSendOption";
            this.txtSourceIdSendOption.Size = new System.Drawing.Size(24, 20);
            this.txtSourceIdSendOption.TabIndex = 9;
            this.txtSourceIdSendOption.Text = "12";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(111, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Symbol";
            // 
            // txtSymbolSendOption
            // 
            this.txtSymbolSendOption.Location = new System.Drawing.Point(157, 14);
            this.txtSymbolSendOption.Name = "txtSymbolSendOption";
            this.txtSymbolSendOption.Size = new System.Drawing.Size(72, 20);
            this.txtSymbolSendOption.TabIndex = 11;
            this.txtSymbolSendOption.Text = "PETR4";
            // 
            // tabMonitoring
            // 
            this.tabMonitoring.Controls.Add(this.lblSessioninstrumentationAction);
            this.tabMonitoring.Controls.Add(this.txtSessioninstrumentationAction);
            this.tabMonitoring.Controls.Add(this.chkInstrumentationIcase);
            this.tabMonitoring.Controls.Add(this.lblInstrumentationClass);
            this.tabMonitoring.Controls.Add(this.txtInstrumentationClass);
            this.tabMonitoring.Controls.Add(this.lblSessionStreamerId);
            this.tabMonitoring.Controls.Add(this.txtSessionStreamerIdInstrumentation);
            this.tabMonitoring.Controls.Add(this.label13);
            this.tabMonitoring.Controls.Add(this.txtStreamerIdInstrumentation);
            this.tabMonitoring.Controls.Add(this.label12);
            this.tabMonitoring.Controls.Add(this.label11);
            this.tabMonitoring.Controls.Add(this.label10);
            this.tabMonitoring.Controls.Add(this.txtPasswordInstrumentation);
            this.tabMonitoring.Controls.Add(this.txtUserInstrumentation);
            this.tabMonitoring.Controls.Add(this.cboInstrumentation);
            this.tabMonitoring.Controls.Add(this.label9);
            this.tabMonitoring.Controls.Add(this.label8);
            this.tabMonitoring.Controls.Add(this.txtAdminPwd);
            this.tabMonitoring.Controls.Add(this.txtAdminUser);
            this.tabMonitoring.Controls.Add(this.txtInstrumentation);
            this.tabMonitoring.Controls.Add(this.btnInstrumentation);
            this.tabMonitoring.Controls.Add(this.txtPingRequest);
            this.tabMonitoring.Controls.Add(this.txtAudit);
            this.tabMonitoring.Controls.Add(this.btnAudit);
            this.tabMonitoring.Controls.Add(this.btnPing);
            this.tabMonitoring.Controls.Add(this.txtCheck);
            this.tabMonitoring.Controls.Add(this.btnCheck);
            this.tabMonitoring.Controls.Add(this.chkHealthCheck);
            this.tabMonitoring.Controls.Add(this.lstHealthCheck);
            this.tabMonitoring.Controls.Add(this.btnHealthCheck);
            this.tabMonitoring.Location = new System.Drawing.Point(4, 22);
            this.tabMonitoring.Name = "tabMonitoring";
            this.tabMonitoring.Size = new System.Drawing.Size(825, 545);
            this.tabMonitoring.TabIndex = 11;
            this.tabMonitoring.Text = "Monitoramento";
            this.tabMonitoring.UseVisualStyleBackColor = true;
            this.tabMonitoring.Click += new System.EventHandler(this.tabMonitoring_Click);
            // 
            // lblSessioninstrumentationAction
            // 
            this.lblSessioninstrumentationAction.AutoSize = true;
            this.lblSessioninstrumentationAction.Location = new System.Drawing.Point(671, 358);
            this.lblSessioninstrumentationAction.Name = "lblSessioninstrumentationAction";
            this.lblSessioninstrumentationAction.Size = new System.Drawing.Size(40, 13);
            this.lblSessioninstrumentationAction.TabIndex = 29;
            this.lblSessioninstrumentationAction.Text = "Action:";
            this.lblSessioninstrumentationAction.Visible = false;
            // 
            // txtSessioninstrumentationAction
            // 
            this.txtSessioninstrumentationAction.Location = new System.Drawing.Point(678, 374);
            this.txtSessioninstrumentationAction.Name = "txtSessioninstrumentationAction";
            this.txtSessioninstrumentationAction.Size = new System.Drawing.Size(135, 20);
            this.txtSessioninstrumentationAction.TabIndex = 28;
            this.txtSessioninstrumentationAction.Text = "checkQueues";
            this.txtSessioninstrumentationAction.Visible = false;
            // 
            // chkInstrumentationIcase
            // 
            this.chkInstrumentationIcase.AutoSize = true;
            this.chkInstrumentationIcase.Location = new System.Drawing.Point(755, 374);
            this.chkInstrumentationIcase.Name = "chkInstrumentationIcase";
            this.chkInstrumentationIcase.Size = new System.Drawing.Size(52, 17);
            this.chkInstrumentationIcase.TabIndex = 11;
            this.chkInstrumentationIcase.Text = "Icase";
            this.chkInstrumentationIcase.UseVisualStyleBackColor = true;
            // 
            // lblInstrumentationClass
            // 
            this.lblInstrumentationClass.AutoSize = true;
            this.lblInstrumentationClass.Location = new System.Drawing.Point(671, 357);
            this.lblInstrumentationClass.Name = "lblInstrumentationClass";
            this.lblInstrumentationClass.Size = new System.Drawing.Size(35, 13);
            this.lblInstrumentationClass.TabIndex = 27;
            this.lblInstrumentationClass.Text = "Class:";
            // 
            // txtInstrumentationClass
            // 
            this.txtInstrumentationClass.Location = new System.Drawing.Point(677, 374);
            this.txtInstrumentationClass.Name = "txtInstrumentationClass";
            this.txtInstrumentationClass.Size = new System.Drawing.Size(68, 20);
            this.txtInstrumentationClass.TabIndex = 26;
            this.txtInstrumentationClass.Text = ".*";
            // 
            // lblSessionStreamerId
            // 
            this.lblSessionStreamerId.AutoSize = true;
            this.lblSessionStreamerId.Location = new System.Drawing.Point(519, 396);
            this.lblSessionStreamerId.Name = "lblSessionStreamerId";
            this.lblSessionStreamerId.Size = new System.Drawing.Size(98, 13);
            this.lblSessionStreamerId.TabIndex = 25;
            this.lblSessionStreamerId.Text = "SessionStreamerId:";
            // 
            // txtSessionStreamerIdInstrumentation
            // 
            this.txtSessionStreamerIdInstrumentation.Location = new System.Drawing.Point(522, 412);
            this.txtSessionStreamerIdInstrumentation.Name = "txtSessionStreamerIdInstrumentation";
            this.txtSessionStreamerIdInstrumentation.Size = new System.Drawing.Size(146, 20);
            this.txtSessionStreamerIdInstrumentation.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(429, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "StreamerId:";
            // 
            // txtStreamerIdInstrumentation
            // 
            this.txtStreamerIdInstrumentation.Location = new System.Drawing.Point(431, 412);
            this.txtStreamerIdInstrumentation.Name = "txtStreamerIdInstrumentation";
            this.txtStreamerIdInstrumentation.Size = new System.Drawing.Size(84, 20);
            this.txtStreamerIdInstrumentation.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Tipo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(597, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(519, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Username:";
            // 
            // txtPasswordInstrumentation
            // 
            this.txtPasswordInstrumentation.Location = new System.Drawing.Point(600, 374);
            this.txtPasswordInstrumentation.Name = "txtPasswordInstrumentation";
            this.txtPasswordInstrumentation.Size = new System.Drawing.Size(68, 20);
            this.txtPasswordInstrumentation.TabIndex = 18;
            this.txtPasswordInstrumentation.UseSystemPasswordChar = true;
            // 
            // txtUserInstrumentation
            // 
            this.txtUserInstrumentation.Location = new System.Drawing.Point(522, 374);
            this.txtUserInstrumentation.Name = "txtUserInstrumentation";
            this.txtUserInstrumentation.Size = new System.Drawing.Size(72, 20);
            this.txtUserInstrumentation.TabIndex = 17;
            // 
            // cboInstrumentation
            // 
            this.cboInstrumentation.FormattingEnabled = true;
            this.cboInstrumentation.Items.AddRange(new object[] {
            "Instrumentation",
            "Session"});
            this.cboInstrumentation.Location = new System.Drawing.Point(429, 374);
            this.cboInstrumentation.Margin = new System.Windows.Forms.Padding(2);
            this.cboInstrumentation.Name = "cboInstrumentation";
            this.cboInstrumentation.Size = new System.Drawing.Size(86, 21);
            this.cboInstrumentation.TabIndex = 16;
            this.cboInstrumentation.SelectedIndexChanged += new System.EventHandler(this.cboInstrumentation_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(679, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "admin_pwd:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "admin_user:";
            // 
            // txtAdminPwd
            // 
            this.txtAdminPwd.Location = new System.Drawing.Point(682, 192);
            this.txtAdminPwd.Name = "txtAdminPwd";
            this.txtAdminPwd.PasswordChar = '*';
            this.txtAdminPwd.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPwd.TabIndex = 13;
            // 
            // txtAdminUser
            // 
            this.txtAdminUser.Location = new System.Drawing.Point(553, 192);
            this.txtAdminUser.Name = "txtAdminUser";
            this.txtAdminUser.Size = new System.Drawing.Size(100, 20);
            this.txtAdminUser.TabIndex = 12;
            // 
            // txtInstrumentation
            // 
            this.txtInstrumentation.Location = new System.Drawing.Point(429, 434);
            this.txtInstrumentation.Name = "txtInstrumentation";
            this.txtInstrumentation.ReadOnly = true;
            this.txtInstrumentation.Size = new System.Drawing.Size(384, 95);
            this.txtInstrumentation.TabIndex = 11;
            this.txtInstrumentation.Text = "";
            // 
            // btnInstrumentation
            // 
            this.btnInstrumentation.Location = new System.Drawing.Point(678, 405);
            this.btnInstrumentation.Name = "btnInstrumentation";
            this.btnInstrumentation.Size = new System.Drawing.Size(133, 23);
            this.btnInstrumentation.TabIndex = 10;
            this.btnInstrumentation.Text = "Solicitar Instrumentation";
            this.btnInstrumentation.UseVisualStyleBackColor = true;
            this.btnInstrumentation.Click += new System.EventHandler(this.btnInstrumentation_Click);
            // 
            // txtPingRequest
            // 
            this.txtPingRequest.Location = new System.Drawing.Point(19, 405);
            this.txtPingRequest.Name = "txtPingRequest";
            this.txtPingRequest.ReadOnly = true;
            this.txtPingRequest.Size = new System.Drawing.Size(384, 124);
            this.txtPingRequest.TabIndex = 9;
            this.txtPingRequest.Text = "";
            // 
            // txtAudit
            // 
            this.txtAudit.Location = new System.Drawing.Point(429, 220);
            this.txtAudit.Name = "txtAudit";
            this.txtAudit.ReadOnly = true;
            this.txtAudit.Size = new System.Drawing.Size(384, 129);
            this.txtAudit.TabIndex = 8;
            this.txtAudit.Text = "";
            // 
            // btnAudit
            // 
            this.btnAudit.Location = new System.Drawing.Point(429, 190);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(95, 23);
            this.btnAudit.TabIndex = 7;
            this.btnAudit.Text = "Solicitar Audit";
            this.btnAudit.UseVisualStyleBackColor = true;
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(19, 371);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(89, 23);
            this.btnPing.TabIndex = 5;
            this.btnPing.Text = "Ping Request";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(18, 220);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.ReadOnly = true;
            this.txtCheck.Size = new System.Drawing.Size(384, 129);
            this.txtCheck.TabIndex = 4;
            this.txtCheck.Text = "";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(18, 190);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(89, 23);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Solicitar Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // chkHealthCheck
            // 
            this.chkHealthCheck.AutoSize = true;
            this.chkHealthCheck.Location = new System.Drawing.Point(176, 12);
            this.chkHealthCheck.Name = "chkHealthCheck";
            this.chkHealthCheck.Size = new System.Drawing.Size(68, 17);
            this.chkHealthCheck.TabIndex = 0;
            this.chkHealthCheck.Text = "Analítico";
            this.chkHealthCheck.UseVisualStyleBackColor = true;
            // 
            // lstHealthCheck
            // 
            this.lstHealthCheck.Location = new System.Drawing.Point(19, 38);
            this.lstHealthCheck.Name = "lstHealthCheck";
            this.lstHealthCheck.ReadOnly = true;
            this.lstHealthCheck.Size = new System.Drawing.Size(794, 129);
            this.lstHealthCheck.TabIndex = 2;
            this.lstHealthCheck.Text = "";
            // 
            // btnHealthCheck
            // 
            this.btnHealthCheck.Location = new System.Drawing.Point(18, 8);
            this.btnHealthCheck.Name = "btnHealthCheck";
            this.btnHealthCheck.Size = new System.Drawing.Size(132, 23);
            this.btnHealthCheck.TabIndex = 1;
            this.btnHealthCheck.Text = "Solicitar HealthCheck";
            this.btnHealthCheck.UseVisualStyleBackColor = true;
            this.btnHealthCheck.Click += new System.EventHandler(this.btnHealthCheck_Click);
            // 
            // tabLoadTest
            // 
            this.tabLoadTest.Controls.Add(this.txtMillisecondsToLoopingTest);
            this.tabLoadTest.Controls.Add(this.label21);
            this.tabLoadTest.Controls.Add(this.rbTestQuotes);
            this.tabLoadTest.Controls.Add(this.rbTestOrder);
            this.tabLoadTest.Controls.Add(this.chkSignLoadTest);
            this.tabLoadTest.Controls.Add(this.txtLoadTest);
            this.tabLoadTest.Controls.Add(this.numQtdAtores);
            this.tabLoadTest.Controls.Add(this.gridSubscriptionsLoadTest);
            this.tabLoadTest.Controls.Add(this.lblQttActors);
            this.tabLoadTest.Controls.Add(this.btnAddLoadTest);
            this.tabLoadTest.Location = new System.Drawing.Point(4, 22);
            this.tabLoadTest.Margin = new System.Windows.Forms.Padding(2);
            this.tabLoadTest.Name = "tabLoadTest";
            this.tabLoadTest.Size = new System.Drawing.Size(825, 545);
            this.tabLoadTest.TabIndex = 21;
            this.tabLoadTest.Text = "LoadTest";
            this.tabLoadTest.UseVisualStyleBackColor = true;
            // 
            // txtMillisecondsToLoopingTest
            // 
            this.txtMillisecondsToLoopingTest.Location = new System.Drawing.Point(630, 15);
            this.txtMillisecondsToLoopingTest.Margin = new System.Windows.Forms.Padding(2);
            this.txtMillisecondsToLoopingTest.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.txtMillisecondsToLoopingTest.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtMillisecondsToLoopingTest.Name = "txtMillisecondsToLoopingTest";
            this.txtMillisecondsToLoopingTest.Size = new System.Drawing.Size(56, 20);
            this.txtMillisecondsToLoopingTest.TabIndex = 27;
            this.txtMillisecondsToLoopingTest.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(558, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Looping (ms)";
            // 
            // rbTestQuotes
            // 
            this.rbTestQuotes.AutoSize = true;
            this.rbTestQuotes.Location = new System.Drawing.Point(344, 15);
            this.rbTestQuotes.Margin = new System.Windows.Forms.Padding(2);
            this.rbTestQuotes.Name = "rbTestQuotes";
            this.rbTestQuotes.Size = new System.Drawing.Size(65, 17);
            this.rbTestQuotes.TabIndex = 25;
            this.rbTestQuotes.Text = "Cotação";
            this.rbTestQuotes.UseVisualStyleBackColor = true;
            // 
            // rbTestOrder
            // 
            this.rbTestOrder.AutoSize = true;
            this.rbTestOrder.Checked = true;
            this.rbTestOrder.Location = new System.Drawing.Point(201, 15);
            this.rbTestOrder.Margin = new System.Windows.Forms.Padding(2);
            this.rbTestOrder.Name = "rbTestOrder";
            this.rbTestOrder.Size = new System.Drawing.Size(134, 17);
            this.rbTestOrder.TabIndex = 24;
            this.rbTestOrder.TabStop = true;
            this.rbTestOrder.Text = "Ordem (envio/listagem)";
            this.rbTestOrder.UseVisualStyleBackColor = true;
            // 
            // chkSignLoadTest
            // 
            this.chkSignLoadTest.AutoSize = true;
            this.chkSignLoadTest.Checked = true;
            this.chkSignLoadTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSignLoadTest.Location = new System.Drawing.Point(489, 16);
            this.chkSignLoadTest.Name = "chkSignLoadTest";
            this.chkSignLoadTest.Size = new System.Drawing.Size(60, 17);
            this.chkSignLoadTest.TabIndex = 23;
            this.chkSignLoadTest.Text = "Assinar";
            this.chkSignLoadTest.UseVisualStyleBackColor = true;
            this.chkSignLoadTest.CheckedChanged += new System.EventHandler(this.chkSignLoadTest_CheckedChanged);
            // 
            // txtLoadTest
            // 
            this.txtLoadTest.Location = new System.Drawing.Point(11, 321);
            this.txtLoadTest.Name = "txtLoadTest";
            this.txtLoadTest.ReadOnly = true;
            this.txtLoadTest.Size = new System.Drawing.Size(797, 210);
            this.txtLoadTest.TabIndex = 22;
            this.txtLoadTest.Text = "";
            // 
            // numQtdAtores
            // 
            this.numQtdAtores.Location = new System.Drawing.Point(121, 15);
            this.numQtdAtores.Margin = new System.Windows.Forms.Padding(2);
            this.numQtdAtores.Name = "numQtdAtores";
            this.numQtdAtores.Size = new System.Drawing.Size(56, 20);
            this.numQtdAtores.TabIndex = 21;
            this.numQtdAtores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gridSubscriptionsLoadTest
            // 
            this.gridSubscriptionsLoadTest.AllowUserToAddRows = false;
            this.gridSubscriptionsLoadTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSubscriptionsLoadTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HiddenIdLoadTest,
            this.UnsignLoadTest,
            this.LoadTestId,
            this.QttActors,
            this.MillisecondsToRequestLooping});
            this.gridSubscriptionsLoadTest.Location = new System.Drawing.Point(9, 40);
            this.gridSubscriptionsLoadTest.Name = "gridSubscriptionsLoadTest";
            this.gridSubscriptionsLoadTest.RowHeadersVisible = false;
            this.gridSubscriptionsLoadTest.RowHeadersWidth = 62;
            this.gridSubscriptionsLoadTest.Size = new System.Drawing.Size(797, 274);
            this.gridSubscriptionsLoadTest.TabIndex = 15;
            this.gridSubscriptionsLoadTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSubscriptionsLoadTest_CellContentClick);
            // 
            // HiddenIdLoadTest
            // 
            this.HiddenIdLoadTest.Frozen = true;
            this.HiddenIdLoadTest.HeaderText = "HiddenId";
            this.HiddenIdLoadTest.MinimumWidth = 8;
            this.HiddenIdLoadTest.Name = "HiddenIdLoadTest";
            this.HiddenIdLoadTest.Visible = false;
            this.HiddenIdLoadTest.Width = 150;
            // 
            // UnsignLoadTest
            // 
            this.UnsignLoadTest.Frozen = true;
            this.UnsignLoadTest.HeaderText = "";
            this.UnsignLoadTest.MinimumWidth = 8;
            this.UnsignLoadTest.Name = "UnsignLoadTest";
            this.UnsignLoadTest.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnsignLoadTest.Width = 150;
            // 
            // LoadTestId
            // 
            this.LoadTestId.Frozen = true;
            this.LoadTestId.HeaderText = "LoadTestId";
            this.LoadTestId.MinimumWidth = 8;
            this.LoadTestId.Name = "LoadTestId";
            this.LoadTestId.Width = 150;
            // 
            // QttActors
            // 
            this.QttActors.Frozen = true;
            this.QttActors.HeaderText = "QttActors";
            this.QttActors.MinimumWidth = 8;
            this.QttActors.Name = "QttActors";
            this.QttActors.Width = 150;
            // 
            // MillisecondsToRequestLooping
            // 
            this.MillisecondsToRequestLooping.HeaderText = "Looping (ms)";
            this.MillisecondsToRequestLooping.MinimumWidth = 8;
            this.MillisecondsToRequestLooping.Name = "MillisecondsToRequestLooping";
            this.MillisecondsToRequestLooping.Width = 150;
            // 
            // lblQttActors
            // 
            this.lblQttActors.AutoSize = true;
            this.lblQttActors.Location = new System.Drawing.Point(7, 16);
            this.lblQttActors.Name = "lblQttActors";
            this.lblQttActors.Size = new System.Drawing.Size(110, 13);
            this.lblQttActors.TabIndex = 12;
            this.lblQttActors.Text = "Quantidade de Atores";
            // 
            // btnAddLoadTest
            // 
            this.btnAddLoadTest.Location = new System.Drawing.Point(715, 11);
            this.btnAddLoadTest.Name = "btnAddLoadTest";
            this.btnAddLoadTest.Size = new System.Drawing.Size(92, 23);
            this.btnAddLoadTest.TabIndex = 14;
            this.btnAddLoadTest.Text = "Efetuar Teste";
            this.btnAddLoadTest.UseVisualStyleBackColor = true;
            this.btnAddLoadTest.Click += new System.EventHandler(this.btnAddLoadTest_Click);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.label1);
            this.tabLog.Controls.Add(this.lblQttLogs);
            this.tabLog.Controls.Add(this.cboQttLogs);
            this.tabLog.Controls.Add(this.cboLogs);
            this.tabLog.Controls.Add(this.btnBuscarLog);
            this.tabLog.Controls.Add(this.txtLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(825, 545);
            this.tabLog.TabIndex = 14;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Logs:";
            // 
            // lblQttLogs
            // 
            this.lblQttLogs.AutoSize = true;
            this.lblQttLogs.Location = new System.Drawing.Point(332, 16);
            this.lblQttLogs.Name = "lblQttLogs";
            this.lblQttLogs.Size = new System.Drawing.Size(68, 13);
            this.lblQttLogs.TabIndex = 16;
            this.lblQttLogs.Text = "Quant. Logs:";
            // 
            // cboQttLogs
            // 
            this.cboQttLogs.FormattingEnabled = true;
            this.cboQttLogs.Items.AddRange(new object[] {
            "100",
            "200",
            "500",
            "1000",
            "Todos"});
            this.cboQttLogs.Location = new System.Drawing.Point(406, 12);
            this.cboQttLogs.Name = "cboQttLogs";
            this.cboQttLogs.Size = new System.Drawing.Size(111, 21);
            this.cboQttLogs.TabIndex = 15;
            // 
            // cboLogs
            // 
            this.cboLogs.FormattingEnabled = true;
            this.cboLogs.Location = new System.Drawing.Point(54, 11);
            this.cboLogs.Name = "cboLogs";
            this.cboLogs.Size = new System.Drawing.Size(233, 21);
            this.cboLogs.TabIndex = 14;
            // 
            // btnBuscarLog
            // 
            this.btnBuscarLog.Location = new System.Drawing.Point(723, 11);
            this.btnBuscarLog.Name = "btnBuscarLog";
            this.btnBuscarLog.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLog.TabIndex = 13;
            this.btnBuscarLog.Text = "Buscar";
            this.btnBuscarLog.UseVisualStyleBackColor = true;
            this.btnBuscarLog.Click += new System.EventHandler(this.btnBuscarLog_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(18, 40);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(794, 489);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            // 
            // tabPostman
            // 
            this.tabPostman.Controls.Add(this.label7);
            this.tabPostman.Controls.Add(this.cboDownloadPostman);
            this.tabPostman.Controls.Add(this.btnDownloadPostman);
            this.tabPostman.Controls.Add(this.txtDownloadPostman);
            this.tabPostman.Location = new System.Drawing.Point(4, 22);
            this.tabPostman.Name = "tabPostman";
            this.tabPostman.Padding = new System.Windows.Forms.Padding(3);
            this.tabPostman.Size = new System.Drawing.Size(825, 545);
            this.tabPostman.TabIndex = 17;
            this.tabPostman.Text = "Postman";
            this.tabPostman.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Arquivos para download:";
            // 
            // cboDownloadPostman
            // 
            this.cboDownloadPostman.FormattingEnabled = true;
            this.cboDownloadPostman.Location = new System.Drawing.Point(143, 9);
            this.cboDownloadPostman.Name = "cboDownloadPostman";
            this.cboDownloadPostman.Size = new System.Drawing.Size(233, 21);
            this.cboDownloadPostman.TabIndex = 20;
            // 
            // btnDownloadPostman
            // 
            this.btnDownloadPostman.Location = new System.Drawing.Point(724, 7);
            this.btnDownloadPostman.Name = "btnDownloadPostman";
            this.btnDownloadPostman.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadPostman.TabIndex = 19;
            this.btnDownloadPostman.Text = "Download";
            this.btnDownloadPostman.UseVisualStyleBackColor = true;
            this.btnDownloadPostman.Click += new System.EventHandler(this.btnDownloadPostman_Click);
            // 
            // txtDownloadPostman
            // 
            this.txtDownloadPostman.Location = new System.Drawing.Point(19, 36);
            this.txtDownloadPostman.Name = "txtDownloadPostman";
            this.txtDownloadPostman.ReadOnly = true;
            this.txtDownloadPostman.Size = new System.Drawing.Size(794, 487);
            this.txtDownloadPostman.TabIndex = 18;
            this.txtDownloadPostman.Text = "";
            // 
            // chkJson
            // 
            this.chkJson.AutoSize = true;
            this.chkJson.Location = new System.Drawing.Point(741, 582);
            this.chkJson.Name = "chkJson";
            this.chkJson.Size = new System.Drawing.Size(95, 17);
            this.chkJson.TabIndex = 1;
            this.chkJson.Text = "Retorno JSON";
            this.chkJson.UseVisualStyleBackColor = true;
            // 
            // chkEnableTrace
            // 
            this.chkEnableTrace.AutoSize = true;
            this.chkEnableTrace.Location = new System.Drawing.Point(619, 582);
            this.chkEnableTrace.Name = "chkEnableTrace";
            this.chkEnableTrace.Size = new System.Drawing.Size(95, 17);
            this.chkEnableTrace.TabIndex = 10;
            this.chkEnableTrace.Text = "Habilitar Trace";
            this.chkEnableTrace.UseVisualStyleBackColor = true;
            // 
            // openFileDialogProvider
            // 
            this.openFileDialogProvider.FileName = "openFileDialogProvider";
            // 
            // frmWinFormAPITester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(851, 614);
            this.Controls.Add(this.chkEnableTrace);
            this.Controls.Add(this.chkJson);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWinFormAPITester";
            this.Text = "CMA.StreamerFeedAPI.Winform.Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabInstantiate.ResumeLayout(false);
            this.tabInstantiate.PerformLayout();
            this.tabQuotes.ResumeLayout(false);
            this.tabQuotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubscriptions)).EndInit();
            this.tabSymbolSearch.ResumeLayout(false);
            this.tabSymbolSearch.PerformLayout();
            this.tabQuotesHistory.ResumeLayout(false);
            this.tabQuotesHistory.PerformLayout();
            this.tabBook.ResumeLayout(false);
            this.tabBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubscriptionsBook)).EndInit();
            this.tabNews.ResumeLayout(false);
            this.tabNews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNews)).EndInit();
            this.tabHighlights.ResumeLayout(false);
            this.tabHighlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHighlights)).EndInit();
            this.tabProvider.ResumeLayout(false);
            this.tabProvider.PerformLayout();
            this.gbProviderConfigurations.ResumeLayout(false);
            this.gbProviderConfigurations.PerformLayout();
            this.tabClientList.ResumeLayout(false);
            this.tabClientList.PerformLayout();
            this.tabOrderNew.ResumeLayout(false);
            this.tabOrderNew.PerformLayout();
            this.tabOrderReplace.ResumeLayout(false);
            this.tabOrderReplace.PerformLayout();
            this.tabOrderCancel.ResumeLayout(false);
            this.tabOrderCancel.PerformLayout();
            this.tabOrderList.ResumeLayout(false);
            this.tabOrderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderList)).EndInit();
            this.tabPortfolio.ResumeLayout(false);
            this.tabPortfolio.PerformLayout();
            this.tabRuleVerifyQuotes.ResumeLayout(false);
            this.tabRuleVerifyQuotes.PerformLayout();
            this.tabFinancialStatements.ResumeLayout(false);
            this.tabFinancialStatements.PerformLayout();
            this.tabMarketSymbol.ResumeLayout(false);
            this.tabMarketSymbol.PerformLayout();
            this.tabSendOptionExercise.ResumeLayout(false);
            this.tabSendOptionExercise.PerformLayout();
            this.tabMonitoring.ResumeLayout(false);
            this.tabMonitoring.PerformLayout();
            this.tabLoadTest.ResumeLayout(false);
            this.tabLoadTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMillisecondsToLoopingTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdAtores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubscriptionsLoadTest)).EndInit();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.tabPostman.ResumeLayout(false);
            this.tabPostman.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TabPage tabQuotes;
        public System.Windows.Forms.RichTextBox lstQuotes;
        public System.Windows.Forms.TextBox txtQuotesSymbolID;
        public System.Windows.Forms.Button btnQuotes;
        public System.Windows.Forms.TabPage tabSymbolSearch;
        public System.Windows.Forms.RichTextBox lstSymbol;
        public System.Windows.Forms.TextBox txtSymbol;
        public System.Windows.Forms.Button btnSymbol;
        public System.Windows.Forms.Label lblSymbol;
        public System.Windows.Forms.Label lblSymbolDescricao;
        public System.Windows.Forms.TextBox txtSymbolDescription;
        public System.Windows.Forms.Label lblSymbolMarket;
        public System.Windows.Forms.TabPage tabClientList;
        public System.Windows.Forms.Label lblSymbolSourceID;
        public System.Windows.Forms.TextBox txtSymbolSourceID;
        public System.Windows.Forms.Label lblClientAssessorId;
        public System.Windows.Forms.TextBox txtClientAssessorId;
        public System.Windows.Forms.TextBox txtClientFilterData;
        public System.Windows.Forms.Label lblClientFilterData;
        public System.Windows.Forms.Label lblClientFilterType;
        public System.Windows.Forms.Label lblClientBranchId;
        public System.Windows.Forms.RichTextBox lstClient;
        public System.Windows.Forms.TextBox txtClientBranchId;
        public System.Windows.Forms.Button btnClientList;
        public System.Windows.Forms.Label lblQuotesSourceID;
        public System.Windows.Forms.TextBox txtQuotesSourceID;
        public System.Windows.Forms.Label lblQuotesSymbolID;
        public System.Windows.Forms.TabPage tabOrderNew;
        public System.Windows.Forms.Label lblOrderNewUser;
        public System.Windows.Forms.TextBox txtOrderNewUserId;
        public System.Windows.Forms.Label lblOrderNewSymbol;
        public System.Windows.Forms.RichTextBox lstOrderNew;
        public System.Windows.Forms.TextBox txtOrderNewSymbol;
        public System.Windows.Forms.Button btnOrderNew;
        public System.Windows.Forms.TabPage tabOrderList;
        public System.Windows.Forms.TabPage tabOrderCancel;
        public System.Windows.Forms.TabPage tabOrderReplace;
        public System.Windows.Forms.TabPage tabPortfolio;
        public System.Windows.Forms.Label lblOrderNewPrice;
        public System.Windows.Forms.TextBox txtOrderNewPrice;
        public System.Windows.Forms.Label lblOrderNewQtty;
        public System.Windows.Forms.TextBox txtOrderNewQtty;
        public System.Windows.Forms.Label lblOrderNewSide;
        public System.Windows.Forms.Label lblOrderListOfferStatusFilter;
        public System.Windows.Forms.TextBox txtOrderListOfferStatusFilter;
        public System.Windows.Forms.Label lblOrderListClientIdFilter;
        public System.Windows.Forms.TextBox txtOrderListClientIdFilter;
        public System.Windows.Forms.RichTextBox lstOrderList;
        public System.Windows.Forms.Button btnOrderList;
        public System.Windows.Forms.Label lblPortfolioUser;
        public System.Windows.Forms.TextBox txtPortfolioUser;
        public System.Windows.Forms.RichTextBox lstPortfolio;
        public System.Windows.Forms.Button btnPortfolio;
        public System.Windows.Forms.Label lblOrderCancelOferId;
        public System.Windows.Forms.TextBox txtOrderCancelOfferId;
        public System.Windows.Forms.Label lblOrderCancelUser;
        public System.Windows.Forms.TextBox txtlOrderCancelUser;
        public System.Windows.Forms.RichTextBox lstOrderCancel;
        public System.Windows.Forms.Button btnOrderCancel;
        public System.Windows.Forms.Label lblOrderReplacePrice;
        public System.Windows.Forms.TextBox txtOrderReplacePrice;
        public System.Windows.Forms.Label lblOrderReplaceQtty;
        public System.Windows.Forms.TextBox txtOrderReplaceQtty;
        public System.Windows.Forms.Label lblOrderReplaceOriginalQtty;
        public System.Windows.Forms.TextBox txtOrderReplaceOriginalQtty;
        public System.Windows.Forms.Label lblOrderReplaceTypeOffer;
        public System.Windows.Forms.Label lblOrderReplaceOfferId;
        public System.Windows.Forms.TextBox txtOrderReplaceOfferId;
        public System.Windows.Forms.Label lblOrderReplaceUser;
        public System.Windows.Forms.TextBox txtOrderReplaceUser;
        public System.Windows.Forms.RichTextBox lstOrderReplace;
        public System.Windows.Forms.Button btnOrderReplace;
        public System.Windows.Forms.Label lblOrderNewTypeOffer;
        public System.Windows.Forms.ComboBox cboOrderNewTypeOffer;
        public System.Windows.Forms.Label lblOrderListOfferOfferIdFilter1;
        public System.Windows.Forms.TextBox txtOrderListOfferIdFilter1;
        public System.Windows.Forms.Label lblOrderListListType;
        public System.Windows.Forms.Label lblOrderListDaysToList;
        public System.Windows.Forms.TextBox txtOrderListDaysToList;
        public System.Windows.Forms.ComboBox cboOrderNewSide;
        public System.Windows.Forms.ComboBox cboOrderListListType;
        public System.Windows.Forms.ComboBox cboClientFilterType;
        public System.Windows.Forms.ComboBox cboPortfolioPortfolioType;
        public System.Windows.Forms.Label lblPortfolioPortfolioType;
        public System.Windows.Forms.ComboBox cboOrderReplaceTypeOffer;
        public System.Windows.Forms.ComboBox cboSymbolMarket;
        public System.Windows.Forms.CheckBox chkJson;
        public System.Windows.Forms.Label lblOrderNewUserMne;
        public System.Windows.Forms.TextBox txtOrderNewUserMne;
        public System.Windows.Forms.Label lblPortfolioUserMne;
        public System.Windows.Forms.TextBox txtPortfolioUserMne;
        public System.Windows.Forms.Label lblOrderListClientMneFilter;
        public System.Windows.Forms.TextBox txtOrderListClientMneFilter;
        public System.Windows.Forms.Label lblOrderCancelUserMne;
        public System.Windows.Forms.TextBox txtOrderCancelUserMne;
        public System.Windows.Forms.Label lblOrderReplaceUserMne;
        public System.Windows.Forms.TextBox txtOrderReplaceUserMne;
        public System.Windows.Forms.TabPage tabBook;
        public System.Windows.Forms.TextBox txtBookDeep;
        public System.Windows.Forms.Label lblBookSourceID;
        public System.Windows.Forms.TextBox txtBookSourceID;
        public System.Windows.Forms.Label lblBookSymbolID;
        public System.Windows.Forms.RichTextBox lstBook;
        public System.Windows.Forms.TextBox txtBookSymbolID;
        public System.Windows.Forms.Button btnBook;
        public System.Windows.Forms.Label lblBookDeep;
        public System.Windows.Forms.ComboBox cboBookConsolidate;
        public System.Windows.Forms.Label lblBookConsolidate;
        public System.Windows.Forms.TabPage tabNews;
        public System.Windows.Forms.Label lblNewsSourceID;
        public System.Windows.Forms.TextBox txtNewsSourceID;
        public System.Windows.Forms.RichTextBox lstNews;
        public System.Windows.Forms.Button btnNews;
        public System.Windows.Forms.Label lblNewsQuantity;
        public System.Windows.Forms.TextBox txtNewsQuantity;
        public System.Windows.Forms.Label lblNewsTextFilter;
        public System.Windows.Forms.TextBox txtNewsTextFilter;
        public System.Windows.Forms.Label lblNewsSubjectFilter;
        public System.Windows.Forms.TextBox txtNewsSubjectFilter;
        public System.Windows.Forms.CheckBox chkOrderListClientLinked;
        public System.Windows.Forms.Label lblQuotesClientMneMD;
        public System.Windows.Forms.TextBox txtQuotesClientMneMD;
        public System.Windows.Forms.Label lblBookClientMneMD;
        public System.Windows.Forms.TextBox txtBookClientMneMD;
        public System.Windows.Forms.Label lblNewsClientMneMD;
        public System.Windows.Forms.TextBox txtNewsClientMneMD;
        public System.Windows.Forms.TabPage tabRuleVerifyQuotes;
        public System.Windows.Forms.Label lblRuleVerifyQuotesUserMne;
        public System.Windows.Forms.TextBox txtRuleVerifyQuotesUserMne;
        public System.Windows.Forms.Label lblRuleVerifyQuotesUser;
        public System.Windows.Forms.TextBox txtRuleVerifyQuotesUser;
        public System.Windows.Forms.RichTextBox lstRuleVerifyQuotes;
        public System.Windows.Forms.Button btnRuleVerifyQuotes;
        public System.Windows.Forms.CheckBox chkRuleVerifyQuotesAfterMarket;
        public System.Windows.Forms.ComboBox cboRuleVerifyQuotesSide;
        public System.Windows.Forms.Label lblRuleVerifyQuotesSide;
        public System.Windows.Forms.Label lblRuleVerifyQuotesSourceID;
        public System.Windows.Forms.TextBox txtRuleVerifyQuotesSourceID;
        public System.Windows.Forms.Label lblRuleVerifyQuotesSymbolID;
        public System.Windows.Forms.TextBox txtRuleVerifyQuotesSymbolID;
        public System.Windows.Forms.Label lblOrderNewQuotes;
        public System.Windows.Forms.TextBox txtOrderNewQuotes;
        public System.Windows.Forms.Label lblOrderReplaceQuotes;
        public System.Windows.Forms.TextBox txtOrderReplaceQuotes;
        public System.Windows.Forms.TabPage tabMonitoring;
        public System.Windows.Forms.CheckBox chkHealthCheck;
        public System.Windows.Forms.RichTextBox lstHealthCheck;
        public System.Windows.Forms.Button btnHealthCheck;
        public System.Windows.Forms.ComboBox cboPortfolioPortfolioMarketId;
        public System.Windows.Forms.Label lblPortfolioPortfolioMarketId;
        public System.Windows.Forms.ComboBox cboOrderNewMarketId;
        public System.Windows.Forms.Label lblOrderNewMarketId;
        public System.Windows.Forms.ComboBox cboOrderListOfferMarketIdFilter;
        public System.Windows.Forms.Label lblOrderListOfferMarketIdFilter;
        public System.Windows.Forms.Label lblNewsDateFilter;
        public System.Windows.Forms.TextBox txtNewsDateFilter;
        public System.Windows.Forms.TabPage tabQuotesHistory;
        public System.Windows.Forms.Label lblQuotesHistoryDateTo;
        public System.Windows.Forms.TextBox txtQuotesHistoryDateTo;
        public System.Windows.Forms.Label lblQuotesHistoryDateFrom;
        public System.Windows.Forms.TextBox txtQuotesHistoryDateFrom;
        public System.Windows.Forms.Label lblQuotesHistoryCLientMneMD;
        public System.Windows.Forms.TextBox txtQuotesHistoryCLientMneMD;
        public System.Windows.Forms.ComboBox cboQuotesHistoryPeriod;
        public System.Windows.Forms.Label lblQuotesHistoryPeriod;
        public System.Windows.Forms.Label lblQuotesHistorySourceID;
        public System.Windows.Forms.TextBox txtQuotesHistorySourceID;
        public System.Windows.Forms.Label lblQuotesHistorySymbolID;
        public System.Windows.Forms.RichTextBox lstQuotesHistory;
        public System.Windows.Forms.TextBox txtQuotesHistorySymbolID;
        public System.Windows.Forms.Button btnQuotesHistory;
        public System.Windows.Forms.Label lblOrderNewTradeChannel;
        public System.Windows.Forms.TextBox txtOrderNewTradeChannel;
        public System.Windows.Forms.Label lblOrderReplaceTradeChannel;
        public System.Windows.Forms.TextBox txtOrderReplaceTradeChannel;
        public System.Windows.Forms.TabPage tabFinancialStatements;
        public System.Windows.Forms.Label lblFinancialStatementsUserMne;
        public System.Windows.Forms.TextBox txtFinancialStatementsUserMne;
        public System.Windows.Forms.Label lblFinancialStatementsUser;
        public System.Windows.Forms.TextBox txtFinancialStatementsUser;
        public System.Windows.Forms.Button btnFinancialStatements;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.RichTextBox lstFinancialStatements;
        public System.Windows.Forms.CheckBox chkSign;
        public System.Windows.Forms.CheckBox chkBookSign;
        public System.Windows.Forms.CheckBox chkEnableTrace;
        public System.Windows.Forms.CheckBox chkOnlyDiffQuotes;
        public System.Windows.Forms.TabPage tabLog;
        public System.Windows.Forms.RichTextBox txtLog;
        public System.Windows.Forms.Button btnBuscarLog;
        public System.Windows.Forms.ComboBox cboLogs;
        public System.Windows.Forms.ComboBox cboQttLogs;
        public System.Windows.Forms.Label lblQttLogs;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView gridSubscriptions;
        public System.Windows.Forms.DataGridView gridSubscriptionsBook;
        public ScottPlot.FormsPlot formsPlotQuotesHistory;
        public System.Windows.Forms.CheckBox chkQuotesHistorySign;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.DataGridView gridOrderList;
        public System.Windows.Forms.CheckBox chkNewsSign;
        public System.Windows.Forms.DataGridView gridNews;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenIdNews;
        private System.Windows.Forms.DataGridViewButtonColumn Integra;
        private System.Windows.Forms.TabPage tabInstantiate;
        public System.Windows.Forms.Label lblInstanceName;
        public System.Windows.Forms.TextBox txtInstanceName;
        public System.Windows.Forms.Label lblService;
        public System.Windows.Forms.TextBox txtService;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.Label lblDomainId;
        public System.Windows.Forms.TextBox txtDomainId;
        public System.Windows.Forms.Label lblAcceptorUrl;
        public System.Windows.Forms.TextBox txtAcceptorUrl;
        public System.Windows.Forms.Label lblLoginTokenKeyLength;
        public System.Windows.Forms.TextBox txtLoginTokenKeyLength;
        public System.Windows.Forms.Label lblLoginTokenSaltIterations;
        public System.Windows.Forms.TextBox txtLoginTokenSaltIterations;
        public System.Windows.Forms.Label lblLoginTokenSaltKey;
        public System.Windows.Forms.TextBox txtLoginTokenSaltKey;
        public System.Windows.Forms.Label lblLoginTokenIvKey;
        public System.Windows.Forms.TextBox txtLoginTokenIvKey;
        public System.Windows.Forms.Label lblLoginTokenSecretKey;
        public System.Windows.Forms.TextBox txtLoginTokenSecretKey;
        public System.Windows.Forms.Label lblChannel;
        public System.Windows.Forms.TextBox txtChannel;
        public System.Windows.Forms.Label lblTransport;
        public System.Windows.Forms.TextBox txtTransport;
        public System.Windows.Forms.Label lblCustomerId;
        public System.Windows.Forms.TextBox txtCustomerId;
        public System.Windows.Forms.Button btnInstantiate;
        public System.Windows.Forms.Button btnDisconnect;
        public System.Windows.Forms.RichTextBox richTextInstantiate;
        private System.Windows.Forms.TabPage tabHighlights;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSourceHighlight;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSymbolHighlight;
        public System.Windows.Forms.DataGridView gridHighlights;
        public System.Windows.Forms.RichTextBox lstHighlight;
        public System.Windows.Forms.Label lblTipoRelatorio;
        public System.Windows.Forms.ComboBox cboTipoRelatorioHighlight;
        public System.Windows.Forms.ComboBox cboMarketHighlight;
        public System.Windows.Forms.Label lblMarketHighlight;
        public System.Windows.Forms.Label lblMaxResult;
        public System.Windows.Forms.TextBox txtMaxResultHighlight;
        public System.Windows.Forms.Button btnBuscarHighlights;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtBrokerHighlight;
        public System.Windows.Forms.CheckBox chkHighlightsSign;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtHighLightsDateTo;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtHighLightsDateFrom;
        public System.Windows.Forms.TabPage tabPostman;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cboDownloadPostman;
        public System.Windows.Forms.Button btnDownloadPostman;
        public System.Windows.Forms.RichTextBox txtDownloadPostman;
        public System.Windows.Forms.Button btnPing;
        public System.Windows.Forms.Button btnCheck;
        public System.Windows.Forms.Button btnAudit;
        public System.Windows.Forms.RichTextBox txtCheck;
        public System.Windows.Forms.RichTextBox txtPingRequest;
        public System.Windows.Forms.RichTextBox txtAudit;
        public System.Windows.Forms.RichTextBox txtInstrumentation;
        public System.Windows.Forms.Button btnInstrumentation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtAdminPwd;
        public System.Windows.Forms.TextBox txtAdminUser;
        public System.Windows.Forms.ComboBox cboInstrumentation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtPasswordInstrumentation;
        public System.Windows.Forms.TextBox txtUserInstrumentation;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtSessionStreamerIdInstrumentation;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtStreamerIdInstrumentation;
        public System.Windows.Forms.TextBox txtInstrumentationClass;
        public System.Windows.Forms.CheckBox chkInstrumentationIcase;
        public System.Windows.Forms.TextBox txtSessioninstrumentationAction;
        public System.Windows.Forms.Label lblSessionStreamerId;
        public System.Windows.Forms.Label lblSessioninstrumentationAction;
        public System.Windows.Forms.Label lblInstrumentationClass;
        private System.Windows.Forms.TabPage tabMarketSymbol;
        private System.Windows.Forms.Label lblSymbolId;
        public System.Windows.Forms.TextBox txtMarketSymbolId;
        public System.Windows.Forms.Button btnMarketSymbolInfo;
        public System.Windows.Forms.RichTextBox txtMarketSymbolInfo;
        private System.Windows.Forms.Label lblMarketSymbolSourceId;
        public System.Windows.Forms.TextBox txtMarketSymbolSourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenId;
        private System.Windows.Forms.DataGridViewButtonColumn Desassinar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.TabPage tabSendOptionExercise;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtSourceIdSendOption;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtSymbolSendOption;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtQuantitySendOption;
        public System.Windows.Forms.Label lblSignature;
        public System.Windows.Forms.TextBox txtSignatureSendOption;
        public System.Windows.Forms.CheckBox chkConfirmationSendOption;
        public System.Windows.Forms.RichTextBox txtResultSendOption;
        public System.Windows.Forms.Button btnSendOption;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtUserMneSendOption;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtUserSendOption;
        public System.Windows.Forms.ComboBox cboMarketIdSendOption;
        private System.Windows.Forms.TabPage tabProvider;
        public System.Windows.Forms.Label lblConnectionStringProvider;
        public System.Windows.Forms.TextBox txtConnectionStringProvider;
        public System.Windows.Forms.Label lblSymbolProvider;
        public System.Windows.Forms.TextBox txtSourceSymbolProvider;
        public System.Windows.Forms.Label lblQuotesTemplate;
        public System.Windows.Forms.Button btnStopProvider;
        public System.Windows.Forms.Button btnStartProvider;
        public System.Windows.Forms.TextBox txtQuotesTemplate;
        public System.Windows.Forms.RichTextBox txtProviderStatus;
        public System.Windows.Forms.Label lblProvider;
        public System.Windows.Forms.ComboBox cboProvider;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.RadioButton rbQuotesTemplate;
        public System.Windows.Forms.RadioButton rbSpaceDelimitedFile;
        public System.Windows.Forms.RadioButton rbDatabase;
        public System.Windows.Forms.Button btnSelectFileTable;
        public System.Windows.Forms.Label lblProviderTableFilePathLabel;
        public System.Windows.Forms.Label lblProviderTableFilePath;
        public System.Windows.Forms.OpenFileDialog openFileDialogProvider;
        public System.Windows.Forms.Label lblProviderColumnsFileLabel;
        public System.Windows.Forms.Button btnSelectFileColumns;
        public System.Windows.Forms.Label lblProviderColumnsFile;
        public System.Windows.Forms.TextBox txtProviderQuotesColumns;
        public System.Windows.Forms.TextBox txtProviderQuotesTable;
        public System.Windows.Forms.Label lblProviderQuotesTable;
        public System.Windows.Forms.TextBox txtProviderTemplateTable;
        public System.Windows.Forms.Label lblProviderTemplateTable;
        public System.Windows.Forms.TextBox txtProviderTemplateColumn;
        public System.Windows.Forms.Label lblProviderTemplateColumn;
        public System.Windows.Forms.TextBox txtProviderTemplateColumnFilter;
        public System.Windows.Forms.Label lblProviderTemplateColumnFilter;
        public System.Windows.Forms.TextBox txtProviderTemplateColumnFilterValue;
        public System.Windows.Forms.Label lblProviderTemplateColumnFilterValue;
        public System.Windows.Forms.TextBox txtSQLCustomFilter;
        public System.Windows.Forms.CheckBox chkSQLCustomFilter;
        public System.Windows.Forms.TextBox txtUsedTemplate;
        public System.Windows.Forms.TextBox txtProviderConfigurationColumns;
        public System.Windows.Forms.Label lblProviderConfigurationColumns;
        public System.Windows.Forms.TextBox txtProviderConfigurationSourceId;
        public System.Windows.Forms.Label lblProviderConfigurationSourceId;
        public System.Windows.Forms.GroupBox gbProviderConfigurations;
        public System.Windows.Forms.Label lblUsedTemplate;
        public System.Windows.Forms.Label lblProviderSymbolsDB;
        public System.Windows.Forms.Label lblLabelProviderSymbolsDB;
        private System.Windows.Forms.TabPage tabLoadTest;
        public System.Windows.Forms.DataGridView gridSubscriptionsLoadTest;
        public System.Windows.Forms.Label lblQttActors;
        public System.Windows.Forms.Button btnAddLoadTest;
        public System.Windows.Forms.RichTextBox txtLoadTest;
        public System.Windows.Forms.CheckBox chkSignLoadTest;
        public System.Windows.Forms.NumericUpDown numQtdAtores;
        public System.Windows.Forms.RadioButton rbTestOrder;
        public System.Windows.Forms.RadioButton rbTestQuotes;
        public System.Windows.Forms.NumericUpDown txtMillisecondsToLoopingTest;
        public System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenIdLoadTest;
        private System.Windows.Forms.DataGridViewButtonColumn UnsignLoadTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadTestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QttActors;
        private System.Windows.Forms.DataGridViewTextBoxColumn MillisecondsToRequestLooping;
    }
}

