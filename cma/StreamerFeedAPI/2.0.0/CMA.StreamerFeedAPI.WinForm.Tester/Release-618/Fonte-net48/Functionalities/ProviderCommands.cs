using CMA.StreamerFeed.Models.V1.Marketdata.Quotes;
using CMA.StreamerFeed.Models.V1.Provider;
using CMA.StreamerFeed.Standard.API.Models.V1.Provider;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reactive.Linq;

namespace CMA.StreamerFeedAPI.WinForm.Tester.Functionalities
{
    public class ProviderCommands
    {
        private WinFormAPITester.frmWinFormAPITester frm;
        public CancellationTokenSource cancellationTokenSource { get; set; }

        public ProviderCommands(WinFormAPITester.frmWinFormAPITester frm)
        {
            this.frm = frm;
        }

        #region Events
        public void FillControls()
        {
            List<string> alltypes = Enum.GetNames(typeof(ProviderType)).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = alltypes;
            frm.cboProvider.DataSource = bs;
            frm.cboProvider.Text = "MySQL";
            frm.btnStopProvider.Enabled = false;
            frm.rbQuotesTemplate.Checked = true;
        }

        public void btnSelectFile_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            frm.openFileDialogProvider.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            frm.openFileDialogProvider.Title = "Selecione o arquivo.";
            //which type file format you want to upload in database. just add them.
            //frm.openFileDialogProvider.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html)|*.pdf; *.docx; *.xlsx; *.html";
            frm.openFileDialogProvider.Filter = "Selecione o arquivo table.txt válido |table.txt";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            frm.openFileDialogProvider.FilterIndex = 1;
            try
            {
                if (frm.openFileDialogProvider.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.openFileDialogProvider.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(frm.openFileDialogProvider.FileName);
                        string[] filelines = File.ReadAllLines(path);

                        if (filelines?.Any() != true)
                        {
                            MessageBox.Show("Por favor, selecione um documento válido.");
                        }
                        else
                        {
                            frm.lblProviderTableFilePath.Text = String.Join(", ", filelines.Select(f => f.Trim().Replace(",", "|")));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um documento válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void btnSelectFileColumns_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            frm.openFileDialogProvider.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            frm.openFileDialogProvider.Title = "Selecione o arquivo.";
            //which type file format you want to upload in database. just add them.
            //frm.openFileDialogProvider.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html)|*.pdf; *.docx; *.xlsx; *.html";
            frm.openFileDialogProvider.Filter = "Selecione o arquivo columns.txt válido |columns.txt";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            frm.openFileDialogProvider.FilterIndex = 1;
            try
            {
                if (frm.openFileDialogProvider.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.openFileDialogProvider.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(frm.openFileDialogProvider.FileName);
                        string[] filelines = File.ReadAllLines(path);

                        if (filelines?.Any() != true)
                        {
                            MessageBox.Show("Por favor, selecione um documento válido.");
                        }
                        else
                        {
                            frm.lblProviderColumnsFile.Text = String.Join(" | ", filelines.Where(f => f.Split(',')?.Count() > 2).Select(f => f.Split(',')[2].Trim()));
                            frm.txtProviderQuotesColumns.Text = String.Join(" | ", filelines.Where(f => f.Split(',')?.Count() > 2));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um documento válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void rbQuotesTemplate_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = frm.rbQuotesTemplate.Checked;

            frm.lblSymbolProvider.Visible = isChecked;
            frm.txtSourceSymbolProvider.Visible = isChecked;
            frm.lblQuotesTemplate.Visible = isChecked;
            frm.txtQuotesTemplate.Visible = isChecked;
        }

        public void rbSpaceDelimitedFile_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = frm.rbSpaceDelimitedFile.Checked;

            frm.btnSelectFileTable.Visible = isChecked;
            frm.lblProviderTableFilePathLabel.Visible = isChecked;
            frm.lblProviderTableFilePath.Visible = isChecked;
            frm.btnSelectFileColumns.Visible = isChecked;
            frm.lblProviderColumnsFileLabel.Visible = isChecked;
            frm.lblProviderColumnsFile.Visible = isChecked;
            frm.lblProviderQuotesTable.Visible = isChecked;
            frm.txtProviderQuotesTable.Visible = isChecked;

            //Configurations
            frm.gbProviderConfigurations.Visible = isChecked;
            frm.txtProviderConfigurationColumns.Visible = isChecked;
            frm.txtProviderConfigurationSourceId.Visible = isChecked;
            frm.lblProviderConfigurationColumns.Visible = isChecked;
            frm.lblProviderConfigurationSourceId.Visible = isChecked;
            frm.lblProviderSymbolsDB.Visible = isChecked;
            frm.lblLabelProviderSymbolsDB.Visible = isChecked;

        }

        public void rbDatabase_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = frm.rbDatabase.Checked;

            frm.lblProviderTemplateTable.Visible = isChecked;
            frm.txtProviderTemplateTable.Visible = isChecked;
            frm.lblProviderTemplateColumn.Visible = isChecked;
            frm.txtProviderTemplateColumn.Visible = isChecked;
            frm.lblProviderTemplateColumnFilter.Visible = isChecked;
            frm.txtProviderTemplateColumnFilter.Visible = isChecked;
            frm.lblProviderTemplateColumnFilterValue.Visible = isChecked;
            frm.txtProviderTemplateColumnFilterValue.Visible = isChecked;
            frm.txtSQLCustomFilter.Visible = isChecked;
            frm.txtSQLCustomFilter.Enabled = frm.chkSQLCustomFilter.Checked;
            frm.chkSQLCustomFilter.Visible = isChecked;
            frm.lblSymbolProvider.Visible = isChecked;
            frm.txtSourceSymbolProvider.Visible = isChecked;
            frm.txtUsedTemplate.Visible = isChecked;
            frm.lblUsedTemplate.Visible = isChecked;
        }

        public void chkSQLCustomFilter_CheckedChanged(object sender, EventArgs e)
        {
            frm.lblProviderTemplateColumnFilter.Enabled = !frm.chkSQLCustomFilter.Checked;
            frm.txtProviderTemplateColumnFilter.Enabled = !frm.chkSQLCustomFilter.Checked;
            frm.lblProviderTemplateColumnFilterValue.Enabled = !frm.chkSQLCustomFilter.Checked;
            frm.txtProviderTemplateColumnFilterValue.Enabled = !frm.chkSQLCustomFilter.Checked;
            frm.txtSQLCustomFilter.Enabled = frm.chkSQLCustomFilter.Checked;
        }

        public void btnStartProvider_Click(object sender, EventArgs e)
        {
            if (Uteis.GetHealthCheckStatus(frm) == false)
            {
                return;
            }

            frm.txtProviderStatus.Text = "Provider Iniciado";

            cancellationTokenSource = null;

            cancellationTokenSource = new CancellationTokenSource();

            frm.btnStartProvider.Enabled = false;
            frm.btnStopProvider.Enabled = true;

            // Parametriza cotação
            List<QuotesParam> quotesParamList = new List<QuotesParam>();

            string[] strSourceSymbols;

            var param = new ProviderParam()
            {
                ConnectionString = frm.txtConnectionStringProvider.Text,
                ProviderType = (ProviderType)Enum.Parse(typeof(ProviderType), (string)frm.cboProvider.SelectedItem), //Expor na tela
                Quotes = quotesParamList,
                //QuotesTemplate = frm.txtQuotesTemplate.Text,
                EnableTrace = frm.chkEnableTrace.Checked,
                Referer = DateTime.Now
            };

            if (frm.rbQuotesTemplate.Checked)
                param.QuotesTemplate = frm.txtQuotesTemplate.Text;
            else if (frm.rbSpaceDelimitedFile.Checked)
                param.QuotesTemplate = GetTemplateFromFile();
            else if (frm.rbDatabase.Checked)
                param.QuotesTemplate = GetTemplateFromDB(param);

            if (string.IsNullOrEmpty(param.QuotesTemplate))
            {
                frm.txtProviderStatus.Text += "\n\nNão foi possível obter o Template";

                return;
            }

            if (frm.rbQuotesTemplate.Checked || frm.rbDatabase.Checked)
                strSourceSymbols = frm.txtSourceSymbolProvider.Text.Trim().Split(',');
            else if (frm.rbSpaceDelimitedFile.Checked)
            {
                string[] symbolsFromDbConfig = GetSymbolsFromDbConfig(param) ?? new string[0];

                if (symbolsFromDbConfig.Count() > 0)
                    symbolsFromDbConfig = symbolsFromDbConfig.Select(s => frm.txtProviderConfigurationSourceId.Text + "|" + s).ToArray();

                strSourceSymbols = symbolsFromDbConfig.Union(frm.lblProviderTableFilePath.Text.Trim().Split(',')).Distinct().ToArray();
            }
            else
                strSourceSymbols = new string[0];

            foreach (var strSourceSymbol in strSourceSymbols.Where(s => !string.IsNullOrEmpty(s) && s.Trim() != "?"))
            {
                string[] splitedSourceSymbol = strSourceSymbol.Split('|');

                if (splitedSourceSymbol.Count() < 2)
                {
                    frm.txtProviderStatus.Text += "\n\nSourceId e SymbolId são obrigatórios";

                    return;
                }

                QuotesParam quotesParam = new QuotesParam();
                quotesParam.SourceID = splitedSourceSymbol[0].Trim();
                quotesParam.SymbolID = splitedSourceSymbol[1].Trim();
                quotesParam.EnableTrace = frm.chkEnableTrace.Checked;
                quotesParam.Referer = DateTime.Now;

                quotesParamList.Add(quotesParam);
            }

            Task.Run(() =>
            {
                // Iniciar/Alterar Provider
                frm.cmaStreamerFeed.ProviderControll(param, cancellationTokenSource.Token).Subscribe(statusResult =>
                {
                    frm.Invoke(new MethodInvoker(delegate
                    {
                        frm.txtProviderStatus.Text += "\n\n" + JsonConvert.SerializeObject(statusResult);
                        if (!statusResult.Success)
                        {
                            btnStopProvider_Click(sender, e);
                        }
                    }));
                }); ;
            });
        }

        public void btnStopProvider_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                frm.Invoke(new MethodInvoker(delegate
                {
                    if (cancellationTokenSource != null)
                        try
                        {
                            cancellationTokenSource.Cancel(true);
                        }
                        catch (Exception ex)
                        {
                            frm.txtProviderStatus.Text += "\n\nProblema ao tentar cancelar a subscrição!";
                        }

                    frm.btnStartProvider.Enabled = true;
                    frm.btnStopProvider.Enabled = false;
                }));
            });
        }
        #endregion

