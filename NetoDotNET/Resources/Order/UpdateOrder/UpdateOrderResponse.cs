using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Orders
{
    public class UpdateOrderResponse : NetoResponseBase
    {
        [JsonProperty("Order")]
        [JsonConverter(typeof(SingleOrArrayConverter<UpdatedOrder>))]
        public List<UpdatedOrder> Order { get; private set; }

    }
}

