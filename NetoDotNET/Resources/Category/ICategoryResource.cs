using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Categories
{
    public interface ICategoryResource
    {
        /// <summary>
        /// Use this call to add a new product category.
        /// </summary>
        /// <param name="categoryFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetCategoryFilter"/></param>
        /// <typeparam name="GetCategoryFilter">
        /// </typeparam>
        /// <returns>Categories matching the GetCategoryFilter <see cref="Category"/></returns>
        Category[] GetCategory(GetCategoryFilter categoryFilter);

        /// <summary>
        /// Use this call to add a new product category.
        /// </summary>
        /// <param name="category">New category to add.</param>
        /// <typeparam name="Category">
        /// </typeparam>
        /// <returns>returns the unique identifier (CategoryID) for the category <see cref="AddCategoryResponse"/></returns>
        AddCategoryResponse AddCategory(Category[] category);


        /// <summary>
        /// Use this call to update categories.
        /// </summary>
        /// <param name="category">Category to update. <see cref="Category"/></param>
        /// <typeparam name="Category">
        /// </typeparam>
        /// <returns>A successful call to UpdateCategory returns the unique identifier (CategoryID) for the updated category <see cref="UpdateCategoryResponse"/></returns>
        UpdateCategoryResponse UpdateCategory(Category[] category);

    }
}
