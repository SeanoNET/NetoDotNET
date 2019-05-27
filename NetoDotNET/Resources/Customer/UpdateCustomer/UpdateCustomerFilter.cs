using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Customers
{
    public class UpdateCustomerFilter : NetoUpdateResourceFilter
    {
        public Customer[] Customer { get; set; }

        public UpdateCustomerFilter(Customer[] customer)
        {
            this.Customer = customer;
        }

        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}