using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Supplier
{
    class UpdateSupplierFilter : NetoUpdateResourceFilter
    {
        public Suppliers[] Supplier { get; set; }

        public UpdateSupplierFilter(Suppliers[] supplier)
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