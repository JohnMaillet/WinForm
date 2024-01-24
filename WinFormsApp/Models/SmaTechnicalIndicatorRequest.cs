﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class SmaTechnicalIndicatorRequest
    {
        public string stockSymbol { get; set; }
        public string interval { get; set; }
        public int timePeriod { get; set; }
        public string seriesType { get; set; }
        public string apiKey { get; set; }

        public string functionName {get; }

        public SmaTechnicalIndicatorRequest(string stockSymbol = "", string apiKey = "", string interval = "", int timePeriod = 0, string seriesType = "")
        {
            this.stockSymbol = stockSymbol;
            this.interval = interval;
            this.timePeriod = timePeriod;
            this.seriesType = seriesType;
            this.apiKey = apiKey;
            this.functionName = "SMA";
        }
    }
}
