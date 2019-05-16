using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Categories
{
    public class AddCategoryRequest : INetoRequest
    {
        private readonly AddCategoryFilter _addCategoryFilter;
        public string NetoAPIAction => "AddCategory";

        public AddCategoryRequest(AddCategoryFilter addCategoryFilter)
        {
            this._addCategoryFilter = addCategoryFilter;
        }
        public string GetBody()
        {
            return _addCategoryFilter.ToJSON();
        }

        public bool isValidRequest()
        {
            return _addCategoryFilter.isValid();
        }
    }
}
