using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Warehouses
{
    public class UpdateWarehouseFilter : NetoUpdateResourceFilter
    {
        public Warehouse[] Warehouse { get; set; }

        public UpdateWarehouseFilter(Warehouse[] warehouse)
        {
            this.Warehouse = warehouse;
        }

        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}
