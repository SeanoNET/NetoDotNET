using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Shippings
{
    [JsonObject(Title = "ShippingQuote")]
    public class GetShippingQuoteFilter : NetoGetResourceFilter
    {
        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetShippingQuote request. These will determine the results returned.
        /// </summary>
        public GetShippingQuoteFilter()
        {

        }

        public string ShipPostCode { get; set; }

        public string ShipCountry { get; set; }

        public string ShipCity { get; set; }

        public string ShipState { get; set; }

        public bool ShipPOBox { get; set; }

        public ShippingQuoteOrderLines[] OrderLines { get; set; }

        public ShippingQuoteShippingMethod ShippingMethod { get; set; }

        public class ShippingQuoteOrderLines
        {
            public string SKU { get; set; }

            public string Quantity { get; set; }

            public decimal UnitPrice { get; set; }
        }

        public class ShippingQuoteShippingMethod
        {
            public int ID { get; set; }
        }


        internal override bool isValid()
        {
            if (String.IsNullOrEmpty(ShipPostCode))
                return false;

            if (String.IsNullOrEmpty(ShipCountry))
                return false;

            if (String.IsNullOrEmpty(ShipCity))
                return false;

            if (String.IsNullOrEmpty(ShipState))
                return false;

            return true;
        }
    }
}