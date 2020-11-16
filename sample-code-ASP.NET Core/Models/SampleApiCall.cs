using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http.Formatting;

namespace sample_code_ASP.NET_Core.Models
{
    public class SampleApiCall
    {
        private string _baseUrl = "https://uatgw.nasswallet.com";

        #region Ctor
        public SampleApiCall()
        {


        }
        #endregion

        #region Methods


        public async Task<T> PostAsync<T>(string apiMethod, object model, string headerauth, string headerauthvalue)
        {
            try
            {
                //Create Request
                Uri _baseUrlUri = new Uri(_baseUrl);    
                HttpClient _client = new HttpClient();
                _client.BaseAddress = _baseUrlUri;
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _client.DefaultRequestHeaders.Add("Authorization", headerauth + " " + headerauthvalue);
                _client.Timeout = TimeSpan.FromMinutes(10);

                //Format Url
                string url = string.Empty;
                url = _baseUrl + "/payment/transaction/" + apiMethod;
                            
                //Call Api
                HttpResponseMessage responseMessage = null;
                responseMessage = await _client.PostAsJsonAsync(url, model);

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                    var apiData = JsonConvert.DeserializeObject<T>(responseData);
                    return apiData;
                }
                else
                {
                    var obj = (T)Activator.CreateInstance(typeof(T));
                    return obj;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}

public class ResponseModel
{
    public int ResponseCode { get; set; }
    public int ErrCode { get; set; }
    public string Message { get; set; }
    public object Data { get; set; }
}