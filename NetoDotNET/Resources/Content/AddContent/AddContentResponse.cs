using Newtonsoft.Json;
using System.Collections.Generic;
using NetoDotNET.Extensions;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Contents
{
    public class AddContentResponse : NetoResponseBase
    {
        [JsonProperty("Content")]
        [JsonConverter(typeof(SingleOrArrayConverter<AddedContent>))]
        public List<AddedContent> Content { get; private set; }
    }

}
