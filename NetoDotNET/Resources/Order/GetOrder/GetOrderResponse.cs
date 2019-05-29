using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Orders
{
    public class GetOrderResponse : NetoResponseBase
    {
        [JsonProperty("Order")]
        public Order[] Order { get; set; }

    }

}