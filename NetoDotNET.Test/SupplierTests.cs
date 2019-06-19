using NetoDotNET.Entities;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources.Supplier;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class SupplierTests : NetoBaseTests
    {



        #region Filters
        /// <summary>
        /// Tests that <see cref="NetoRequestException"/> is thrown when an invalid <see cref="GetSupplierFilter"/> is provided
        /// </summary>
        [Test]
        public void Should_Throw_On_InValid_GetSupplierFilter()
        {
            var netoStore = GetStoreManager();
            var filter = new GetSupplierFilter();
            Assert.Throws<NetoRequestException>(() => netoStore.Suppliers.GetSupplier(filter));
        }
        #endregion

        #region GetSupplier

        /// <summary>
        /// Test retrieval of single supplier using ID
        /// </summary>
        /// <param name = "id" ></ param >
        [Test]
        [TestCase("124")]
        public void Should_Get_Single_Supplier_From_ID(string id)
        {
            var netoStore = GetStoreManager();

            var filter = new GetSupplierFilter(id);

            List<Suppliers> result = netoStore.Suppliers.GetSupplier(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }
        #endregion

    }
}
