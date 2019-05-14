using NetoDotNET.Resources;
using NetoDotNET.Resources.Categories;
using System;
using System.Collections.Generic;
using System.Text;


namespace NetoDotNET.Resources.Categories
{
    public class GetCategoryRequest : INetoRequest
    {
        private readonly GetCategoryFilter _getCategoryFilter;

        public string NetoAPIAction => "GetCategory";

        public GetCategoryRequest(GetCategoryFilter getCategoryFilter)
        {
            this._getCategoryFilter = getCategoryFilter;
        }

        public string GetBody()
        {

            return _getCategoryFilter.ToJSON(); 
        }

        public bool isValidRequest()
        {
            return _getCategoryFilter.isValid();
        }
    }
}
