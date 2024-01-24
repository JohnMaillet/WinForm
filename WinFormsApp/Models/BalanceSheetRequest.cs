using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class BalanceSheetRequest
    {
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 1, ErrorMessage ="Stock Symbol must be larger than one character")]
        public string stockSymbol { get; set; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 1, ErrorMessage = "API Key must be larger than one character")]
        public string apiKey { get; set; }
        public BalanceSheetRequest (string stockSymbol = "", string apiKey = "")
        {
            this.stockSymbol = stockSymbol;
            this.apiKey = apiKey;
        }
    }
}
