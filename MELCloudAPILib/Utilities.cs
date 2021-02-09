using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MELCloudAPILib
{
    public class Utilities
    {
        public JObject SendHTTPRequestAsPost(object data, string url)
        {
            HttpClient _httpClient = new HttpClient();

            var content = new StringContent(JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");
          
            HttpResponseMessage result = _httpClient.PostAsync(url, content).Result;

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }

            var json = result.Content.ReadAsStringAsync().Result;
            var response = JObject.Parse(json);

            return response;
            
        }

        public JObject SendHTTPRequestAsGet(object data, string url, Dictionary<string, string> headers)
        {
            HttpClient _httpClient = new HttpClient();

            foreach (KeyValuePair<string, string> header in headers)
            {
                _httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
            }

            HttpResponseMessage result = _httpClient.GetAsync(url).Result;

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }

            var json = result.Content.ReadAsStringAsync().Result;
            var response = JObject.Parse(json);

            return response;
        }
    }
}