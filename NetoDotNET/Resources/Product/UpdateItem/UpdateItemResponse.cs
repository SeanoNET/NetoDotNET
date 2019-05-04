using NetoDotNET.Extensions;
using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Product.UpdateItem
{
    public class UpdateItemResponse : NetoResponseBase
    {
        [JsonProperty("Item")]
        [JsonConverter(typeof(SingleOrArrayConverter<UpdatedItem>))]
        public List<UpdatedItem> Item { get; private set; }

    }
}
