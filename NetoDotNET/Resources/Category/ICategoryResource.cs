using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities.Categories;

namespace NetoDotNET.Resources.Categories
{
    public interface ICategoryResource
    {

        Category[] GetCategory(GetCategoryFilter categoryFilter);


    }
}
