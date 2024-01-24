using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;

namespace WinFormsApp.API.Services
{
    internal interface ISmaTechnicalIndicatorService
    {
        Task<SmaTechnicalIndicator> GetSmaTechnicalIndicatorAsync(SmaTechnicalIndicatorRequest smaTechnicalIndicatorRequest);
    }
}
