using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Customers
{
    class AddCustomerLogRequest : INetoRequest
    {
        private readonly AddCustomerLogFilter _addCustomerLogFilter;

        public string NetoAPIAction => "AddCustomerLog";

        public AddCustomerLogRequest(AddCustomerLogFilter addCustomerLogFilter)
        {
            this._addCustomerLogFilter = addCustomerLogFilter;
        }


        public bool isValidRequest()
        {
            return _addCustomerLogFilter.isValid();
        }

        public string GetBody()
        {
            return _addCustomerLogFilter.ToJSON();
        }
    }
}