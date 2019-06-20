using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Supplier
{
    class UpdateSupplierRequest : INetoRequest
    {
        private readonly UpdateSupplierFilter _updateSupplierFilter;

        public string NetoAPIAction => "UpdateSupplier";

        public UpdateSupplierRequest(UpdateSupplierFilter updateSupplierFilter)
        {
            this._updateSupplierFilter = updateSupplierFilter;
        }
        public string GetBody()
        {
            return _updateSupplierFilter.ToJSON();
        }

        public bool isValidRequest()
        {
            return _updateSupplierFilter.isValid();
        }
    }
}
