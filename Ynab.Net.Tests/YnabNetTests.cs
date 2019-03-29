using System;
using System.Net.Http;
using Xunit;

namespace Ynab.Net.Tests
{
    public class YnabNetTests
    {
        [Fact]
        public void AccessToken_Constructor_SetsAccessTokenCorrectly()
        {
            string accessToken = "SomeAccessToken";
            AccessToken token = new AccessToken(accessToken);

            Assert.Equal(accessToken, token.Token);
        }

        [Fact]
        public void AccessToken_Constructor_ThrowsExceptionIfPassedEmptyOrNullAccessToken()
        {
            string accessToken = "";

            Assert.Throws<ArgumentException>(() => new AccessToken(accessToken));
        }

        [Fact]
        public void YnabClient_Constructor_SetsAccessTokenCorrectly()
        {
            AccessToken token = new AccessToken("SomeAccessToken");
            YnabClient client = new YnabClient(token);

            Assert.Equal(token, client.AccessToken);
        }

        [Fact]
        public void YnabClient_Constructor_SetsAccessTokenAndHttpClient()
        {
            AccessToken token = new AccessToken("SomeAccessToken");
            IHttpClient httpClient = new HttpClientWrapper();
            YnabClient client = new YnabClient(token, httpClient);

            Assert.Equal(token, client.AccessToken);
            Assert.Equal(httpClient, client.HttpClient);
        }
    }
}
