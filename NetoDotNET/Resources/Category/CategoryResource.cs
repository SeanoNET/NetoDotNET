using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Categories
{
    public class CategoryResource : NetoResourceBase, ICategoryResource
    {
        private const string RESOURCE_ENDPOINT = "/categories";

        public CategoryResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
        : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }

        public AddCategoryResponse AddCategory(Category[] category)
        {
            var addCategoryFilter = new AddCategoryFilter(category);

            var nRequest = new AddCategoryRequest(addCategoryFilter);
            var nResponse = GetResponse<AddCategoryResponse>(nRequest);

            return nResponse;
        }

        public Category[] GetCategory(GetCategoryFilter categoryFilter)
        {
            var nRequest = new GetCategoryRequest(categoryFilter);
            var nResponse = GetResponse<GetCategoryResponse>(nRequest);

            return nResponse.Category;
        }
    }
}
