using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Orders
{
    public class GetOrderRequest : INetoRequest
    {
        private readonly GetOrderFilter _getOrderFilter;

        public string NetoAPIAction => "GetOrder";

        public GetOrderRequest(GetOrderFilter getOrderFilter)
        {
            this._getOrderFilter = getOrderFilter;
        }


        public bool isValidRequest()
        {
            return _getOrderFilter.isValid();
        }

        public string GetBody()
        {
            return _getOrderFilter.ToJSON();
        }
    }
}