        #region Methods

        private string[] GetSymbolsFromDbConfig(ProviderParam param)
        {
            if (string.IsNullOrEmpty(frm.txtProviderConfigurationColumns.Text) || string.IsNullOrEmpty(frm.txtProviderQuotesTable.Text))
            {
                frm.txtProviderStatus.Text += "Não foi possível trazer informações dos Ativos Configurados na Base de dados. Tabela e Colunas precisam ser configuradas para isso.";
                return new string[0];
            }

            string[] symbols = frm.cmaStreamerFeed.GetSymbolsFromDbConfig(new ProviderSymbolsInDBParam()
            {
                ConnectionString = param.ConnectionString,
                ProviderType = param.ProviderType,
                Table = frm.txtProviderQuotesTable.Text,
                Columns = frm.txtProviderConfigurationColumns.Text
            }).Wait().Result?.Where(s => !string.IsNullOrEmpty(s)).ToArray();

            frm.lblLabelProviderSymbolsDB.Text = "Ativos habilitados na BD: " + string.Join("|", symbols);

            return symbols;
        }

        //TODO: Levar inteligência de geração de template para a API e expôr método
        private string GetTemplateFromFile()
        {
            if (frm.txtProviderQuotesColumns.Text == "")
            {
                frm.txtProviderStatus.Text += "\n\nInforme as colunas a serem preenchidas!";

                return "";
            }
            var columns = frm.txtProviderQuotesColumns.Text.Split('|');
            string columnsToInsert = String.Join(", ", columns.Where(f => f.Split(',').Length > 2).Select(f => f.Split(',')[2].Trim()));
            var providerType = (ProviderType)Enum.Parse(typeof(ProviderType), (string)frm.cboProvider.SelectedItem);
            string template = "";
            string[] splitedConfigColumns = frm.txtProviderConfigurationColumns.Text.Split(';');
            string COD_COL = splitedConfigColumns.FirstOrDefault(s => s.Contains("COD_COL:")).Replace("COD_COL:", "").Trim();
            string DTM_COL = splitedConfigColumns.FirstOrDefault(s => s.Contains("DTM_COL:")).Replace("DTM_COL:", "").Trim();

            switch (providerType)
            {
                case ProviderType.MSSQLServer:
                    template =
                        "{% for q in Model %}" +
                            $" UPDATE {frm.txtProviderQuotesTable.Text.Trim()} SET {DTM_COL}=GETDATE(),{MapQuotesToFluidFields(columns, true)}" +
                            $" WHERE {COD_COL}='{{{{q.Data.Symbol.SymbolID}}}}'" +
                            $" IF @@ROWCOUNT=0 INSERT INTO {frm.txtProviderQuotesTable.Text.Trim()}({COD_COL},{DTM_COL},{columnsToInsert})" +
                            $" VALUES('{{{{q.Data.Symbol.SymbolID}}}}',GETDATE(),{MapQuotesToFluidFields(columns)}) " +
                        "{% endfor %}";
                    break;
                case ProviderType.MySQL:
                    template =
                        "{% for q in Model %}" +
                            $" INSERT INTO {frm.txtProviderQuotesTable.Text.Trim()}({COD_COL},{DTM_COL},{columnsToInsert})" +
                            $" VALUES('{{{{q.Data.Symbol.SymbolID}}}}',NOW(),{MapQuotesToFluidFields(columns)})" +
                            $" ON DUPLICATE KEY UPDATE {DTM_COL}=NOW(),{MapQuotesToFluidFields(columns, true)}; " +
                        "{% endfor %}";
                    break;
                case ProviderType.Oracle:
                    template =
                        "BEGIN {% for q in Model %}" +
                            $" UPDATE {frm.txtProviderQuotesTable.Text.Trim()} SET {DTM_COL}=SYSDATE,{MapQuotesToFluidFields(columns, true)}" +
                            $" WHERE ATV_CODIGO='{{{{q.Data.Symbol.SymbolID}}}}';" +
                            $" IF (SQL%ROWCOUNT=0) THEN INSERT INTO {frm.txtProviderQuotesTable.Text.Trim()}({COD_COL},{DTM_COL},{columnsToInsert})" +
                            $" VALUES('{{{{q.Data.Symbol.SymbolID}}}}',SYSDATE,{MapQuotesToFluidFields(columns)}); " +
                            $" END IF;" +
                        "{% endfor %} END; ";
                    break;
                default:
                    break;
            }

            return template;
        }

