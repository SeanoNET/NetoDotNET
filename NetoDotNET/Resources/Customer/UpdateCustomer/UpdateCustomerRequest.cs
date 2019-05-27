using NetoDotNET.Resources.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Customers
{
    class UpdateCustomerRequest : INetoRequest
    {
        private readonly UpdateCustomerFilter _updateCustomerFilter;

        public string NetoAPIAction => "UpdateCustomer";

        public UpdateCustomerRequest(UpdateCustomerFilter updateCustomerFilter)
        {
            this._updateCustomerFilter = updateCustomerFilter;
        }
        public string GetBody()
        {
            return _updateCustomerFilter.ToJSON();
        }

        public bool isValidRequest()
        {
            return _updateCustomerFilter.isValid();
        }
    }
}