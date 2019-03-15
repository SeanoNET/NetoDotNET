using System.Net.Http;
using System.Threading.Tasks;

namespace NetoDotNET
{
    public interface IRestClient
    {
        HttpResponseMessage ExecuteRequestAsync(HttpRequestMessage requestMessage);
        HttpRequestMessage PrepareHTTPMessage(HttpMethod method, string netoAction, string body);
    }
}