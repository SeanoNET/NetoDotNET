using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Categories
{
    public class UpdateCategoryResponse : NetoResponseBase
    {
        [JsonProperty("Category")]
        [JsonConverter(typeof(SingleOrArrayConverter<UpdatedCategory>))]
        public List<UpdatedCategory> Category { get; private set; }

    }
}
