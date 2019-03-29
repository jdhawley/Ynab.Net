using System;
using System.Net.Http;
using Xunit;
using Ynab.Net.Models;

namespace Ynab.Net.Tests
{
    public class YnabNetTests
    {
        public string TokenString { get; set; }
        public AccessToken AccessToken { get; set; }
        public YnabClient YnabClient { get; set; }
        public IHttpClientWrapper HttpClientWrapper { get; set; }

        public YnabNetTests()
        {
            TokenString = "SomeAccessToken";
            AccessToken = new AccessToken(TokenString);
            YnabClient = new YnabClient(AccessToken);
            HttpClientWrapper = YnabClient.HttpClientWrapper;
        }

        [Fact]
        public void AccessToken_Constructor_SetsAccessTokenCorrectly()
        {
            Assert.Equal(TokenString, AccessToken.Token);
        }

        [Fact]
        public void AccessToken_Constructor_ThrowsExceptionIfPassedEmptyOrNullAccessToken()
        {
            string accessToken = "";

            Assert.Throws<ArgumentException>(() => new AccessToken(accessToken));
        }

        [Fact]
        public void YnabClient_Constructor_SetsAccessTokenAndHttpClient()
        {
            Assert.Equal(AccessToken, YnabClient.AccessToken);
            Assert.Equal(HttpClientWrapper, YnabClient.HttpClientWrapper);
        }

        [Fact]
        public void YnabClient_GetUser_ReturnsUser()
        {
            YnabClient.HttpClientWrapper = new StubHttpClientWrapper();
            string user = YnabClient.GetUser();

            //TODO: Make this test mean something.
            Assert.NotNull(user);
            Assert.NotEmpty(user);
        }
    }
}
