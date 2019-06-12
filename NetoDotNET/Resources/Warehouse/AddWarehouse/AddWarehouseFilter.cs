using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Warehouses
{
    [JsonObject(Title = "AddWarehouse")]
    public class AddWarehouseFilter : NetoAddResourceFilter
    {
        public Warehouse[] Warehouse { get; set; }

        public AddWarehouseFilter(Warehouse[] warehouse)
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