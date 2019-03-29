using System.Net.Http;

namespace Ynab.Net
{
    public class YnabClient
    {
        public AccessToken AccessToken { get; set; }
        public IHttpClient HttpClient { get; set; }

        public YnabClient(AccessToken token)
        {
            AccessToken = token;
            HttpClient = new HttpClientWrapper();
        }

        public YnabClient(AccessToken token, IHttpClient client)
        {
            AccessToken = token;
            HttpClient = client;
        }
    }
}
