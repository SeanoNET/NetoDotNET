using NetoDotNET.Entities;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources.Customers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class CustomerTests : NetoBaseTests
    {

        private Customer GetTestAddCategory()
        {
            Random random = new Random();
            return new Customer
            {
                Username = $"NetoDotNET_Test_{random.Next(0, 999).ToString()}",
                EmailAddress = "noemail@noemail.com"
            };
        }

        #region Filters
        /// <summary>
        /// Tests that <see cref="NetoRequestException"/> is thrown when an invalid <see cref="GetCustomeryFilter"/> is provided
        /// </summary>
        [Test]
        public void Should_Throw_On_InValid_GetCustomerFilter()
        {
            var netoStore = GetStoreManager();
            var filter = new GetCustomerFilter();
            Assert.Throws<NetoRequestException>(() => netoStore.Customers.GetCustomer(filter));
        }
        #endregion

        #region GetCustomer
        /// <summary>
        /// Test retrieval of single customer using username
        /// </summary>
        /// <param name = "username" ></ param >
        [Test]
        [TestCase("SAMPLE_John")]
        public void Should_Get_Single_Category_From_ID(string username)
        {
            var netoStore = GetStoreManager();

            var filter = new GetCustomerFilter(username);

            Customer[] result = netoStore.Customers.GetCustomer(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Length);
        }
        #endregion
    }
}
