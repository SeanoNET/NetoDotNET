using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Orders
{
    public class UpdateOrderFilter : NetoUpdateResourceFilter
    {
        public Order[] Order { get; set; }

        public UpdateOrderFilter(Order[] order)
        {
            this.Order = order;
        }

        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}
