using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Customers
{
    public class AddCustomerRequest : INetoRequest
    {
        private readonly AddCustomerFilter _addCustomerFilter;

        public string NetoAPIAction => "AddCustomer";

        public AddCustomerRequest(AddCustomerFilter addCustomerFilter)
        {
            this._addCustomerFilter = addCustomerFilter;
        }


        public bool isValidRequest()
        {
            return _addCustomerFilter.isValid();
        }

        public string GetBody()
        {
            return _addCustomerFilter.ToJSON();
        }
    }
}