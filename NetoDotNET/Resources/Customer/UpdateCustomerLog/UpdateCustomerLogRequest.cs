using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Customers
{
    class UpdateCustomerLogRequest : INetoRequest
    {
        private readonly UpdateCustomerLogFilter _updateCustomerLogFilter;

        public string NetoAPIAction => "UpdateCustomerLog";

        public UpdateCustomerLogRequest(UpdateCustomerLogFilter updateCustomerLogFilter)
        {
            this._updateCustomerLogFilter = updateCustomerLogFilter;
        }
        public string GetBody()
        {
            return _updateCustomerLogFilter.ToJSON();
        }

        public bool isValidRequest()
        {
            return _updateCustomerLogFilter.isValid();
        }
    }
}