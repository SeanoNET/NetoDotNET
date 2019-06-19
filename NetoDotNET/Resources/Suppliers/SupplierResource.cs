using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Supplier
{
    public class SupplierResource : NetoResourceBase, ISupplierResource
    {
        private const string RESOURCE_ENDPOINT = "/suppliers";

        public SupplierResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }
    }
}
