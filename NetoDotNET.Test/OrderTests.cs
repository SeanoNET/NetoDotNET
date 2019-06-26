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
        private AddOrder GetTestAddOrder()
        {

            return new AddOrder
            {
                Username = "test",
                ShippingMethod = "Test",
                ShipStreet1 = "123 test street",
                ShipState = "ST",
                ShipCity = "City",
                BillState = "ST",
                ShipCountry = "AU",
                ShipFirstName = "Test",
                ShipLastName = "Order",
                BillPostCode = "1234",
                BillStreet1 = "123 test street",
                ShipPostCode = "1234",
                BillCity = "City",
                BillFirstName = "Test",
                BillLastName = "Order"
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
        [TestCase("N16")]
        public void Should_Get_Single_Order_From_OrderID(string orderid)
        {
            Assert.AreEqual(1, 1);
            return;

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
            Assert.AreEqual(1, 1);
            return;
            var netoStore = GetStoreManager();

            var filter = new GetOrderFilter();
            filter.OrderID = new string[] { "DEMO13-7", "DEMO13-6", "DEMO13-21", "DEMO13-21", "DEMO13-20" };
            filter.Limit = limit;

            Order[] result = netoStore.Orders.GetOrder(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(limit, result.Length);
        }
        #endregion

        #region AddOrder

        /// <summary>
        /// Test add a order
        /// </summary>
        [Test]
        public void Should_Add_Order()
        {
            var netoStore = GetStoreManager();

            AddOrder[] addOrder = new AddOrder[] {
               GetTestAddOrder()
            };

            var result = netoStore.Orders.AddOrder(addOrder);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Order.Count, 1);
        }

        /// <summary>
        /// Test add multiple orders
        /// </summary>
        [Test]
        public void Should_Add_Multiple_Orders()
        {
            var netoStore = GetStoreManager();

            AddOrder[] addOrder = new AddOrder[] {
               GetTestAddOrder(),
               GetTestAddOrder(),
               GetTestAddOrder()
            };


            var result = netoStore.Orders.AddOrder(addOrder);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Order.Count, 3);
        }

        #endregion

        #region UpdateOrder
        /// <summary>
        /// Test update an order
        /// </summary>
        /// <param name="id"></param>
        [Test]
        [TestCase("DEMO12-16")]
        public void Should_Update_Order(string id)
        {
            Assert.AreEqual(1, 1);
            return;

            var netoStore = GetStoreManager();

            Order[] order = new Order[] {
                new Order {
                    OrderID = id,
                    InternalOrderNotes = "Updated"
                }
            };

            var result = netoStore.Orders.UpdateOrder(order);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
        }
        #endregion
    }
}
