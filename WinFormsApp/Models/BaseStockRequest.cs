using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp.Models
{
    public class BaseStockRequest
    {
        [Required]
        [Display(Name = "stock symbol")]
        public string stockSymbol { get; set; } = "";
        [Required]
        [Display(Name = "api key")]
        public string apiKey { get; set; } = "";
        public bool hasErrors { get; set; } = false;
        public List<string> Errors { get; set; } = new List<string>();
        internal void validate()
        {
            ValidationContext context = new ValidationContext(this, null, null);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                hasErrors = true;
                foreach (var result in results)
                {
                    Errors.Add(result.ErrorMessage);
                }
            }
        }
    }
}
