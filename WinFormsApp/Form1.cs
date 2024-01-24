using System.Collections.Generic;
using System.Text;
using WinFormsApp.API.Services;
using WinFormsApp.Models;
using System.Windows.Forms.DataVisualization.Charting;
namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }
        private void formValidate()
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider.SetError(textBox1, "A value for the stock symbol is required");
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider.SetError(textBox2, "An API Key is required");
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            formValidate();
            if (errorProvider.HasErrors)
            {
                return;
            }
            populateBalanceSheet();

            populateSMA();
        }
        private void populateSMA()
        {
            ISmaTechnicalIndicatorService smaTechnicalIndicatorService = new SmaTechnicalIndicatorService();
            SmaTechnicalIndicatorRequest smaRequest = new SmaTechnicalIndicatorRequest()
            {
                stockSymbol = textBox1.Text,
                apiKey = textBox2.Text,
                interval = "weekly",
                timePeriod = 10,
                seriesType = "open"
            };
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
        private async void populateBalanceSheet()
        {
            BalanceSheetRequest balanceSheetRequest = new BalanceSheetRequest()
            {
                stockSymbol = textBox1.Text,
                apiKey = textBox2.Text,
            };

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

        private void tabPage2_Click(object sender, EventArgs e)
        {


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}