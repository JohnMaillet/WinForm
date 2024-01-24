using System.Collections.Generic;
using System.Text;
using WinFormsApp.API.Services;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            BalanceSheetsService balanceSheetsService = new BalanceSheetsService();
            BalanceSheets balanceSheets = await balanceSheetsService.GetBalanceSheetAsync(textBox1.Text);
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

        private void textBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int VisibleTime = 3000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("An apiKey can be requested here:\r\nhttps://www.alphavantage.co/documentation/", label, 0, 0, VisibleTime);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            //tt.Show("An apiKey can be requested here:\r\nhttps://www.alphavantage.co/documentation/", pictureBox, 0, 0);
            tt.SetToolTip(pictureBox, "An apiKey can be requested here:\r\nhttps://www.alphavantage.co/documentation/");
        }
    }
}