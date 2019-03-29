using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Ynab.Net
{
    public class HttpClientWrapper : IHttpClientWrapper
    {
        private HttpClient _client { get; set; }

        public HttpClientWrapper(string baseAddress, string accessToken)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.youneedabudget.com/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("Authorization", "BEARER " + accessToken);
        }

        public string GetUser()
        {
            throw new System.NotImplementedException();
        }
    }
}
