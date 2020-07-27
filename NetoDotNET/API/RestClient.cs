using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetoDotNET
{
    public class RestClient : IRestClient
    {
        private readonly HttpClient _httpClient;
        private readonly Uri _url;
        private readonly string _APIKey;
        private readonly string _username;
        private readonly Action<HttpRequestMessage> requestFilter;
        private readonly Action<HttpResponseMessage> responseFilter;



        public RestClient(HttpClient httpClient, Uri url, string APIKey, string username, Action<HttpRequestMessage> requestFilter, Action<HttpResponseMessage> responseFilter)
        {
            if (url == null)
                throw new ArgumentException("URL not specified");

            if (string.IsNullOrEmpty(APIKey))
            {
                throw new ArgumentException("API Key not specified", nameof(APIKey));
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username not specified", nameof(username));
            }

            this._httpClient = httpClient ?? new HttpClient();
            this._url = url;
            this._APIKey = APIKey;
            this._username = username;
            this.requestFilter = requestFilter;
            this.responseFilter = responseFilter;
        }
        /// <summary>
        /// Prepares the HTTP request for sending, authentication, URI and parameters 
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public HttpRequestMessage PrepareHTTPMessage(HttpMethod method, string netoAction, string body)
        {
            var requestMessage = new HttpRequestMessage();
            requestMessage.Headers.Add("NETOAPI_ACTION", netoAction);
            requestMessage.Headers.Add("NETOAPI_USERNAME", _username);
            requestMessage.Headers.Add("NETOAPI_KEY", _APIKey);
            requestMessage.Headers.Add("Accept", "application/json");
            requestMessage.Content = new StringContent(body, Encoding.UTF8, "application/json");

            requestMessage.Headers.Add("User-Agent", "NetoDotNET");

            requestMessage.RequestUri = _url;
            requestMessage.Method = method;
            return requestMessage;
        }

        /// <summary>
        /// Sends the request and handles the response
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage ExecuteRequestAsync(HttpRequestMessage requestMessage)
        {
            if (requestFilter != null)
                requestFilter.Invoke(requestMessage);

            var response = _httpClient.SendAsync(requestMessage).Result;

            if (responseFilter != null)
                responseFilter.Invoke(response);

            return response;
        }
    }
}
