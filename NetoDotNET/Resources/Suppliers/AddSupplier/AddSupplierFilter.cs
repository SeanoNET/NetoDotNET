using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Supplier
{
    [JsonObject(Title = "AddSupplier")]
    public class AddSupplierFilter : NetoAddResourceFilter
    {
        public Suppliers[] Supplier { get; set; }

        public AddSupplierFilter(Suppliers[] supplier)
        {
            this.Supplier = supplier;
        }


        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}