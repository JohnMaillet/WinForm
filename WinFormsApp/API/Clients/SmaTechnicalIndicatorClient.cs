using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;
using static System.Net.WebRequestMethods;

namespace WinFormsApp.API.Clients
{
    public class SmaTechnicalIndicatorClient
    {
        private StringBuilder content = new StringBuilder();
        const string baseURL = "https://www.alphavantage.co/";        
        public SmaTechnicalIndicatorClient(SmaTechnicalIndicatorRequest smaRequest) {
            string queryParams = $"query?function={smaRequest.functionName}" +
                $"&symbol={smaRequest.stockSymbol}" +
                $"&interval={smaRequest.interval}" +
                $"&time_period={smaRequest.timePeriod}" +
                $"&series_type={smaRequest.seriesType}" +
                $"&apikey={smaRequest.apiKey}";

            var client = new RestClient(baseURL + queryParams);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode >= HttpStatusCode.OK && response.StatusCode <= HttpStatusCode.MultipleChoices)
            {
                content.Append(response.Content);
            }
            else
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
