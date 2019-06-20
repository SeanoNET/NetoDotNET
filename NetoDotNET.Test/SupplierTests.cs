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

        private Suppliers GetTestAddSupplier()
        {
            Random random = new Random();
            return new Suppliers
            {
                SupplierCompany = "Google - " + random.Next(1000, 9999).ToString(),
                LeadTime1 = 2,
                LeadTime2 = 3,
                SupplierReference = 12345
            };
        }

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

        #region UpdateSupplier

        /// <summary>
        /// Test update an existing supplier
        /// </summary>
        /// <param name="id"></param>
        [Test]
        [TestCase("124")]
        public void Should_Update_Supplier(string id)
        {
            var netoStore = GetStoreManager();

            Suppliers[] supplier = new Suppliers[] {
                new Suppliers {
                    SupplierID = id,
                    SupplierNotes = "Test - Updated",
                    LeadTime1 = 2,
                    LeadTime2 = 3,
                    SupplierReference =  1234
                }
            };

            var result = netoStore.Suppliers.UpdateSupplier(supplier);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
        }
        #endregion

        #region AddSupplier
        /// <summary>
        /// Test add a supplier
        /// </summary>
        [Test]
        public void Should_Add_Supplier()
        {
            var netoStore = GetStoreManager();

            Suppliers[] suppliers = new Suppliers[] {
               GetTestAddSupplier()
            };

            var result = netoStore.Suppliers.AddSupplier(suppliers);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Supplier.Count, 1);
        }
        #endregion

    }
}