        private string GetTemplateFromDB(ProviderParam param)
        {
            string usedTemplate = frm.cmaStreamerFeed.GetTemplate(new ProviderTemplateParam()
            {
                ConnectionString = param.ConnectionString,
                ProviderType = param.ProviderType,
                Table = frm.txtProviderTemplateTable.Text,
                Column = frm.txtProviderTemplateColumn.Text,
                FilterColumn = frm.txtProviderTemplateColumnFilter.Text,
                FilterValue = frm.txtProviderTemplateColumnFilterValue.Text,
                UseCustomSQLFilter = frm.chkSQLCustomFilter.Checked,
                CustomSQLFilter = frm.txtSQLCustomFilter.Text
            }).Wait().Result;

            frm.txtUsedTemplate.Text = usedTemplate;

            return usedTemplate;
        }

        private string MapQuotesToFluidFields(string[] columns, bool isUpdate = false)
        {
            //exemplos de retorno: 
            //Insert => '{{q.Data.Symbol.SymbolID}}', '{{q.Data.LastTradePrice}}', '{{q.Data.LastTradeQty}}', '{{q.Data.Change}}', '{{q.Data.Tendency}}', '{{q.Data.LastTradeTime}}'";
            //Update => ATV_DES_VOL='{{q.Data.Volume}}',ATV_DES_VAR='{{q.Data.Change}}',ATV_DES_AJU='{{q.Data.QuoteFactor}}',ATV_DES_ULT='{{q.Data.LastTradePrice}}',ATV_DES_MAX='{{q.Data.HighPrice}}',ATV_DES_MIN='{{q.Data.LowPrice}}',ATV_DES_ABE='{{q.Data.OpenPrice}}',ATV_DES_FEC='{{q.Data.PrevClosePrice}}',ATV_DES_QUL='{{q.Data.LastTradeQty}}',ATV_DES_NEG='{{q.Data.TradesCount}}',ATV_DES_MED='{{q.Data.AvgPrice}}',ATV_DES_HOR='{{q.Data.LastTradeTime}}

            var quotesFieldIds = columns.Where(f => f.Split(',').Length > 2).Select(f => f.Split(',')[0].Trim().PadLeft(2, '0')).ToList();
            var columnWith3Fields = columns.Where(f => f.Split(',').Length > 2).ToList();
            string strFluidFields = "";
            string fieldToAdd;

            foreach (string quotesFieldId in quotesFieldIds)
            {
                fieldToAdd = "";

                if (!String.IsNullOrEmpty(strFluidFields)) strFluidFields += ",";

                switch (quotesFieldId)
                {
                    case "00":
                        fieldToAdd += "'{{q.Data.Volume}}'";
                        break;

                    case "01":

                        fieldToAdd += "'{{q.Data.Change}}'";
                        break;

                    case "02":

                        fieldToAdd += "'{{q.Data.BidBestOfferNumber}}'";
                        break;

                    case "03":

                        fieldToAdd += "'{{q.Data.AskBestOfferNumber}}'";
                        break;

                    case "04":

                        fieldToAdd += "'{{q.Data.BidBestOfferBroker}}'";
                        break;

                    case "05":

                        fieldToAdd += "'{{q.Data.AskBestOfferBroker}}'";
                        break;

                    case "06":

                        fieldToAdd += "'{{q.Data.BidBestOfferQty}}'";
                        break;

                    case "07":

                        fieldToAdd += "'{{q.Data.AskBestOfferQty}}'";
                        break;

                    case "08":

                        fieldToAdd += "'{{q.Data.ExecPrice}}'";
                        break;

                    case "09":

                        fieldToAdd += "'{{q.Data.ExecDate}}'";
                        break;

                    case "10":

                        fieldToAdd += "'{{q.Data.StockLength}}'";
                        break;

                    case "11":

                        fieldToAdd += "'{{q.Data.Return}}'";
                        break;

                    case "12":

                        fieldToAdd += "'{{q.Data.QuoteFactor}}'";
                        break;

                    case "13":

                        fieldToAdd += "'{{q.Data.Workday}}'";
                        break;

                    case "14":

                        fieldToAdd += "'{{q.Data.CalendarDays}}'";
                        break;

                    case "16":

                        fieldToAdd += "'{{q.Data.LastTradePrice}}'";
                        break;

                    case "17":

                        fieldToAdd += "'{{q.Data.ClosePrice}}'";
                        break;

                    case "20":

                        fieldToAdd += "'{{q.Data.BidPrice}}'";
                        //fieldToAdd += "'{{q.Data.AuctionBid}}'";?????
                        //quoteResult.BidPrice = ParserReplacingLastCharacter(quoteValue);
                        //quoteResult.AuctionBid = quoteValue[quoteValue.Length - 1] == '*'; // Preço com * indica leilão
                        break;

                    case "21":

                        fieldToAdd += "'{{q.Data.AskPrice}}'";
                        //fieldToAdd += "'{{q.Data.AuctionAsk}}'";
                        //quoteResult.AskPrice = ParserReplacingLastCharacter(quoteValue);
                        //quoteResult.AuctionAsk = quoteValue[quoteValue.Length - 1] == '*'; // Preço com * indica leilão
                        break;

                    case "22":

                        fieldToAdd += "'{{q.Data.HighPrice}}'";
                        break;

                    case "23":

                        fieldToAdd += "'{{q.Data.LowPrice}}'";
                        break;

                    case "24":

                        fieldToAdd += "'{{q.Data.OpenPrice}}'";
                        break;

                    case "25":

                        fieldToAdd += "'{{q.Data.CumulativeQuantity}}'";
                        break;

                    case "26":

                        fieldToAdd += "'{{q.Data.PrevClosePrice}}'";
                        break;

                    case "27":

                        fieldToAdd += "'{{q.Data.OpenContracts}}'";
                        break;

                    case "28":

                        fieldToAdd += "'{{q.Data.LastTradeQty}}'";
                        break;

                    case "29":

                        fieldToAdd += "'{{q.Data.AskQty}}'";
                        break;

                    case "30":

                        fieldToAdd += "'{{q.Data.BidQty}}'";
                        break;

                    case "31":

                        fieldToAdd += "'{{q.Data.Tendency}}'";
                        break;

                    case "34":

                        fieldToAdd += "'{{q.Data.TradesCount}}'";
                        break;

                    case "35":

                        fieldToAdd += "'{{q.Data.AvgPrice}}'";
                        break;

                    case "36":

                        fieldToAdd += "'{{q.Data.LastTradeTime}}'";
                        break;

                    case "38":

                        fieldToAdd += "'{{q.Data.LastDifferential}}'";
                        break;

                    case "39":

                        fieldToAdd += "'{{q.Data.MonthsChange}}'";
                        break;

                    case "40":

                        fieldToAdd += "'{{q.Data.LastTradeDate}}'";
                        break;

                    case "41":

                        fieldToAdd += "'{{q.Data.MonthChange}}'";
                        break;

                    case "42":

                        fieldToAdd += "'{{q.Data.YearChange}}'";
                        break;

                    case "125":

                        fieldToAdd += "'{{q.Data.Status}}'";
                        break;

                    case "132":

                        //quoteItem.Uknwn1 = this.Uknwn1 = quoteValue;
                        break;

                    case "133":

                        //quoteItem.Uknwn2 = this.Uknwn2 = quoteValue;
                        break;

                    //Campo 81 no de/para da API. Precisa corrigir??????
                    case "129":

                        fieldToAdd += "'{{q.Data.Workday}}'";
                        break;

                    //Campo 80 no de/para da API. Precisa corrigir??????
                    case "128":

                        fieldToAdd += "'{{q.Data.CalendarDays}}'";
                        break;

                    //Campo 6C no de/para da API. Precisa corrigir??????
                    case "108":

                        fieldToAdd += "'{{q.Data.RemainingDaysToDue}}'";
                        break;

                    default:
                        fieldToAdd += "''";
                        break;

                }

                if (isUpdate)
                {
                    string column = columnWith3Fields.FirstOrDefault(f => f.Split(',')[0].Trim().PadLeft(2, '0') == quotesFieldId);
                    strFluidFields += $"{column.Split(',')[2].Trim()}={fieldToAdd}";
                }
                else
                    strFluidFields += fieldToAdd;
            }

            return strFluidFields;
        }
        #endregion
    }
}
