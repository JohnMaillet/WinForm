using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class SmaMetadata
    {
        [JsonProperty("1: Symbol")]
        public string symbol { get; set; }
        [JsonProperty("2: Indicator")]
        public string indicator { get; set; }
        [JsonProperty("3: Last Refreshed")]
        public string lastRefreshed { get; set; }
        [JsonProperty("4: Interval")]
        public string interval { get; set; }
        [JsonProperty("5: Time Period")]
        public int timePeriod { get; set; }
        [JsonProperty("6: Series Type")]
        public string seriesType { get; set; }
        [JsonProperty("7: Time Zone")]
        public string timeZone { get; set; }
    }
}
