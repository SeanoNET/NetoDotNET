using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Supplier
{
    public class GetSupplierResponse : NetoResponseBase
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Suppliers>))]
        public List<Suppliers> Supplier { get; set; }
    }

}
