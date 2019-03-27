using NetoDotNET.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Product.UpdateItem
{
    public class UpdateItemResponse : NetoResponseBase
    {
        [JsonProperty("Item")]
        public Item[] Item { get; set; }

    }
}
