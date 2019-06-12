using NetoDotNET.Resources.Products;
using NetoDotNET.Resources.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Resources.Customers;
using NetoDotNET.Resources.Orders;
using NetoDotNET.Resources.Contents;
using NetoDotNET.Resources.RMA;
using NetoDotNET.Resources.Warehouses;

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

        /// <summary>
        /// Manage product category resources, deprecated see content
        /// </summary>
        public ICategoryResource Categories { get; }

        /// <summary>
        /// Manage customer resources
        /// </summary>
        public ICustomerResource Customers { get;  }

        /// <summary>
        /// Manage order/invoice resources
        /// </summary>
        public IOrderResource Orders { get; }

        /// <summary>
        /// Manage content resources
        /// </summary>
        public IContentResource Content { get; }

        /// <summary>
        /// Manage RMA (Return Merchadise Authorisation) resources
        /// </summary>
        public IRMAResource RMA { get; }

        /// <summary>
        /// Manage warehouses resources
        /// </summary>
        public IWarehouseResource Warehouses { get; }

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
            this.Customers = new CustomerResource(this._configuration, null);
            this.Orders = new OrderResource(this._configuration, null);
            this.Content = new ContentResource(this._configuration, null);
            this.RMA = new RMAResource(this._configuration, null);
            this.Warehouses = new WarehouseResource(this._configuration, null);
        }


       
    }
}
