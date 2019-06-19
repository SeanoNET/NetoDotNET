using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class ShippingQuotes
    {
        public bool PickUp { get; set; }

        public bool ShipPOBox { get; set; }

        public int DeliveryTime { get; set; }

        public decimal ShippingCost { get; set; }

        public ShippingQuoteShippingMethod ShippingMethod { get; set; }
    }

    public class ShippingQuoteShippingMethod
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
