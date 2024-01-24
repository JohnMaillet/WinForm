using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WinFormsApp.API.Clients
{
    public class BalanceSheetClient
    {
        const string ALPHA_VANTAGE_API_KEY = "alphavantage_apiKey";
        const string BALANCE_SHEET = "BALANCE_SHEET";
        private StringBuilder content = new StringBuilder();
        public BalanceSheetClient() { }
        public BalanceSheetClient(string stockSymbol)
        {
            string apiKey = Environment.GetEnvironmentVariable(ALPHA_VANTAGE_API_KEY) ??"";
            string base_URL = $"https://www.alphavantage.co/";
            string query_params = $"query?function={BALANCE_SHEET}&symbol={stockSymbol}&apikey={apiKey}";
            RestClient client = new RestClient(base_URL + query_params);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if(response.StatusCode>=HttpStatusCode.OK && response.StatusCode <= HttpStatusCode.MultipleChoices)
            {
                content.Append(response.Content);
            } else
            {
                content.Append("{}");
            }
            
        }
        public string getContent()
        {
            return content.ToString();
        }
        
  
    }
}
