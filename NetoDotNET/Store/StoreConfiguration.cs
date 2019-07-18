using System;

namespace NetoDotNET
{
    public class StoreConfiguration
    {
        private readonly string _storeName;
        private readonly string _APIkey;
        private readonly string _username;
        private readonly string _baseEndpoint;

        public string StoreName => _storeName;
        public string APIkey => _APIkey;
        public string Username => _username;
        public string BaseEndpoint => _baseEndpoint;

        /// <summary>
        /// Your Neto store details <see cref="StoreConfiguration" />.
        /// </summary>
        /// <param name="storeName">The name of the Neto store https://www.*storeName*.com.au</param>
        /// <param name="APIKey">Your Neto API Secure Key (generate this in your Neto control panel).</param>
        /// <param name="username">Your Neto API username (managed under Staff Users in the Neto control panel). Not required if using a key.</param>
        /// <param name="baseEndpoint">API base endpoint e.g /do/WS/NetoAPI</param>
        public StoreConfiguration(string storeName, string APIKey, string username, string baseEndpoint)
        {
            if (string.IsNullOrEmpty(storeName))
            {
                throw new ArgumentNullException("Missing Neto store name.", nameof(storeName));
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

            this._storeName = storeName;
            this._APIkey = APIKey;
            this._username = username;
            this._baseEndpoint = baseEndpoint;
        }
    }
}
