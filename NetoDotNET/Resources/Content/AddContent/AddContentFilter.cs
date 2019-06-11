using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Contents
{
    [JsonObject(Title = "AddContent")]
    public class AddContentFilter : NetoAddResourceFilter
    {
        public Content[] Content { get; set; }

        public AddContentFilter(Content[] content)
        {
            this.Content = content;
        }


        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}
