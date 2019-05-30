using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;
using Newtonsoft.Json;

namespace NetoDotNET.Resources.Orders
{
    public class AddOrderFilter : NetoAddResourceFilter
    {
        [JsonProperty(PropertyName = "Order")]
        public AddOrder[] AddOrder { get; set; }

        public AddOrderFilter(AddOrder[] addOrder)
        {
            this.AddOrder = addOrder;
        }


        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}