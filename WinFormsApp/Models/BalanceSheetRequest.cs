using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class BalanceSheetRequest: BaseStockRequest
    {

        public BalanceSheetRequest(string stockSymbol, string apiKey)
        {
            this.stockSymbol = stockSymbol;
            this.apiKey = apiKey;
            this.validate();
        }
    }
}
