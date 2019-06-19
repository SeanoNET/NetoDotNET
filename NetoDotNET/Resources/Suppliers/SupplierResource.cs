using NetoDotNET.Entities;
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

        public List<Suppliers> GetSupplier(GetSupplierFilter supplierFilter)
        {

            var nRequest = new GetSupplierRequest(supplierFilter);
            var nResponse = GetResponse<GetSupplierResponse>(nRequest);

            return nResponse.Supplier;
        }
    }
}
