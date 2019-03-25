using NetoDotNET.AddItemResp;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetoDotNET
{
    public class AddItemResponse : INetoResponse
    {
        [JsonProperty("Item")]
        [JsonConverter(typeof(SingleOrArrayConverter<Item>))]
        public List<Item> Item { get; set; }

        [JsonProperty("Messages")]
        public Messages Messages { get; set; }

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

namespace NetoDotNET.AddItemResp
{
    public class Messages
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Error>))]
        public List<Error> Error { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<Warning>))]
        public List<Warning> Warning { get; set; }
    }

    public class Error
    {
        public string Message { get; set; }
        public string SeverityCode { get; set; }
        public string Description { get; set; }
    }

    public class Warning
    {
        public string Message { get; set; }
        public string SeverityCode { get; set; }
    }

    public class Item
    {
        public string InventoryID { get; set; }
        public string SKU { get; set; }
    }
}