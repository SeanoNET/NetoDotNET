using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Supplier
{
    public class GetSupplierRequest : INetoRequest
    {
        private readonly GetSupplierFilter _getSupplierFilter;

        public string NetoAPIAction => "GetSupplier";

        public GetSupplierRequest(GetSupplierFilter getSupplierFilter)
        {
            this._getSupplierFilter = getSupplierFilter;
        }


        public bool isValidRequest()
        {
            return _getSupplierFilter.isValid();
        }

        public string GetBody()
        {
            return _getSupplierFilter.ToJSON();
        }
    }
}
