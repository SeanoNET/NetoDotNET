using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Shippings
{
    public class GetShippingMethodsRequest : INetoRequest
    {
        private readonly GetShippingMethodsFilter _getShippingMethodsFilter;

        public string NetoAPIAction => "GetShippingMethods";

        public GetShippingMethodsRequest(GetShippingMethodsFilter getShippingMethodsFilter)
        {
            this._getShippingMethodsFilter = getShippingMethodsFilter;
        }


        public bool isValidRequest()
        {
            return _getShippingMethodsFilter.isValid();
        }

        public string GetBody()
        {
            return _getShippingMethodsFilter.ToJSON();
        }
    }
}