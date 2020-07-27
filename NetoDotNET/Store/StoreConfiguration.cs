using System;
using System.Net.Http;

namespace NetoDotNET
{
    public class StoreConfiguration
    {
        private readonly string _storeUrl;
        private readonly string _APIkey;
        private readonly string _username;
        private readonly string _baseEndpoint;

        public string StoreUrl => _storeUrl;
        public string APIkey => _APIkey;
        public string Username => _username;
        public string BaseEndpoint => _baseEndpoint;

        public Action<HttpRequestMessage> RequestFilter { get; }
        public Action<HttpResponseMessage> ResponseFilter { get; }

        /// <summary>
        /// Your Neto store details <see cref="StoreConfiguration" />.
        /// </summary>
        /// <param name="storeUrl">The url of the Neto store https://www.my-neto-store.com.au</param>
        /// <param name="APIKey">Your Neto API Secure Key (generate this in your Neto control panel).</param>
        /// <param name="username">Your Neto API username (managed under Staff Users in the Neto control panel). Not required if using a key.</param>
        /// <param name="baseEndpoint">API base endpoint e.g /do/WS/NetoAPI</param>
        public StoreConfiguration(string storeUrl, string APIKey, string username, string baseEndpoint, Action<HttpRequestMessage> requestFilter = null, Action<HttpResponseMessage> responseFilter = null)
        {
            if (string.IsNullOrEmpty(storeUrl))
            {
                throw new ArgumentNullException("Missing Neto url.", nameof(storeUrl));
            }

            if (!Uri.IsWellFormedUriString(storeUrl, UriKind.Absolute)){
                throw new ArgumentNullException("Invalid url.", nameof(storeUrl));
            }

            if (string.IsNullOrEmpty(APIKey))
            {
                throw new ArgumentNullException("Missing Neto store API key.", nameof(APIKey));
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("Missing Neto username", nameof(username));
            }

            if (string.IsNullOrEmpty(baseEndpoint))
            {
                throw new ArgumentNullException("Missing base endpoint", nameof(baseEndpoint));
            }

            this._storeUrl = storeUrl;
            this._APIkey = APIKey;
            this._username = username;
            this._baseEndpoint = baseEndpoint;
            RequestFilter = requestFilter;
            ResponseFilter = responseFilter;
        }
    }
}
