using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetoDotNET.Resources.Warehouses
{
    public class AddWarehouseResponse : NetoResponseBase
    {
        [JsonProperty("Warehouse")]
        [JsonConverter(typeof(SingleOrArrayConverter<AddedWarehouse>))]
        public List<AddedWarehouse> Warehouse { get; private set; }
    }

}

