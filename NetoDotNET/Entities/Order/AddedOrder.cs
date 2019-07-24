using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class AddedOrder
    {
        public string OrderID { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<StickyNotes>))]
        public List<StickyNotes> StickyNotes { get; set; }
    }
}
