using NetoDotNET.Objects;
using NetoDotNET.Resources.Product.UpdateItem;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace NetoDotNET.Resources
{
    public class ProductResource : NetoResourceBase, IProductResource
    {
        private const string RESOURCE_ENDPOINT = "/products"; // Not needed

        public ProductResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }


        /// <summary>
        /// Use this method to get product data.
        /// </summary>
        /// <param name="GetItemFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned.</param>
        /// <returns>string</returns>
        public Item[] GetItem(GetItemFilter productFilter)
        {    
            // Build Neto Request
            var nRequest = new GetItemRequest(productFilter);
       
            // Get Neto Response
            var nResponse = GetResponse<GetItemResponse>(nRequest);

            return nResponse.Item;
        }

        /// <summary>
        /// Use this method to add a new product.
        /// </summary>
        /// <param name="Item">New item to add.</param>
        /// <returns>returns the unique identifier (SKU) for the product, and the date and time the product was added (CurrentTime)</returns>
        public AddItemResponse AddItem(Item[] item)
        {
            AddItemFilter addItemFilter = new AddItemFilter(item);

            // Build Neto Request
            var nRequest = new AddItemRequest(addItemFilter);

            // Get Neto Response
            var nResponse = GetResponse<AddItemResponse>(nRequest);


            return nResponse;
        }

        /// <summary>
        /// Use this method to update a product.
        /// </summary>
        /// <param name="Item">Item to update.</param>
        /// <returns>returns the unique identifier (SKU) for the product, and the date and time the product was updated (CurrentTime)</returns>
        public UpdateItemResponse UpdateItem(Item[] item)
        {
            UpdateItemFilter updateItemFilter = new UpdateItemFilter(item);

            // Build Neto Request
            var nRequest = new UpdateItemRequest(updateItemFilter);

            // Get Neto Response
            var nResponse = GetResponse<UpdateItemResponse>(nRequest);

            return nResponse;
        }      
    }
}
