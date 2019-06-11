using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetoDotNET.Resources.Contents
{
    public class UpdateContentResponse : NetoResponseBase
    {
        [JsonProperty("Content")]
        [JsonConverter(typeof(SingleOrArrayConverter<UpdateContent>))]
        public List<UpdateContent> Content { get; private set; }

    }
}
