using Microsoft.Extensions.Configuration;
using NetoDotNET.Entities;
using NetoDotNET.Resources.Products;
using NetoDotNET.Resources.Categories;
using System;
using System.IO;
using NetoDotNET.Resources.Customers;

namespace NetoDotNET.Examples
{
    class Program
    {

        static void Main(string[] args)
        {
            // Load from configuration
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);

            var config = configBuilder.Build();

            Console.WriteLine($"Loaded Configuration:" + Environment.NewLine +
                $"Neto Store Name: {config.GetSection("NETO_STORENAME").Value}" + Environment.NewLine +
                $"Neto API Key: {config.GetSection("NETO_API_KEY").Value}" + Environment.NewLine +
                $"Neto Username: {config.GetSection("NETO_USERNAME").Value}");

            var neto = new StoreManager(config.GetSection("NETO_STORENAME").Value, config.GetSection("NETO_API_KEY").Value, config.GetSection("NETO_USERNAME").Value);

            #region Products
            // Get Items
            //GetItems(neto);
            //GetItemsFromDate(neto);

            // Add Item
            // AddItems(neto);
            //AddVariableItems(neto);

            // Update Item
            //UpdateItems(neto);
            #endregion

            #region Categories
            //GetCategories(neto);
            //AddCategory(neto);
            //UpdateCategory(neto);
            #endregion

            #region Customers
            GetCustomers(neto);
            #endregion
        }

        static void GetCustomers(StoreManager neto)
        {
            var filter = new GetCustomerFilter("SAMPLE_John");

            Customer[] result = neto.Customers.GetCustomer(filter);

            foreach (Customer i in result)
            {
                Console.WriteLine($"{i.ID} - {i.Username}");
            }
        }
        static void UpdateCategory(StoreManager neto)
        {
            var updateCategory = new Category[] {
               new Category
               {
                   CategoryID = 105,
                   CategoryName = "Clothing Updated"
               }
            };

            var result = neto.Categories.UpdateCategory(updateCategory);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Category)
                    {
                        Console.WriteLine($"Updated ID: {i.CategoryID}");
                    }
                    break;

                case Ack.Warning:
                    foreach (var warn in result.Messages.Warning)
                    {
                        Console.WriteLine($"Warning: {warn.Message}");
                    }
                    break;
            }
        }
        static void AddCategory(StoreManager neto)
        {
            var newCategory = new Category[] {
               new Category
               {
                   CategoryName = "Clothing"
               }
            };
       
            var result = neto.Categories.AddCategory(newCategory);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Category)
                    {
                        Console.WriteLine($"Created ID: {i.CategoryID}");
                    }
                    break;

                case Ack.Warning:
                    foreach (var warn in result.Messages.Warning)
                    {
                        Console.WriteLine($"Warning: {warn.Message}");
                    }
                    break;
            }
        }
        static void GetCategories(StoreManager neto)
        {
            var filter = new GetCategoryFilter(new int[] { 98, 99, 100, 101 });

            Category[] result = neto.Categories.GetCategory(filter);

            foreach (Category i in result)
            {
                Console.WriteLine($"{i.CategoryID} - {i.CategoryName}");
            }
        }
        static void UpdateItems(StoreManager neto)
        {
            Item[] item = new Item[] {
                new Item {
                    Name = "My New Item - Updated",
                    SKU = "1234"
                }
            };

            var result = neto.Products.UpdateItem(item);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Item)
                    {
                        Console.WriteLine($"Updated ID:{i.InventoryID} SKU: {i.SKU} at {result.CurrentTime}");
                    }
                    break;

                case Ack.Warning:
                    foreach (var warn in result.Messages.Warning)
                    {
                        Console.WriteLine($"Warning: {warn.Message}");
                    }
                    break;
            }


        }
        static void AddItems(StoreManager neto)
        {
            Item[] item = new Item[] {
                new Item {
                    Name = "My New Item",
                    SKU = "1234",
                    DefaultPrice = 1.00m
                }
            };

            var result = neto.Products.AddItem(item);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Item)
                    {
                        Console.WriteLine($"Created ID:{i.InventoryID} SKU: {i.SKU} at {result.CurrentTime}");
                    }
                    break;

                case Ack.Warning:
                    foreach (var warn in result.Messages.Warning)
                    {
                        Console.WriteLine($"Warning: {warn.Message}");
                    }
                    break;
            }
        }

        static void AddVariableItems(StoreManager neto)
        {
            Item[] variableProduct = new Item[] {
                new Item {
                    Name = "Variable Item",
                    SKU = "VAR",
                    DefaultPrice = 1.00m,
                },
                new Item {
                    Name = "Variable Item",
                    SKU = "VAR1",
                    DefaultPrice = 1.00m,
                    ParentSKU = "VAR"
                },
                new Item {
                    Name = "Variable Item",
                    SKU = "VAR2",
                    DefaultPrice = 1.00m,
                    ParentSKU = "VAR"
                }
            };

            var result = neto.Products.AddItem(variableProduct);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Item)
                    {
                        Console.WriteLine($"Created ID:{i.InventoryID} SKU: {i.SKU} at {result.CurrentTime}");
                    }
                    break;

                case Ack.Warning:
                    foreach (var warn in result.Messages.Warning)
                    {
                        Console.WriteLine($"Warning: {warn.Message}");
                    }
                    break;
            }
        }
        static void GetItems(StoreManager neto)
        {
            var filter = new GetItemFilter(new int[] { 1, 2, 3, 50 });
    
            Item[] result = neto.Products.GetItem(filter);

            foreach (Item i in result)
            {
                Console.WriteLine($"{i.ID} - {i.Name}");
            }
        }

        static void GetItemsFromDate(StoreManager neto)
        {
            var filter = new GetItemFilter();
            filter.DateAddedFrom = DateTime.Now.Add(-TimeSpan.FromDays(100));
            filter.Limit = 2;

            Item[] result = neto.Products.GetItem(filter);

            foreach (Item i in result)
            {
                Console.WriteLine($"{i.ID} - {i.Name}");
            }
        }
    }
}
