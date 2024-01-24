using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;

namespace WinFormsApp.API.Services
{
    public interface IBalanceSheetsService
    {
        Task<BalanceSheets> GetBalanceSheetAsync(string stockSymbol);
    }
}
