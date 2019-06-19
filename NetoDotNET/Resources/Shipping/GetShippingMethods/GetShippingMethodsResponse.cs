using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Shippings
{
    class GetShippingMethodsResponse : NetoResponseBase
    {
        [JsonProperty("ShippingMethods")]
        public ShippingMethods ShippingMethods { get; set; }

    }

}
