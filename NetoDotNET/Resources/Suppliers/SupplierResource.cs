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

        public AddSupplierResponse AddSupplier(Suppliers[] supplier)
        {
            AddSupplierFilter addSupplierFilter = new AddSupplierFilter(supplier);


            var nRequest = new AddSupplierRequest(addSupplierFilter);
            var nResponse = GetResponse<AddSupplierResponse>(nRequest);


            return nResponse;
        }

        public List<Suppliers> GetSupplier(GetSupplierFilter supplierFilter)
        {

            var nRequest = new GetSupplierRequest(supplierFilter);
            var nResponse = GetResponse<GetSupplierResponse>(nRequest);

            return nResponse.Supplier;
        }



        public UpdateSupplierResponse UpdateSupplier(Suppliers[] supplier)
        {
            UpdateSupplierFilter updateSupplierFilter = new UpdateSupplierFilter(supplier);

            var nRequest = new UpdateSupplierRequest(updateSupplierFilter);
            var nResponse = GetResponse<UpdateSupplierResponse>(nRequest);

            return nResponse;
        }
    }
}
