namespace Ynab.Net.Tests
{
    public class StubHttpClientWrapper : IHttpClientWrapper
    {
        public string GetUser()
        {
            return "{\"data\": {\"user\": {\"id\": \"some-user-id\"} } }";
        }
    }
}
