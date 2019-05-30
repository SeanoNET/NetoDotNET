using NetoDotNET.Entities;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources.Products;
using NUnit.Framework;
using System;

namespace NetoDotNET.Test
{
    class ProductTests : NetoBaseTests
    {
       

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
            Assert.AreEqual(result.Item.Count, 1);
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
        [TestCase("9397")]
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
