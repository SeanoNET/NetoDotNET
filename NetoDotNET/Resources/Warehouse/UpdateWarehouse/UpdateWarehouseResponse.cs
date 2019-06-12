using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetoDotNET.Resources.Warehouses
{
    public class UpdateWarehouseResponse : NetoResponseBase
    {
        [JsonProperty("Warehouse")]
        [JsonConverter(typeof(SingleOrArrayConverter<UpdatedWarehouse>))]
        public List<UpdatedWarehouse> Warehouse { get; private set; }

    }
}
