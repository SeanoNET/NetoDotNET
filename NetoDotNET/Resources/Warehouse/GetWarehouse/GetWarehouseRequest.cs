using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Warehouses
{
    class GetWarehouseRequest : INetoRequest
    {
        private readonly GetWarehouseFilter _getWarehouseFilter;

        public string NetoAPIAction => "GetWarehouse";

        public GetWarehouseRequest(GetWarehouseFilter getWarehouseFilter)
        {
            this._getWarehouseFilter = getWarehouseFilter;
        }


        public bool isValidRequest()
        {
            return _getWarehouseFilter.isValid();
        }

        public string GetBody()
        {
            return _getWarehouseFilter.ToJSON();
        }
    }
}