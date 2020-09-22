using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public abstract class BaseClient
    {
        private HttpClient _client { get; }

        protected BaseClient(HttpClient client)
        {
            _client = client;
        }

        public void changeBaseUrl(string baseUrl)
        {
            _client.BaseAddress = new Uri(baseUrl);
        }

        private async Task<byte[]> GetByteArray(string url, Dictionary<string, string> parameters)
        {
            var path = "";
            if (parameters.Count > 0)
            {
                path = "?";
                var parameterStrings = new List<string>();
                foreach (var parameter in parameters)
                {
                    parameterStrings.Add(parameter.Key + "=" + parameter.Value);
                }

                path += string.Join("&", parameterStrings);
            }


            using (var response = await _client.GetAsync(url + path))
            {
                var inputStream = await response.Content.ReadAsByteArrayAsync();
                return inputStream;
            }
        }


        private async Task<byte[]> PostByteArray(string url, dynamic request)
        {

            var content = new StringContent(JsonConvert.SerializeObject(request), UnicodeEncoding.UTF8, "application/json");

            using (var response = await _client.PostAsync(url, content))
            {
                var inputStream = await response.Content.ReadAsByteArrayAsync();
                return inputStream;
            }

        }


        public async Task<T> GetObject<T>(string url, Dictionary<string, string> parameters)
        {
            var byteArray = await GetByteArray(url, parameters);
            var jsonStr = Encoding.UTF8.GetString(byteArray);

            try
            {
                return JsonConvert.DeserializeObject<T>(jsonStr);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public async Task<T> PostObject<T>(string url, dynamic request)
        {
            var byteArray = await PostByteArray(url, request);
            var jsonStr = Encoding.UTF8.GetString(byteArray);

            return JsonConvert.DeserializeObject<T>(jsonStr);
        }
    }
}
