using NetoDotNET.Entities;
using NetoDotNET.Resources.Product.UpdateItem;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace NetoDotNET.Resources
{
    public class ProductResource : NetoResourceBase, IProductResource
    {
        private const string RESOURCE_ENDPOINT = "/products"; 

        public ProductResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }


        public Item[] GetItem(GetItemFilter productFilter)
        {    
 
            var nRequest = new GetItemRequest(productFilter);   
            var nResponse = GetResponse<GetItemResponse>(nRequest);

            return nResponse.Item;
        }


        public AddItemResponse AddItem(Item[] item)
        {
            AddItemFilter addItemFilter = new AddItemFilter(item);


            var nRequest = new AddItemRequest(addItemFilter);
            var nResponse = GetResponse<AddItemResponse>(nRequest);


            return nResponse;
        }


        public UpdateItemResponse UpdateItem(Item[] item)
        {
            UpdateItemFilter updateItemFilter = new UpdateItemFilter(item);

            var nRequest = new UpdateItemRequest(updateItemFilter);
            var nResponse = GetResponse<UpdateItemResponse>(nRequest);

            return nResponse;
        }      
    }
}
