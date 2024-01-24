using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class BalanceSheet
    {
        [JsonProperty("fiscalDateEnding")]
        public string fiscalDateEnding { get; set; }
        [JsonProperty("reportedCurrency")]
        public string reportedCurrency { get; set; }
        [JsonProperty("totalAssets")]
        public string totalAssets { get; set; }
        [JsonProperty("totalCurrentAssets")]
        public string totalCurrentAssets { get; set; }
        [JsonProperty("cashAndCashEquivalentsAtCarryingValue")]
        public string cashAndCashEquivalentsAtCarryingValue { get; set; }
        [JsonProperty("cashAndShortTermInvestments")]
        public string cashAndShortTermInvestments { get; set; }
        [JsonProperty("inventory")]
        public string inventory { get; set; }
        [JsonProperty("currentNetReceivables")]
        public string currentNetReceivables { get; set; }
        [JsonProperty("totalNonCurrentAssets")]
        public string totalNonCurrentAssets { get; set; }
        [JsonProperty("propertyPlantEquipment")]
        public string propertyPlantEquipment { get; set; }
        [JsonProperty("accumulatedDepreciationAmortizationPPE")]
        public string accumulatedDepreciationAmortizationPPE { get; set; }
        [JsonProperty("intangibleAssets")]
        public string intangibleAssets { get; set; }
        [JsonProperty("intangibleAssetsExcludingGoodwill")]
        public string intangibleAssetsExcludingGoodwill { get; set; }
        [JsonProperty("goodwill")]
        public string goodwill { get; set; }
        [JsonProperty("investments")]
        public string investments { get; set; }
        [JsonProperty("longTermInvestments")]
        public string longTermInvestments { get; set; }
        [JsonProperty("shortTermInvestments")]
        public string shortTermInvestments { get; set; }
        [JsonProperty("otherCurrentAssets")]
        public string otherCurrentAssets { get; set; }
        [JsonProperty("otherNonCurrentAssets")]
        public string otherNonCurrentAssets { get; set; }
        [JsonProperty("totalLiabilities")]
        public string totalLiabilities { get; set; }
        [JsonProperty("totalCurrentLiabilities")]
        public string totalCurrentLiabilities { get; set; }
        [JsonProperty("currentAccountsPayable")]
        public string currentAccountsPayable { get; set; }
        [JsonProperty("deferredRevenue")]
        public string deferredRevenue { get; set; }
        [JsonProperty("currentDebt")]
        public string currentDebt { get; set; }
        [JsonProperty("shortTermDebt")]
        public string shortTermDebt { get; set; }
        [JsonProperty("totalNonCurrentLiabilities")]
        public string totalNonCurrentLiabilities { get; set; }
        [JsonProperty("capitalLeaseObligations")]
        public string capitalLeaseObligations { get; set; }
        [JsonProperty("longTermDebt")]
        public string longTermDebt { get; set; }
        [JsonProperty("currentLongTermDebt")]
        public string currentLongTermDebt { get; set; }
        [JsonProperty("longTermDebtNoncurrent")]
        public string longTermDebtNoncurrent { get; set; }
        [JsonProperty("shortLongTermDebtTotal")]
        public string shortLongTermDebtTotal { get; set; }
        [JsonProperty("otherCurrentLiabilities")]
        public string otherCurrentLiabilities { get; set; }
        [JsonProperty("otherNonCurrentLiabilities")]
        public string otherNonCurrentLiabilities { get; set; }
        [JsonProperty("totalShareholderEquity")]
        public string totalShareholderEquity { get; set; }
        [JsonProperty("treasuryStock")]
        public string treasuryStock { get; set; }
        [JsonProperty("retainedEarnings")]
        public string retainedEarnings { get; set; }
        [JsonProperty("commonStock")]
        public string commonStock { get; set; }
        [JsonProperty("commonStockSharesOutstanding")]
        public string commonStockSharesOutstanding { get; set; }
    }
}
