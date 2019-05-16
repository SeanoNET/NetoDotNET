using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Categories
{
    public interface ICategoryResource
    {

        Category[] GetCategory(GetCategoryFilter categoryFilter);

        AddCategoryResponse AddCategory(Category[] category);

        UpdateCategoryResponse UpdateCategory(Category[] category);

    }
}
