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
        /// <param name="productFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned.</param>
        /// <returns>string</returns>
        public string GetItem(INetoFilter productFilter)
        {
            // TODO: Validate filter
            return Get(productFilter);
        }

        protected override string Get(INetoFilter productFilter)
        {
            var nRequest = new NetoRequest();
            nRequest.NetoAPIAction = "GetItem";
            nRequest.Body = productFilter.ToJSON();

            return GetResource(nRequest).Body;    
        }

    }
}
