using System;

namespace NetoDotNET
{
    public class StoreConfiguration
    {
        private readonly string _storeName;
        private readonly string _APIkey;
        private readonly string _username;

        /// <summary>
        /// Create a new instance of <see cref="StoreConfiguration" />.
        /// </summary>
        /// <param name="storeName">The name of the Neto store https://www.*storeName*.com.au</param>
        /// <param name="APIKey">Your Neto API Secure Key (generate this in your Neto control panel).</param>
        /// <param name="username">Your Neto API username (managed under Staff Users in the Neto control panel). Not required if using a key.</param>
        public StoreConfiguration(string storeName, string APIKey, string username)
        {
            if (string.IsNullOrEmpty(storeName))
            {
                throw new ArgumentException("Missing Neto store name.", nameof(storeName));
            }

            if (string.IsNullOrEmpty(APIKey))
            {
                throw new ArgumentException("Missing Neto store API key.", nameof(APIKey));
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Missing Neto username", nameof(username));
            }

            this._storeName = storeName;
            this._APIkey = APIKey;
            this._username = username;
        }
    }
}
