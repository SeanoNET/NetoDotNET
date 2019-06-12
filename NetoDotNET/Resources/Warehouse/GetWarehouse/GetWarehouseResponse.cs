using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Warehouses
{
    public class GetWarehouseResponse : NetoResponseBase
    {
        [JsonProperty("Warehouse")]
        public Warehouse[] Warehouse { get; set; }

    }
}
