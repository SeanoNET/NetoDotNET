using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Shippings
{
    class GetShippingQuoteResponse : NetoResponseBase
    {
        [JsonProperty("ShippingQuotes")]
        [JsonConverter(typeof(SingleOrArrayConverter<ShippingMethod>))]
        public List<ShippingQuotes> ShippingQuotes { get; set; }

    }

}
