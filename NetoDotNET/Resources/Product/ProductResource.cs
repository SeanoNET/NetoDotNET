using NetoDotNET.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources
{
    public class ProductResource : NetoResourceBase<Product>
    {
        private readonly StoreConfiguration _storeConfiguration;
        private const string PRODUCT_ENDPOINT = "/products";

        public ProductResource(StoreConfiguration storeCongfiguration) 
            : base(storeCongfiguration, PRODUCT_ENDPOINT, null)
        {
            this._storeConfiguration = storeCongfiguration;
        }


        /// <summary>
        /// Use this call to get product data.
        /// </summary>
        /// <param name="NetoGetResourceFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned.</param>
        /// <returns>string</returns>
        public string GetItem(NetoGetResourceFilter productFilter)
        {
            // Make sure the GetItem filter is valid
            if (!productFilter.isValid())
                throw new Exception("GetItem filter is not valid.");

            return Get(productFilter);
        }

        protected override string Get(NetoGetResourceFilter productFilter)
        {
            var nRequest = new NetoRequest();
            nRequest.NetoAPIAction = "GetItem";
            nRequest.Body = productFilter.ToJSON();

            return GetResource(nRequest).Body;    
        }

    }
}
