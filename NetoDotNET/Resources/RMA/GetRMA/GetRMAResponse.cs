using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.RMA
{
    public class GetRMAResponse : NetoResponseBase
    {
        [JsonProperty("Rma")]
        [JsonConverter(typeof(SingleOrArrayConverter<Rma>))]
        public List<Rma> Rma { get; set; }

    }

}
