using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Orders
{
    public class AddOrderResponse : NetoResponseBase
    {
        [JsonProperty("Order")]
        [JsonConverter(typeof(SingleOrArrayConverter<AddedOrder>))]
        public List<AddedOrder> Order { get; private set; }
    }

}