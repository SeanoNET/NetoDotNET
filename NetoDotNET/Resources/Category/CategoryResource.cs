using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;
using NetoDotNET.Entities.Categories;

namespace NetoDotNET.Resources.Categories
{
    public class CategoryResource : NetoResourceBase, ICategoryResource
    {
        private const string RESOURCE_ENDPOINT = "/categories";

        public CategoryResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
        : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }
        public Category[] GetCategory(GetCategoryFilter categoryFilter)
        {
            var nRequest = new GetCategoryRequest(categoryFilter);
            var nResponse = GetResponse<GetCategoryResponse>(nRequest);

            return nResponse.Category;
        }
    }
}
