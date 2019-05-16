using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Categories
{
    class GetCategoryResponse : NetoResponseBase
    {
        [JsonProperty("Category")]
        public Category[] Category { get; set; }

    }
}
