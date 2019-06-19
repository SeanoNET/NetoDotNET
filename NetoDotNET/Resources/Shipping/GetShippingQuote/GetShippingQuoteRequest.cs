using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Shippings
{
    public class GetShippingQuoteRequest : INetoRequest
    {
        private readonly GetShippingQuoteFilter _getShippingQuoteFilter;

        public string NetoAPIAction => "GetShippingQuote";

        public GetShippingQuoteRequest(GetShippingQuoteFilter getShippingQuoteFilter)
        {
            this._getShippingQuoteFilter = getShippingQuoteFilter;
        }


        public bool isValidRequest()
        {
            return _getShippingQuoteFilter.isValid();
        }

        public string GetBody()
        {
            return _getShippingQuoteFilter.ToJSON();
        }
    }
}