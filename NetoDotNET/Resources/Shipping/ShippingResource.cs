using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Shippings
{
    public class ShippingResource : NetoResourceBase, IShippingResource
    {
        private const string RESOURCE_ENDPOINT = "/shipping";

        public ShippingResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }

        public ShippingMethods GetShippingMethods()
        {
            var nRequest = new GetShippingMethodsRequest(new GetShippingMethodsFilter());
            var nResponse = GetResponse<GetShippingMethodsResponse>(nRequest);

            return nResponse.ShippingMethods;
        }
    }
}
