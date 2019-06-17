using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Payments
{
    public class GetPaymentMethodsRequest : INetoRequest
    {
        private readonly GetPaymentsMethodFilter _getPaymentMethodFilter;

        public string NetoAPIAction => "GetPaymentMethods";

        public GetPaymentMethodsRequest(GetPaymentsMethodFilter getPaymentMethodFilter)
        {
            this._getPaymentMethodFilter = getPaymentMethodFilter;
        }


        public bool isValidRequest()
        {
            return _getPaymentMethodFilter.isValid();
        }

        public string GetBody()
        {
            return _getPaymentMethodFilter.ToJSON();
        }
    }
}