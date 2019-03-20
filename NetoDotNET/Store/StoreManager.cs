using NetoDotNET.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET
{
    public class StoreManager
    {
        private protected const string _baseEndpoint = @"/do/WS/NetoAPI";
        private readonly StoreConfiguration _configuration;

        public ProductResource Products { get; }
   

        /// <summary>
        /// Create a new instance of <see cref="StoreManager" />.
        /// </summary>
        /// <param name="configuration">Neto store configuration <see cref="StoreConfiguration"</param>
        public StoreManager(string storeName, string APIKey, string username)
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

           

            this._configuration = new StoreConfiguration(storeName, APIKey, username, _baseEndpoint);
            Products = new ProductResource(this._configuration, null);
        }


       
    }
}
