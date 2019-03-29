using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Ynab.Net
{
    public class YnabClient
    {
        public AccessToken AccessToken { get; set; }
        public IHttpClientWrapper HttpClientWrapper { get; set; }

        public YnabClient(AccessToken token)
        {
            AccessToken = token;
            HttpClientWrapper = new HttpClientWrapper("https://api.youneedabudget.com/v1/", token.Token);
        }

        public YnabClient(AccessToken token, IHttpClientWrapper client)
        {
            AccessToken = token;
            HttpClientWrapper = client;
        }

        public string GetUser()
        {
            return HttpClientWrapper.GetUser();
        }
    }
}
