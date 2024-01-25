using System.Collections.Generic;
using System.Text;
using WinFormsApp.API.Services;
using WinFormsApp.Models;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.ObjectModel;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        readonly Dictionary<string, TextBox> errorTypes = new Dictionary<string, TextBox>();
        
        public Form1()
        {
            InitializeComponent();
            errorTypes = new Dictionary<string, TextBox>(new Dictionary<String, TextBox> 
            {
                { "The stock symbol field is required.", textBox1 },
                { "The api key field is required.", textBox2 }
            });
        }
        private void formValidate(BalanceSheetRequest balanceSheetRequest, SmaTechnicalIndicatorRequest smaTechnicalIndicatorRequest )
        {
            errorProvider.Clear();                      
            if (balanceSheetRequest.hasErrors)
            {
                foreach(var errorMessage in errorTypes)
                {
                    if (balanceSheetRequest.Errors.Contains(errorMessage.Key))
                    {
                        errorProvider.SetError(errorMessage.Value, balanceSheetRequest.Errors.Where((x) => x == errorMessage.Key).First());
                    }
                }
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            BalanceSheetRequest balanceSheetRequest = new BalanceSheetRequest(
                stockSymbol: textBox1.Text,
                apiKey: textBox2.Text);
            SmaTechnicalIndicatorRequest smaRequest = new SmaTechnicalIndicatorRequest(
                stockSymbol: textBox1.Text,
                apiKey: textBox2.Text,
                interval: "weekly",
                timePeriod: 10,
                seriesType: "open");
            formValidate(balanceSheetRequest, smaRequest);
            if (balanceSheetRequest.hasErrors)
            {
                return;
            }
            
            populateBalanceSheet(balanceSheetRequest);
            populateSMA(smaRequest);
            if (errorProvider.HasErrors)
            {
                return;
            }
        }
        private void populateSMA(SmaTechnicalIndicatorRequest smaRequest)
        {
            ISmaTechnicalIndicatorService smaTechnicalIndicatorService = new SmaTechnicalIndicatorService();
            var response = smaTechnicalIndicatorService.GetSmaTechnicalIndicatorAsync(smaRequest);
            chart1.Series.Clear();
            var series = new Series();
            var result = response.Result;
            if (result.metaData != null)
            {
                series.Name = result.metaData.symbol;

                int count = 0;
                double max = 0;
                foreach (var data in result.technicalAnalysis)
                {
                    if (Convert.ToDouble(data.Value["SMA"]) > max)
                    {
                        max = Convert.ToDouble(data.Value["SMA"]);
                    }
                    series.Points.AddXY(count++, Convert.ToDouble(data.Value["SMA"]));
                }
                chart1.Series.Add(series);
                var area = chart1.ChartAreas[0];
                area.AxisX.Minimum = 0;
                area.AxisX.Maximum = count;
                area.AxisY.Maximum = max + 5.0;
            }
    
        }
        private async void populateBalanceSheet(BalanceSheetRequest balanceSheetRequest)
        {
            IBalanceSheetsService balanceSheetsService = new BalanceSheetsService();
            BalanceSheets balanceSheets = await balanceSheetsService.GetBalanceSheetAsync(balanceSheetRequest);
            this.treeView1.Nodes.Clear();
            TreeNode node = this.treeView1.Nodes.Add("root", $"symbol : {balanceSheets.symbol}");
            TreeNode annualReportsSubNode = node.Nodes.Add("annualReports", "annualReports");
            TreeNode quarterlyReportsSubNode = node.Nodes.Add("quarterlyReports", "quarterlyReports");
            var sb = new StringBuilder();
            appendTreeNodeToStringBuilder(balanceSheets.annualReports, annualReportsSubNode);
            appendTreeNodeToStringBuilder(balanceSheets.quarterlyReports, quarterlyReportsSubNode);
        }
        private void appendTreeNodeToStringBuilder(IEnumerable<BalanceSheet> balanceSheets, TreeNode node)
        {
            if(balanceSheets!=null)
            {
                foreach (BalanceSheet balanceSheet in balanceSheets.ToList())
                {
                    if (balanceSheet != null)
                    {
                        StringBuilder fiscalPeriodEnding = new StringBuilder();
                        TreeNode fiscaPeriodSubNode = new TreeNode();
                        foreach (var p in balanceSheet.GetType().GetProperties())
                        {
                            string value = p.GetValue(balanceSheet, null).ToString();
                            if (p.Name == "fiscalDateEnding")
                            {
                                fiscalPeriodEnding.Clear();
                                fiscalPeriodEnding.Append($"{p.Name} : {value}");
                                fiscaPeriodSubNode = node.Nodes.Add(fiscalPeriodEnding.ToString(), fiscalPeriodEnding.ToString());
                            }
                            else
                            {
                                TreeNode fiscalYear = fiscaPeriodSubNode.Nodes.Add($"{p.Name} : {value}", $"{p.Name} : {value}");
                            }
                        }
                    }
                }
            }
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pictureBox, "An apiKey can be requested here:\r\nhttps://www.alphavantage.co/documentation/");
        }
    }
}