using System;
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
    }
}
