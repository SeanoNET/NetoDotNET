using NetoDotNET.Entities.Categories;
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

        #region Filters
        /// <summary>
        /// Tests that <see cref="NetoRequestException"/> is thrown when an invalid <see cref="GetItemFilter"/> is provided
        /// </summary>
        [Test]
        public void Should_Throw_On_InValid_GetItemFilter()
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

    }
}
