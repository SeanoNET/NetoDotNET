using Microsoft.Extensions.Configuration;
using NetoDotNET.Entities;
using NetoDotNET.Resources.Products;
using NetoDotNET.Resources.Categories;
using System;
using System.IO;
using NetoDotNET.Resources.Customers;
using NetoDotNET.Entities.Customers.CustomerLog;
using NetoDotNET.Resources.Orders;

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
            //GetCustomers(neto);
            //AddCustomers(neto);
            //UpdateCustomer(neto);
            //AddCustomerLog(neto);
            //UpdateCustomerLog(neto);
            #endregion

            #region Orders
            //GetOrders(neto);
            //AddOrders(neto);
            UpdateOrder(neto);
            #endregion
        }
        static void UpdateOrder(StoreManager neto)
        {
            Order[] order = new Order[] {
                new Order {
                    OrderID = "DEMO12-16",
                    InternalOrderNotes = "Updated"
                }
            };

            var result = neto.Orders.UpdateOrder(order);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Order)
                    {
                        Console.WriteLine($"Updated ID:{i.OrderID} at {result.CurrentTime}");
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
        static void AddOrders(StoreManager neto)
        {
            AddOrder[] addOrder = new AddOrder[] {
                new AddOrder {
                    Username = "test",
                    ShippingMethod = "Test",
                    ShipStreet1 = "123 test street",
                    ShipState = "ST",
                    ShipCity = "City",
                    BillState = "ST",
                    ShipCountry = "AU",
                    ShipFirstName = "Test",
                    ShipLastName = "Order",
                    BillPostCode = "1234",
                    BillStreet1 = "123 test street",
                    ShipPostCode = "1234",
                    BillCity = "City",
                    BillFirstName ="Test",
                    BillLastName = "Order"
                }
            };

            var result = neto.Orders.AddOrder(addOrder);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Order)
                    {
                        Console.WriteLine($"Created ID:{i.OrderID} at {result.CurrentTime}");
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
        static void GetOrders(StoreManager neto)
        {
            var filter = new GetOrderFilter("DEMO13-7");

            Order[] result = neto.Orders.GetOrder(filter);

            foreach (Order i in result)
            {
                Console.WriteLine($"{i.OrderID} - {i.GrandTotal}");
            }
        }
        static void UpdateCustomerLog(StoreManager neto)
        {
            Entities.Customers.CustomerLog.CustomerLogs customerLogs = new Entities.Customers.CustomerLog.CustomerLogs
            {
                CustomerLog = new CustomerLog[] {
                    new CustomerLog {
                        LogID = 1,
                        Username = "test",
                        DateRequiredFollowUp = DateTime.Now.AddDays(21),
                        Notes = "Example customer log updated",
                        Status = Status.RequireRecontact
                    }
                }
            };


            var result = neto.Customers.UpdateCustomerLog(customerLogs);

            switch (result.Ack)
            {
                case Ack.Success:
                    Console.WriteLine($"Updated Customer log at {result.CurrentTime}");
                    break;

                case Ack.Warning:
                    foreach (var warn in result.Messages.Warning)
                    {
                        Console.WriteLine($"Warning: {warn.Message}");
                    }
                    break;
            }
        }
        static void AddCustomerLog(StoreManager neto)
        {
            Entities.Customers.CustomerLog.CustomerLogs customerLogs = new Entities.Customers.CustomerLog.CustomerLogs
            {
                CustomerLog = new CustomerLog[] {
                new CustomerLog {
                    Username = "test",
                    DateRequiredFollowUp = DateTime.Now.AddDays(14),
                    Notes = "Example customer log",
                    Status = Status.RequireRecontact
                }
            }
            };


            var result = neto.Customers.AddCustomerLog(customerLogs);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.CustomerLog)
                    {
                        Console.WriteLine($"Created LogId:{i.LogID} at {result.CurrentTime}");
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
        static void UpdateCustomer(StoreManager neto)
        {
            Customer[] customer = new Customer[] {
                new Customer {
                   Username = "test",
                   BillingAddress = new BillingAddress
                   {
                       BillFirstName = "Test Updated"
                   }
                }
            };

            var result = neto.Customers.UpdateCustomer(customer);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Item)
                    {
                        Console.WriteLine($"Updated Username:{i.Username} at {result.CurrentTime}");
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
        static void AddCustomers(StoreManager neto)
        {
            Customer[] customer = new Customer[] {
                new Customer {
                   Username = "test",
                   EmailAddress = "test@test.com",
                   ABN = "123412341234",
                   BillingAddress = new BillingAddress
                   {
                       BillFirstName = "Test",
                       BillLastName = "Customer"
                   }
                }
            };

            var result = neto.Customers.AddCustomer(customer);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Customer)
                    {
                        Console.WriteLine($"Created Username:{i.Username} at {result.CurrentTime}");
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
