using NetoDotNET.Objects;
using Newtonsoft.Json;

namespace NetoDotNET
{
    public class GetItemResponse : NetoResponseBase
    {
        [JsonProperty("Item")]
        public Item[] Item { get; set; }

    }

}
