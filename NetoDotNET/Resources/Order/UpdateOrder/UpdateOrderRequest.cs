using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Orders
{
    class UpdateOrderRequest : INetoRequest
    {
        private readonly UpdateOrderFilter _updateOrderFilter;

        public string NetoAPIAction => "UpdateOrder";

        public UpdateOrderRequest(UpdateOrderFilter updateOrderFilter)
        {
            this._updateOrderFilter = updateOrderFilter;
        }
        public string GetBody()
        {
            return _updateOrderFilter.ToJSON();
        }

        public bool isValidRequest()
        {
            return _updateOrderFilter.isValid();
        }
    }
}
