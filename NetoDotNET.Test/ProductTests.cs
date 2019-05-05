using NetoDotNET.Entities;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class ProductTests : NetoTest
    {

        private Item GetTestProduct()
        {
            return new Item
            {
                Name = "NetoDotNET.Test - Test Item",
                SKU = "DEFAULT1234"
            };
        }


        #region Filters
        /// <summary>
        /// Tests that <see cref="NetoRequestException"/> is thrown when an invalid <see cref="GetItemFilter"/> is provided
        /// </summary>
        [Test]
        public void Should_Throw_On_InValid_GetItemFilter()
        {
            var filter = new GetItemFilter();
            Assert.Throws<NetoRequestException>(() => netoStore.Products.GetItem(filter));
        }
        #endregion





        #region GetItems

        /// <summary>
        /// Test retrieval of single product using ID
        /// </summary>
        /// <param name="id"></param>
        [Test]
        [TestCase(1)]
        public void Should_Get_Single_Product_From_ID(int id)
        {
            var filter = new GetItemFilter(id);

            Item[] result = netoStore.Products.GetItem(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Length);
        }


        /// <summary>
        /// Test retrieval of limited products with N limit
        /// </summary>
        /// <param name="limit"></param>
        [Test]
        [TestCase(3)]
        public void Should_Get_N_Limit_Products(int limit)
        {
            var filter = new GetItemFilter();
            filter.DateAddedFrom = DateTime.Now.Add(-TimeSpan.FromDays(100));
            filter.Limit = limit;

            Item[] result = netoStore.Products.GetItem(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(limit, result.Length);
        }
        #endregion


    }
}
