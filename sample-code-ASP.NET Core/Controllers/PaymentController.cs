using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sample_code_ASP.NET_Core.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;


namespace sample_code_ASP.NET_Core.Controllers
{
        
    public class PaymentController : Controller
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> callAPI()
        {
     
            const string userIdentifier = "7500077974";  //Your merchant account identifier
            const string password = "Nass@2020";    //Your merchant account password
            const string transactionPin = "135758";  //Your merchant account MPIN
            const string basicToken = "TUVSQ0hBTlRfUEFZTUVOVF9HQVRFV0FZOk1lcmNoYW50R2F0ZXdheUBBZG1pbiMxMjM=";
            const string headerauth = "Basic";
             


            SampleApiCall callApi = new SampleApiCall();

            var request = new
            {
                data = new
                {
                    username = userIdentifier,
                    password = password,
                    grantType = "password"

                }
            };
            

            var req = JsonConvert.SerializeObject(request);
           
             var response = await callApi.PostAsync<ResponseModel>("login", request, headerauth, basicToken);

            if (response.ResponseCode == 0)
            {
                var initrequest = new
                {
                    data = new
                    {
                        userIdentifier = userIdentifier,
                        transactionPin = transactionPin,
                        orderId = "263626",   //order ID which will be provided by the merchant.
                        amount = "10",  //order amount/price will be provided by the merchant.
                        languageCode = "en",  
                    }
                };
                dynamic datavalues = JObject.Parse(response.Data.ToString());
                string bearertoken = datavalues.access_token;
                var initresponse = await callApi.PostAsync<ResponseModel>("initTransaction", initrequest, "Bearer", bearertoken);
                if (initresponse.ResponseCode == 0)
                {
                    dynamic transactionValues = JObject.Parse(initresponse.Data.ToString());
                    string txn_id = transactionValues.transactionId;
                    string txn_token = transactionValues.token;
                    string urltoRedirect = "https://uatcheckout1.nasswallet.com/payment-gateway?id=" + txn_id + "&token=" + txn_token + "&userIdentifier=" + userIdentifier;
                     return Json(urltoRedirect);

                }
                return Json(initresponse.Data);
            }
            return Json(response.Data);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
