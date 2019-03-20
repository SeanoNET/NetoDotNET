using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace NetoDotNET.Resources
{
    public abstract class NetoResourceBase
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

        protected abstract INetoResponse Get(NetoGetResourceFilter filter);


        /// <summary>
        /// Builds the raw GET HTTP request for <see cref="IRestClient" />.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected T GetResource<T>(INetoRequest request)
        {
            try
            {
                // TODO: How to implement this exception throw if not valid?
                request.isValidRequest();

                var httpRequest = _restClient.PrepareHTTPMessage(HttpMethod.Post, request.NetoAPIAction, request.GetBody());

                var httpResponse = _restClient.ExecuteRequestAsync(httpRequest);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var content = httpResponse.Content.ReadAsStringAsync().Result;
                    var response = DeSerializeNetoResponse<T>(content);
                    return response;
                }
                else
                {
                    throw new HttpRequestException($"Failed to get resource: {httpResponse.Content}");
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // TODO: Relocate
        private T DeSerializeNetoResponse<T>(string content)
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.DefaultValueHandling = DefaultValueHandling.Ignore;

            return JsonConvert.DeserializeObject<T>(content, settings: settings);
        }

    }
}
