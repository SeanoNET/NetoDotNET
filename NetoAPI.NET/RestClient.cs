using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetoAPI.NET
{
    public class RestClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _url;

        public RestClient(HttpClient httpClient, string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException("Please provide a valid URL");

            this._httpClient = httpClient ?? new HttpClient();
            this._url = url;
        }
        /// <summary>
        /// Prepares the HTTP request for sending, authentication, URI and parameters 
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        private HttpRequestMessage PrepareHTTPMessage(HttpMethod method) {
            var requestMessage = new HttpRequestMessage();
            requestMessage.Method = method;
            return requestMessage;
        }

        /// <summary>
        /// Sends the request and handles the response
        /// </summary>
        /// <returns></returns>
        public async Task<HttpResponseMessage> ExecuteRequestAsync(HttpRequestMessage requestMessage) {
            return await _httpClient.SendAsync(requestMessage); 
        }
    }
}
