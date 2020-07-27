using NetoDotNET.Exceptions;
using NetoDotNET.Helpers;
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
            if (storeConfiguration == null)
                throw new ArgumentNullException("Must provide a store configuration.");

            this._storeConfiguration = storeConfiguration;

            if (restClient == null)
                _restClient = new RestClient(null, BuildURI(resourceEndpoint), storeConfiguration.APIkey, storeConfiguration.Username, storeConfiguration.RequestFilter, storeConfiguration.ResponseFilter);
        }

        protected Uri BuildURI(string resourceEndpoint)
        {
            if (string.IsNullOrEmpty(resourceEndpoint))
            {
                throw new ArgumentException("Resource base endpoint not found", nameof(resourceEndpoint));
            }

            return new Uri($"{_storeConfiguration.StoreUrl}{_storeConfiguration.BaseEndpoint}");
        }


        /// <summary>
        /// Prepares and executes a Http request in <see cref="IRestClient"/> from an INetoRequest <see cref="INetoRequest"/>.
        /// </summary>
        /// <param name="request"></param>
        /// <returns><see cref="NetoResponseBase"/></returns>
        public T GetResponse<T>(INetoRequest request) 
            where T : NetoResponseBase
        {
            try
            {
                // TODO: How to implement this exception throw if not valid?
                request.isValidRequest();

                var httpRequest = _restClient.PrepareHTTPMessage(HttpMethod.Post, request.NetoAPIAction, request.GetBody());

                var httpResponse = _restClient.ExecuteRequestAsync(httpRequest);

                httpResponse.EnsureSuccessStatusCode();

                var content = httpResponse.Content.ReadAsStringAsync().Result;
                var response = JsonHelper.DeSerializeNetoResponse<T>(content);
                response.ThrowOnError();
                return response;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

 

    }
}
