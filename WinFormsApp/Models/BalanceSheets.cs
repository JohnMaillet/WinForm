using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class BalanceSheets
    {
        [JsonProperty("symbol")]
        public string symbol { get; set; }
        [JsonProperty("annualReports")]
        public IEnumerable<BalanceSheet> annualReports { get; set;}
        [JsonProperty("quarterlyReports")]
        public IEnumerable<BalanceSheet> quarterlyReports { get; set; }
    }
}
