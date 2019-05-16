using NetoDotNET.Entities;
using Newtonsoft.Json;

namespace NetoDotNET.Resources.Products
{
    public class GetItemResponse : NetoResponseBase
    {
        [JsonProperty("Item")]
        public Item[] Item { get; set; }

    }

}
