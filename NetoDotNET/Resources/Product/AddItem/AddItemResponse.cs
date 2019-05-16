using Newtonsoft.Json;
using System.Collections.Generic;
using NetoDotNET.Extensions;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Products
{
    public class AddItemResponse : NetoResponseBase
    {
        [JsonProperty("Item")]
        [JsonConverter(typeof(SingleOrArrayConverter<AddedItem>))]
        public List<AddedItem> Item { get; private set; }
    }

}


