using NetoDotNET.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources
{
    public class ProductResource : NetoResourceBase
    {
        private readonly StoreConfiguration _storeConfiguration;
        private const string PRODUCT_ENDPOINT = "/products";

        public ProductResource(StoreConfiguration storeCongfiguration, IRestClient restClient) 
            : base(storeCongfiguration, PRODUCT_ENDPOINT, restClient)
        {
            this._storeConfiguration = storeCongfiguration;
        }


        /// <summary>
        /// Use this call to get product data.
        /// </summary>
        /// <param name="GetItemFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned.</param>
        /// <returns>string</returns>
        public Item[] GetItem(GetItemFilter productFilter)
        {
            var resp = (GetItemResponse)Get(productFilter);
            return resp.Item;
        }

        protected override INetoResponse Get(NetoGetResourceFilter productFilter)
        {
            var nRequest = new GetItemRequest((GetItemFilter)productFilter);
           
            return GetResource<GetItemResponse>(nRequest);    
        }

    }
}
