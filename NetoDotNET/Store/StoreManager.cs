using NetoDotNET.Resources;
using NetoDotNET.Resources.Categories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET
{
    /// <summary>
    /// Manages your Neto store resources
    /// </summary>
    public class StoreManager
    {
        private protected const string _baseEndpoint = @"/do/WS/NetoAPI";
        private readonly StoreConfiguration _configuration;

        /// <summary>
        /// Manage product resources
        /// </summary>
        public IProductResource Products { get; }

        public ICategoryResource Categories { get; }


        /// <summary>
        /// Manage your Neto store resources.
        /// </summary>
        /// <param name="storeName">The name of the Neto store https://www.*storeName*.com.au</param>
        /// <param name="APIKey">Your Neto API Secure Key (generate this in your Neto control panel).</param>
        /// <param name="username">Your Neto API username (managed under Staff Users in the Neto control panel). Not required if using a key.</param>
        public StoreManager(string storeName, string APIKey, string username)
        {                
            this._configuration = new StoreConfiguration(storeName, APIKey, username, _baseEndpoint);

            this.Products = new ProductResource(this._configuration, null);
            this.Categories = new CategoryResource(this._configuration, null);
        }


       
    }
}
