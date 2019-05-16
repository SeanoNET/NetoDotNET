using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Categories
{
    class UpdateCategoryRequest : INetoRequest
    {
        private readonly UpdateCategoryFilter _updateCategoryFilter;

        public string NetoAPIAction => "UpdateCategory";

        public UpdateCategoryRequest(UpdateCategoryFilter updateCategoryFilter) {
            this._updateCategoryFilter = updateCategoryFilter;
        }
        public string GetBody()
        {
            return _updateCategoryFilter.ToJSON();
        }

        public bool isValidRequest()
        {
            return _updateCategoryFilter.isValid();
        }
    }
}
