using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Customers
{
    class UpdateCustomerLogFilter : NetoUpdateResourceFilter
    {
        public Entities.Customers.CustomerLog.CustomerLogs CustomerLogs { get; set; }

        public UpdateCustomerLogFilter(Entities.Customers.CustomerLog.CustomerLogs customerLogs)
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
