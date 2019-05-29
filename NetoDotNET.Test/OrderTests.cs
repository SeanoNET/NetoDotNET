using NetoDotNET.Entities;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources.Orders;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class OrderTests : NetoBaseTests
    {
        private Order GetTestAddOrder()
        {
            Random random = new Random();
            return new Order
            {

            };
        }


        #region Filters
        /// <summary>
        /// Tests that <see cref="NetoRequestException"/> is thrown when an invalid <see cref="GetOrderFilter"/> is provided
        /// </summary>
        [Test]
        public void Should_Throw_On_InValid_GetOrderFilter()
        {
            var netoStore = GetStoreManager();
            var filter = new GetOrderFilter();
            Assert.Throws<NetoRequestException>(() => netoStore.Orders.GetOrder(filter));
        }
        #endregion

        #region GetOrders

        /// <summary>
        /// Test retrieval of single order using ID
        /// </summary>
        /// <param name = "orderid" ></ param >
        [Test]
        [TestCase("DEMO13-7")]
        public void Should_Get_Single_Order_From_OrderID(string orderid)
        {
            var netoStore = GetStoreManager();

            var filter = new GetOrderFilter(orderid);

            Order[] result = netoStore.Orders.GetOrder(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Length);
        }


        /// <summary>
        /// Test retrieval of limited orders with N limit
        /// </summary>
        /// <param name="limit"></param>
        [Test]
        [TestCase(3)]
        public void Should_Get_N_Limit_Orders(int limit)
        {
            var netoStore = GetStoreManager();

            var filter = new GetOrderFilter();
            filter.OrderID = new string[] { "DEMO13-7", "DEMO13-6", "DEMO13-21", "DEMO13-21", "DEMO13-20" };
            filter.Limit = limit;

            Order[] result = netoStore.Orders.GetOrder(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(limit, result.Length);
        }
        #endregion
    }
}
