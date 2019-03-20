using NetoDotNET.Objects;
using Newtonsoft.Json;

namespace NetoDotNET
{
    public class GetItemResponse : INetoResponse
    {
        [JsonProperty("Item")]
        public Item[] Item { get; set; }


        [JsonProperty("CurrentTime")]
        public string CurrentTime { get; set; }

        [JsonProperty("Ack")]
        public string Ack { get; set; }

        public bool isSuccess()
        {
            return true;
        }
    }

}
