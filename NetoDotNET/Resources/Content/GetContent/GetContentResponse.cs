using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Contents
{
    public class GetContentResponse : NetoResponseBase
    {
        [JsonProperty("Content")]
        public Content[] Content { get; set; }

    }
}

