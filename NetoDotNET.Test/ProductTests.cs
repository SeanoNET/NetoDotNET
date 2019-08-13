using NetoDotNET.Entities;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources.Products;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NetoDotNET.Test
{
    class ProductTests : NetoBaseTests
    {
       

        private NewItem GetTestAddProduct()
        {
            Random random = new Random();
            return new NewItem
            {
                Name = "NetoDotNET.Test - Test Add Item",
                SKU = random.Next(1000, 99999).ToString(),
                DefaultPrice = 1.00m
            };
        }

        private NewItem GetTestAddProductWithImages()
        {
            NewItem item = GetTestAddProduct();
            item.Images = new Images
            {
                Image = new List<Image> {
                    new Image { Name = "Main", URL = "https://dummyimage.com/600x400/000/fff" },
                    new Image { Name = "Alt 1", URL = "https://dummyimage.com/600x400/000/fff" },
                    new Image { Name = "Alt 2", URL = "https://dummyimage.com/600x400/000/fff" }
                }
            };

            return item;
        }

        private NewItem[] GetTestAddVariableProduct()
        {
            Random random = new Random();
            string parentSKU = random.Next(10000, 99999).ToString();

            return new NewItem[] {
                new NewItem {
                    Name = "NetoDotNET.Test - Test Add Variable Item",
                    SKU = parentSKU,
                    DefaultPrice = 1.00m,
                },
                new NewItem {
                    Name = "NetoDotNET.Test - Test Add Variable Item",
                    SKU = random.Next(1000, 9999).ToString(),
                    DefaultPrice = 1.00m,
                    ParentSKU = parentSKU
                },
                new NewItem {
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

            NewItem[] item = new NewItem[] {
               GetTestAddProduct()
            };

            var result = netoStore.Products.AddItem(item);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Item.Count, 1);
        }

        /// <summary>
        /// Test add a product with 3 images
        /// </summary>
        [Test]
        public void Should_Add_Product_With_Images()
        {
            var netoStore = GetStoreManager();

            NewItem[] item = new NewItem[] {
               GetTestAddProductWithImages()
            };

            var result = netoStore.Products.AddItem(item);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Item.Count, 1);


            // Check for 3 images
            var filter = new GetItemFilter(Convert.ToInt32(result.Item[0].InventoryID));

            Item[] imageResult = netoStore.Products.GetItem(filter);
            Assert.AreEqual(imageResult.Length, 1);
            Assert.AreEqual(imageResult[0].Images.Count, 3);
        }

        /// <summary>
        /// Test add multiple products
        /// </summary>
        [Test]
        public void Should_Add_Multiple_Products()
        {
            var netoStore = GetStoreManager();

            NewItem[] item = new NewItem[] {
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

            NewItem[] item = GetTestAddVariableProduct();

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
        [TestCase("1234")]
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
