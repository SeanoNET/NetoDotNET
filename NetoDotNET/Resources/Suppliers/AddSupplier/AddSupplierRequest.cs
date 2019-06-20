using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Supplier
{
    public class AddSupplierRequest : INetoRequest
    {
        private readonly AddSupplierFilter _addSupplierFilter;

        public string NetoAPIAction => "AddSupplier";

        public AddSupplierRequest(AddSupplierFilter addSupplierFilter)
        {
            this._addSupplierFilter = addSupplierFilter;
        }


        public bool isValidRequest()
        {
            return _addSupplierFilter.isValid();
        }

        public string GetBody()
        {
            return _addSupplierFilter.ToJSON();
        }
    }
}