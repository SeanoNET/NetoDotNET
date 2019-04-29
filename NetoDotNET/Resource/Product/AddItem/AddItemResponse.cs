using NetoDotNET.Extensions;

using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetoDotNET
{
    public class AddItemResponse : NetoResponseBase
    {
        [JsonProperty("Item")]
        [JsonConverter(typeof(SingleOrArrayConverter<AddedItem>))]
        public List<AddedItem> Item { get; private set; }
    }

}


