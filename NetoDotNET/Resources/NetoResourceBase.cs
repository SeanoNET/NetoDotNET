using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace NetoDotNET.Resources
{
     public abstract class NetoResourceBase<T>
    {
        private readonly StoreConfiguration _storeConfiguration;
        private readonly IRestClient _restClient;

        public NetoResourceBase(StoreConfiguration storeConfiguration, string resourceEndpoint, IRestClient restClient)
        {       
            this._storeConfiguration = storeConfiguration;

            if (restClient == null)
                _restClient = new RestClient(null, BuildURI(resourceEndpoint), storeConfiguration.APIkey, storeConfiguration.Username);
        }
        
        protected Uri BuildURI(string resourceEndpoint)
        {
            if (string.IsNullOrEmpty(resourceEndpoint))
            {
                throw new ArgumentException("Resource base endpoint not found", nameof(resourceEndpoint));
            }

            return new Uri($"https://{_storeConfiguration.StoreName}.neto.com.au{_storeConfiguration.BaseEndpoint}");
        }

        protected abstract string Get(INetoFilter filter);


        /// <summary>
        /// Builds the raw GET HTTP request for <see cref="IRestClient" />.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected NetoResponse GetResource(NetoRequest request) {

            var httpRequest = _restClient.PrepareHTTPMessage(HttpMethod.Post, request.NetoAPIAction, request.Body);

            var httpResponse = _restClient.ExecuteRequestAsync(httpRequest);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content =  httpResponse.Content.ReadAsStringAsync().Result;
                return new NetoResponse(content);
            }
            else {
                throw new HttpRequestException($"Failed to get resource: {httpResponse.Content}");
            }



            
        }

    }
}
