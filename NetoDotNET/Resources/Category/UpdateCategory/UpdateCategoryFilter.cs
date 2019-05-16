using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Categories
{
    public class UpdateCategoryFilter : NetoUpdateResourceFilter
    {
        public Category[] Category { get; set; }

        public UpdateCategoryFilter(Category[] category)
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
