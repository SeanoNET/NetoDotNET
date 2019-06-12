using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.RMA
{
    public class AddRMAResponse : NetoResponseBase
    {
        [JsonProperty("Rma")]
        [JsonConverter(typeof(SingleOrArrayConverter<AddedRma>))]
        public List<AddedRma> Rma { get; private set; }
    }

}