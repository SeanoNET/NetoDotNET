using NetoDotNET.Entities.Customers.CustomerLog;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Customers
{
    [JsonObject(Title = "AddCustomerLog")]
    class AddCustomerLogFilter : NetoAddResourceFilter
    {
        public Entities.Customers.CustomerLog.CustomerLogs CustomerLogs { get; set; }

        public AddCustomerLogFilter(Entities.Customers.CustomerLog.CustomerLogs customerLogs)
        {
            this.CustomerLogs = customerLogs;
        }

        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }


}
