using System.Threading.Tasks;

namespace Ynab.Net
{
    public interface IHttpClientWrapper
    {
        Task<string> GetUser();
    }
}
