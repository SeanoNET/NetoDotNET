using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class NewItem : ItemBase
    {
        public Images Images { get; set; }
    }

    public class Images
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Image>))]
        public List<Image> Image { get; set; }
    }
}
