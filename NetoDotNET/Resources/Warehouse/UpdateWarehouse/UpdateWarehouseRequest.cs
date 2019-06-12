using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Warehouses
{
  public  class UpdateWarehouseRequest : INetoRequest
    {
        private readonly UpdateWarehouseFilter _updateWarehouseFilter;

        public string NetoAPIAction => "UpdateWarehouse";

        public UpdateWarehouseRequest(UpdateWarehouseFilter updateWarehouseFilter)
        {
            this._updateWarehouseFilter = updateWarehouseFilter;
        }
        public string GetBody()
        {
            return _updateWarehouseFilter.ToJSON();
        }

        public bool isValidRequest()
        {
            return _updateWarehouseFilter.isValid();
        }
    }
}
