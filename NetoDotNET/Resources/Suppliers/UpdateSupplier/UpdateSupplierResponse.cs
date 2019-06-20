
using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Supplier
{
    public class UpdateSupplierResponse : NetoResponseBase
    {
        [JsonProperty("Supplier")]
        [JsonConverter(typeof(SingleOrArrayConverter<UpdatedSupplier>))]
        public List<UpdatedSupplier> Supplier { get; private set; }
    }
}
