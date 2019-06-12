using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Warehouses
{
    public class WarehouseResource : NetoResourceBase, IWarehouseResource
    {
        private const string RESOURCE_ENDPOINT = "/warehouses";

        public WarehouseResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }

        public AddWarehouseResponse AddWarehouse(Warehouse[] warehouse)
        {
            throw new NotImplementedException();
        }

        public Warehouse[] GetWarehouse(GetWarehouseFilter warehouseFilter)
        {
            var nRequest = new GetWarehouseRequest(warehouseFilter);
            var nResponse = GetResponse<GetWarehouseResponse>(nRequest);

            return nResponse.Warehouse;
        }

        public UpdateWarehouseResponse UpdateWarehouse(Warehouse[] warehouse)
        {
            UpdateWarehouseFilter updateWarehouseFilter = new UpdateWarehouseFilter(warehouse);

            var nRequest = new UpdateWarehouseRequest(updateWarehouseFilter);
            var nResponse = GetResponse<UpdateWarehouseResponse>(nRequest);

            return nResponse;
        }
    }
}
