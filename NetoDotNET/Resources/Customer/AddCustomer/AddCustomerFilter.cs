using Newtonsoft.Json;
using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Customers
{
    [JsonObject(Title = "AddCustomer")]
    public class AddCustomerFilter : NetoAddResourceFilter
    {
        public Customer[] Customer{ get; set; }

        public AddCustomerFilter(Customer[] customer)
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
