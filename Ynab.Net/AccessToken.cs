using System;

namespace Ynab.Net
{
    public class AccessToken
    {
        public string Token { get; set; }

        public AccessToken(string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
            {
                throw new ArgumentException("accessToken parameter must not be null or empty.");
            }

            Token = accessToken;
        }
    }
}
