using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class ShippingMethods
    {
        [JsonConverter(typeof(SingleOrArrayConverter<ShippingMethod>))]
        public List<ShippingMethod> ShippingMethod { get; set; }
    }

    public class ShippingMethod
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public ShippingMethodVisibility Visibility { get; set; }
    }

    public class ShippingMethodVisibility
    {
        public bool Customers { get; set; }
        public bool eBay { get; set; }
        public bool Staff { get; set; }
    }
}
