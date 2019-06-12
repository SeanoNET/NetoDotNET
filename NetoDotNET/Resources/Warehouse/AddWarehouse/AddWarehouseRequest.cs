using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Warehouses
{
    class AddWarehouseRequest : INetoRequest
    {
        private readonly AddWarehouseFilter _addWarehouseFilter;

        public string NetoAPIAction => "AddWarehouse";

        public AddWarehouseRequest(AddWarehouseFilter addWarehouseFilter)
        {
            this._addWarehouseFilter = addWarehouseFilter;
        }


        public bool isValidRequest()
        {
            return _addWarehouseFilter.isValid();
        }

        public string GetBody()
        {
            return _addWarehouseFilter.ToJSON();
        }
    }
}