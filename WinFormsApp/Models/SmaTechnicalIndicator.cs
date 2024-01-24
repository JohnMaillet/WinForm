using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class SmaTechnicalIndicator
    {
        [JsonProperty("Meta Data")]
        public SmaMetadata metaData { get; set; }
        [JsonProperty("Technical Analysis: SMA")]
        public Dictionary<string, Dictionary<string,string>> technicalAnalysis { get; set; }

    }
}
