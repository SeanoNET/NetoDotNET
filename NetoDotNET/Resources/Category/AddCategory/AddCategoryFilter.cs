using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources
{
    [JsonObject(Title = "AddCategory")]
    public class AddCategoryFilter : NetoAddResourceFilter
    {
        public Category[] Category { get; set; }

        public AddCategoryFilter(Category[] category)
        {
            this.Category = category;
        }


        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}
