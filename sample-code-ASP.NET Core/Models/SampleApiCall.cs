using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using Microsoft.AspNetCore.Components.RenderTree;
using System.Text;
using Newtonsoft.Json.Linq;

namespace sample_code_ASP.NET_Core.Models
{
    public class SampleApiCall
    {
      

        #region Ctor
        public SampleApiCall()
        {


        }
        #endregion

        #region Methods


        public async Task<T> PostAsync<T>(Uri baseAddres ,string apiMethod, object model, string headerauth, string headerauthvalue)
        {
            try
            {
                //Create Request      

                HttpClient _client = new HttpClient();
                _client.BaseAddress = baseAddres;
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _client.DefaultRequestHeaders.Add(headerauth,headerauthvalue);
                _client.Timeout = TimeSpan.FromMinutes(1000);
  


                //Call Api
                


                HttpResponseMessage responseMessage = null;
                
                 

                responseMessage = await _client.PostAsJsonAsync(apiMethod, model);                 

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