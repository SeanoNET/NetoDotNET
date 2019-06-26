using NetoDotNET.Entities;
using NetoDotNET.Entities.Customers.CustomerLog;
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

        private Customer GetTestAddCustomer()
        {
            Random random = new Random();
            return new Customer
            {
                Username = $"NetoDotNET_Test_{random.Next(0, 99999).ToString()}",
                EmailAddress = $"noemail{random.Next(0, 99999).ToString()}@noemail.com"
            };
        }

        private CustomerLog GetTestAddCustomerLog()
        {
            return new CustomerLog
            {
                Username = "test",
                DateRequiredFollowUp = DateTime.Now.AddDays(14),
                Notes = "Example customer log",
                Status = Status.RequireRecontact
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
        [TestCase("test")]
        public void Should_Get_Single_Customer_From_Username(string username)
        {
            var netoStore = GetStoreManager();

            var filter = new GetCustomerFilter(username);

            Customer[] result = netoStore.Customers.GetCustomer(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Length);
        }
        #endregion

        #region AddCustomer
        /// <summary>
        /// Test add a customer
        /// </summary>
        [Test]
        public void Should_Add_Customer()
        {
            var netoStore = GetStoreManager();

            Customer[] customer = new Customer[] {
               GetTestAddCustomer()
            };

            var result = netoStore.Customers.AddCustomer(customer);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Customer.Count, 1);
        }

        /// <summary>
        /// Test add multiple customers
        /// </summary>
        [Test]
        public void Should_Add_Multiple_Customers()
        {
            var netoStore = GetStoreManager();

            Customer[] customers = new Customer[] {
               GetTestAddCustomer(),
               GetTestAddCustomer(),
               GetTestAddCustomer()
            };

            var result = netoStore.Customers.AddCustomer(customers);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Customer.Count, 3);
        }
        #endregion

        #region UpdateCustomer
        /// <summary>
        /// Test update a customer
        /// </summary>
        /// <param name="username"></param>
        [Test]
        [TestCase("test")]
        public void Should_Update_Customer(string username)
        {
            var netoStore = GetStoreManager();

            Customer[] customer = new Customer[] {
                new Customer {
                   Username = username,
                   BillingAddress = new BillingAddress
                   {
                       BillFirstName = "Test Updated"
                   }
                }
            };

            var result = netoStore.Customers.UpdateCustomer(customer);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
        }
        #endregion

        #region AddCustomerLog
        /// <summary>
        /// Test add a customer log to existing customer
        /// </summary>
        [Test]
        public void Should_Add_CustomerLog()
        {
            var netoStore = GetStoreManager();

            Entities.Customers.CustomerLog.CustomerLogs customerLogs = new Entities.Customers.CustomerLog.CustomerLogs
            {
                CustomerLog = new CustomerLog[] {
                    GetTestAddCustomerLog()
                }
            };

            var result = netoStore.Customers.AddCustomerLog(customerLogs);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.CustomerLog.Count, 1);
        }

        /// <summary>
        /// Test add multiple customer logs to customer
        /// </summary>
        [Test]
        public void Should_Add_Multiple_CustomerLogs_To_Customer()
        {
            var netoStore = GetStoreManager();

            Entities.Customers.CustomerLog.CustomerLogs customerLogs = new Entities.Customers.CustomerLog.CustomerLogs
            {
                CustomerLog = new CustomerLog[] {
                    GetTestAddCustomerLog(),
                    GetTestAddCustomerLog(),
                    GetTestAddCustomerLog()
                }
            };

            var result = netoStore.Customers.AddCustomerLog(customerLogs);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.CustomerLog.Count, 3);
        }
        #endregion

        #region UpdateCustomerLog
        /// <summary>
        /// Test update a customer log
        /// </summary>
        /// <param name="logid"></param>
        [Test]
        [TestCase(1)]
        public void Should_Update_CustomerLog(int logid)
        {
            var netoStore = GetStoreManager();

            Entities.Customers.CustomerLog.CustomerLogs customerLogs = new Entities.Customers.CustomerLog.CustomerLogs
            {
                CustomerLog = new CustomerLog[] {
                    new CustomerLog {
                        LogID = logid,
                        Username = "test",
                        DateRequiredFollowUp = DateTime.Now.AddDays(21),
                        Notes = "Example customer log updated",
                        Status = Status.RequireRecontact
                    }
                }
            };


            var result = netoStore.Customers.UpdateCustomerLog(customerLogs);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
        }
        #endregion
    }
}
