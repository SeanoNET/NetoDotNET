using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Orders
{
    public class AddOrderRequest : INetoRequest
    {
        private readonly AddOrderFilter _addOrderFilter;

        public string NetoAPIAction => "AddOrder";

        public AddOrderRequest(AddOrderFilter addOrderFilter)
        {
            this._addOrderFilter = addOrderFilter;
        }


        public bool isValidRequest()
        {
            return _addOrderFilter.isValid();
        }

        public string GetBody()
        {
            return _addOrderFilter.ToJSON();
        }
    }
}