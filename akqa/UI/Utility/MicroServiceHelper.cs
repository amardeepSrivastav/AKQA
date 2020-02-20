using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace UI.Utility
{
    public static class MicroServiceHelper
    {
        public static  T  GetAsyncSingle<T>(string baseURL, string apiCall) where T : new()
        {
            using (var client = new HttpClient())
            {
                T retVal = new T();
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response =  client.GetAsync(apiCall).Result;

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    retVal = JsonConvert.DeserializeObject<T>(result);
                }
                return retVal;

            }

        }
    }
}