using NetoDotNET.Entities;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources;
using NetoDotNET.Resources.Categories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class CategoryTests : NetoBaseTests
    {
        private Category GetTestAddCategory()
        {
            Random random = new Random();
            return new Category
            {
                CategoryName = $"NetoDotNET.Test - New Category {random.Next(0, 99999).ToString()}",
                Description1 = "New category description"
            };
        }

        #region Filters
        /// <summary>
        /// Tests that <see cref="NetoRequestException"/> is thrown when an invalid <see cref="GetCategoryFilter"/> is provided
        /// </summary>
        [Test]
        public void Should_Throw_On_InValid_GetCategoryFilter()
        {
            var netoStore = GetStoreManager();
            var filter = new GetCategoryFilter();
            Assert.Throws<NetoRequestException>(() => netoStore.Categories.GetCategory(filter));
        }
        #endregion

        #region GetCategory 

        /// <summary>
        /// Test retrieval of single category using ID
        /// </summary>
        /// <param name = "id" ></ param >
        [Test]
        [TestCase(100)]
        public void Should_Get_Single_Category_From_ID(int id)
        {
            var netoStore = GetStoreManager();

            var filter = new GetCategoryFilter(id);

            Category[] result = netoStore.Categories.GetCategory(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Length);
        }

        /// <summary>
        /// Test retrieval of limited categories with N limit
        /// </summary>
        /// <param name="limit"></param>
        [Test]
        [TestCase(3)]
        public void Should_Get_N_Limit_Categories(int limit)
        {
            var netoStore = GetStoreManager();

            var filter = new GetCategoryFilter();
            filter.DateUpdatedFrom = DateTime.Now.Add(-TimeSpan.FromDays(100));
            filter.Limit = limit;

            Category[] result = netoStore.Categories.GetCategory(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(limit, result.Length);
        }
        #endregion

        #region AddCategory

        [Test]
        /// <summary>
        /// Test add category
        /// </summary>
        public void Should_Add_Single_Category()
        {
            var netoStore = GetStoreManager();

            Category[] category = new Category[] {
               GetTestAddCategory()
            };

            var result = netoStore.Categories.AddCategory(category);

            Assert.IsNotNull(result);            
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Category.Count, 1);
        }

        /// <summary>
        /// Test add multiple categories
        /// </summary>
        public void Should_Add_Multiple_Categories()
        {
            var netoStore = GetStoreManager();

            Category[] category = new Category[] {
               GetTestAddCategory(),
               GetTestAddCategory(),
               GetTestAddCategory()
            };

            var result = netoStore.Categories.AddCategory(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Category.Count, 3);
        }


        #endregion

        #region UpdateCategory

        /// <summary>
        /// Test update a category
        /// </summary>
        /// <param name="categoryID"></param>
        [Test]
        [TestCase(105)]
        public void Should_Update_Category(int categoryID)
        {
            var netoStore = GetStoreManager();

            var category = new Category[] {
               new Category
               {
                   CategoryID = categoryID,
                   CategoryName = "Clothing Updated"
               }
            };

            var result = netoStore.Categories.UpdateCategory(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Category.Count, 1);
        }
        #endregion

    }
}
