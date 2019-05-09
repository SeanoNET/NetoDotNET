using NetoDotNET.Entities;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace NetoDotNET.Test
{
    class ProductTests : NetoTest
    {
        public StoreManager GetStoreManager()
        {
            string NETO_STORENAME = Environment.GetEnvironmentVariable("NetoStoreName");
            string NETO_API_KEY = Environment.GetEnvironmentVariable("NetoApiKey");
            string NETO_USERNAME = Environment.GetEnvironmentVariable("NetoUsername");

            if (String.IsNullOrEmpty(NETO_STORENAME) || String.IsNullOrEmpty(NETO_API_KEY) || String.IsNullOrEmpty(NETO_USERNAME))
            {
                // Load from configuration
                var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true);

                var config = configBuilder.Build();

                NETO_STORENAME = config.GetSection("NETO_STORENAME").Value;
                NETO_API_KEY = config.GetSection("NETO_API_KEY").Value;
                NETO_USERNAME = config.GetSection("NETO_USERNAME").Value;

                Console.WriteLine($"Loaded Configuration:" + Environment.NewLine +
                    $"Neto Store Name: {NETO_STORENAME}" + Environment.NewLine +
                    $"Neto API Key: {NETO_API_KEY}" + Environment.NewLine +
                    $"Neto Username: {NETO_USERNAME}");
            }

            return new StoreManager(NETO_STORENAME, NETO_API_KEY, NETO_USERNAME);

        }
        [Test]
        public void HasStoreEnvVariable()
        {
            string testKey = Environment.GetEnvironmentVariable("NetoStoreName");

            Assert.IsNotNull(testKey, "Key not set as environment variable");
            Assert.AreNotEqual(testKey, "");
        }
        private Item GetTestAddProduct()
        {
            Random random = new Random();
            return new Item
            {
                Name = "NetoDotNET.Test - Test Add Item",
                SKU = random.Next(1000, 9999).ToString(),
                DefaultPrice = 1.00m
            };
        }

        private Item[] GetTestAddVariableProduct()
        {
            Random random = new Random();
            string parentSKU = random.Next(10000, 99999).ToString();

            return new Item[] {
                new Item {
                    Name = "NetoDotNET.Test - Test Add Variable Item",
                    SKU = parentSKU,
                    DefaultPrice = 1.00m,
                },
                new Item {
                    Name = "NetoDotNET.Test - Test Add Variable Item",
                    SKU = random.Next(1000, 9999).ToString(),
                    DefaultPrice = 1.00m,
                    ParentSKU = parentSKU
                },
                new Item {
                    Name = "NetoDotNET.Test - Test Add Variable Item",
                    SKU = random.Next(1000, 9999).ToString(),
                    DefaultPrice = 1.00m,
                    ParentSKU = parentSKU
                }
            };
        }

        #region Filters
        /// <summary>
        /// Tests that <see cref="NetoRequestException"/> is thrown when an invalid <see cref="GetItemFilter"/> is provided
        /// </summary>
        [Test]
        public void Should_Throw_On_InValid_GetItemFilter()
        {
            var netoStore = GetStoreManager();
            var filter = new GetItemFilter();
            Assert.Throws<NetoRequestException>(() => netoStore.Products.GetItem(filter));
        }
        #endregion

        #region GetItems

        /// <summary>
        /// Test retrieval of single product using ID
        /// </summary>
        /// <param name = "id" ></ param >
        [Test]
        [TestCase(1)]
        public void Should_Get_Single_Product_From_ID(int id)
        {
            var netoStore = GetStoreManager();

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
            var netoStore = GetStoreManager();

            var filter = new GetItemFilter();
            filter.DateAddedFrom = DateTime.Now.Add(-TimeSpan.FromDays(100));
            filter.Limit = limit;

            Item[] result = netoStore.Products.GetItem(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(limit, result.Length);
        }
        #endregion

        #region AddItem

        /// <summary>
        /// Test add a product
        /// </summary>
        [Test]
        public void Should_Add_Product()
        {
            var netoStore = GetStoreManager();

            Item[] item = new Item[] {
               GetTestAddProduct()
            };

            var result = netoStore.Products.AddItem(item);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
        }

        /// <summary>
        /// Test add multiple products
        /// </summary>
        [Test]
        public void Should_Add_Multiple_Products()
        {
            var netoStore = GetStoreManager();

            Item[] item = new Item[] {
               GetTestAddProduct(),
               GetTestAddProduct(),
               GetTestAddProduct()
            };

            var result = netoStore.Products.AddItem(item);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Item.Count, 3);
        }

        /// <summary>
        /// Test add variable product
        /// </summary>
        [Test]
        public void Should_Add_Variable_Product()
        {
            var netoStore = GetStoreManager();

            Item[] item = GetTestAddVariableProduct();

            var result = netoStore.Products.AddItem(item);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Item.Count, 3);
        }

        #endregion

        #region UpdateItem

        /// <summary>
        /// Test update a product
        /// </summary>
        /// <param name="sku"></param>
        [Test]
        [TestCase("12345")]
        public void Should_Update_Product(string sku)
        {
            var netoStore = GetStoreManager();

            Item[] item = new Item[] {
                new Item {
                    Name = "My New Item - Updated",
                    SKU = sku
                }
            };

            var result = netoStore.Products.UpdateItem(item);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
        }
        #endregion

    }
}
