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
    }
}
