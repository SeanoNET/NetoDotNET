using NetoDotNET.Entities;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources.Warehouses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class WarehouseTests : NetoBaseTests
    {

        private Warehouse GetTestAddWarehouse()
        {
            Random random = new Random();
            string id = random.Next(1000, 99999).ToString();
            return new Warehouse
            {
                WarehouseName = "A New Warehouse - " + id,
                WarehouseReference = "W" + id,
                IsPrimary = true
            };
        }

        #region Filters
        /// <summary>
        /// Tests that <see cref="NetoRequestException"/> is thrown when an invalid <see cref="GetWarehouseFilter"/> is provided
        /// </summary>
        [Test]
        public void Should_Throw_On_InValid_GetWarehouseFilter()
        {
            var netoStore = GetStoreManager();
            var filter = new GetWarehouseFilter();
            Assert.Throws<NetoRequestException>(() => netoStore.Warehouses.GetWarehouse(filter));
        }
        #endregion

        #region GetWarehouses

        /// <summary>
        /// Test retrieval of single warehouse using ID
        /// </summary>
        /// <param name = "id" ></ param >
        [Test]
        [TestCase(1)]
        public void Should_Get_Single_Warehouse_From_ID(int id)
        {
            var netoStore = GetStoreManager();

            var filter = new GetWarehouseFilter(id);

            Warehouse[] result = netoStore.Warehouses.GetWarehouse(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Length);
        }
        #endregion

        #region UpdateWarehouse

        /// <summary>
        /// Test update a warehouse
        /// </summary>
        /// <param name="id"></param>
        [Test]
        [TestCase(1)]
        public void Should_Update_Warehouse(int id)
        {
            var netoStore = GetStoreManager();

            Warehouse[] warehouse = new Warehouse[] {
                new Warehouse {
                    WarehouseID = 1,
                    WarehouseName = "NetoDotNET - Updated"
                }
            };

            var result = netoStore.Warehouses.UpdateWarehouse(warehouse);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
        }
        #endregion

        #region AddWarehouse
        /// <summary>
        /// Test add a warehouse
        /// </summary>
        [Test]
        public void Should_Add_Warehouse()
        {
            var netoStore = GetStoreManager();

            Warehouse[] warehouse = new Warehouse[] {
                GetTestAddWarehouse()
            };

            var result = netoStore.Warehouses.AddWarehouse(warehouse);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Warehouse.Count, 1);
        }
        #endregion
    }
}
