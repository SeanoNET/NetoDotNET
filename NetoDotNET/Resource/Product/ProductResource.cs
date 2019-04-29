using NetoDotNET.Objects;
using NetoDotNET.Resources.Product.UpdateItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources
{
    public class ProductResource : NetoResourceBase
    {
        private readonly StoreConfiguration _storeConfiguration;
        private const string RESOURCE_ENDPOINT = "/products";

        public ProductResource(StoreConfiguration storeCongfiguration, IRestClient restClient) 
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
            this._storeConfiguration = storeCongfiguration;
        }


        /// <summary>
        /// Use this method to get product data.
        /// </summary>
        /// <param name="GetItemFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned.</param>
        /// <returns>string</returns>
        public Item[] GetItem(GetItemFilter productFilter)
        {
            var resp = (GetItemResponse)Get(productFilter);
            return resp.Item;
        }

        /// <summary>
        /// Use this method to add a new product.
        /// </summary>
        /// <param name="Item">New item to add.</param>
        /// <returns>returns the unique identifier (SKU) for the product, and the date and time the product was added (CurrentTime)</returns>
        public AddItemResponse AddItem(Item[] item)
        {
            AddItemFilter addItemFilter = new AddItemFilter(item);
            var resp = (AddItemResponse)Add(addItemFilter);
            return resp;
        }

        /// <summary>
        /// Use this method to update a product.
        /// </summary>
        /// <param name="Item">Item to update.</param>
        /// <returns>returns the unique identifier (SKU) for the product, and the date and time the product was updated (CurrentTime)</returns>
        public UpdateItemResponse UpdateItem(Item[] item)
        {
            UpdateItemFilter updateItemFilter = new UpdateItemFilter(item);
            var resp = (UpdateItemResponse)Update(updateItemFilter);
            return resp;
        }

        protected override NetoResponseBase Get(NetoGetResourceFilter productFilter)
        {
            var nRequest = new GetItemRequest((GetItemFilter)productFilter);

           
            var nResponse = GetResource<GetItemResponse>(nRequest);

            nResponse.ThrowOnError();



            return nResponse;    
        }

        protected override NetoResponseBase Add(NetoAddResourceFilter filter)
        {
            var nRequest = new AddItemRequest((AddItemFilter)filter);

            var nResponse = AddResource<AddItemResponse>(nRequest);

            nResponse.ThrowOnError();


            return nResponse;
        }

        protected override NetoResponseBase Update(NetoUpdateResourceFilter filter)
        {
            var nRequest = new UpdateItemRequest((UpdateItemFilter)filter);

            var nResponse = AddResource<UpdateItemResponse>(nRequest);

            nResponse.ThrowOnError();


            return nResponse;
        }
    }
}
