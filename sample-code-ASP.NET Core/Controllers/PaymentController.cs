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
     
            const string userIdentifier = "";  //Your merchant account identifier
            const string password = "";    //Your merchant account password
            const string transactionPin = "";  //Your merchant account MPIN
            const string basicToken = "";
            const string headerauth = "authorization";
             


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
            Console.WriteLine(req);

             var response = await callApi.PostAsync<ResponseModel>("login", req, headerauth, basicToken);

            Console.WriteLine(response.Data);

            if (response.ResponseCode == 0)
            {
                var initrequest = new
                {
                    data = new
                    {
                        userIdentifier = userIdentifier,
                        transactionPin = transactionPin,
                        orderId = "505",   //order ID which will be provided by the merchant.
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
