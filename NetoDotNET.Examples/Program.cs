using Microsoft.Extensions.Configuration;
using NetoDotNET.Entities;
using NetoDotNET.Resources.Products;
using NetoDotNET.Resources.Categories;
using System;
using System.IO;
using NetoDotNET.Resources.Customers;
using NetoDotNET.Entities.Customers.CustomerLog;
using NetoDotNET.Resources.Orders;
using NetoDotNET.Resources.Contents;
using NetoDotNET.Resources.RMA;
using System.Collections.Generic;
using NetoDotNET.Resources.Warehouses;
using NetoDotNET.Resources.Payments;

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
            //GetItems(neto);
            //GetItemsFromDate(neto);

            //AddItems(neto);
            //AddVariableItems(neto);

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
            //UpdateOrder(neto);
            #endregion

            #region Content
            //GetContent(neto);
            //AddContent(neto);
            //UpdateContent(neto);
            #endregion

            #region RMA
            //GetRMA(neto);
            #endregion

            #region Warehouses
            //GetWarehouse(neto);
            //UpdateWarehouse(neto);
            //AddWarehouse(neto);
            #endregion

            #region Payments
            //GetPayment(neto);
            //AddPayment(neto);
            //GetPaymentMethods(neto);
            #endregion

            #region Currency
            GetCurrenctSettings(neto);
            #endregion
        }
        static void GetCurrenctSettings(StoreManager neto)
        {
            var result = neto.Currency.GetCurrencySettings();

            foreach (CurrencySettings i in result)
            {
                Console.WriteLine($"{i.DefaultCountry} - {i.DefaultCurrency}");
            }
        }
        static void GetPaymentMethods(StoreManager neto)
        {
            var result = neto.Payment.GetPaymentMethods();

            foreach (PaymentMethod i in result.PaymentMethod)
            {
                Console.WriteLine($"{i.ID} - {i.Name}");
            }
        }
        static void AddPayment(StoreManager neto)
        {
            AddPayment[] payment = new AddPayment[] {
                new AddPayment {
                    OrderID = "DEMO15-9",
                    CardAuthorisation = "1234",
                    AmountPaid = 0.1M
                }
            };

            var result = neto.Payment.AddPayment(payment);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Payment)
                    {
                        Console.WriteLine($"Created ID:{i.PaymentID} PaymentMethodName: {i.PaymentMethodName} at {result.CurrentTime}");
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
        static void GetPayment(StoreManager neto)
        {
            var filter = new GetPaymentFilter();
            filter.DatePaidFrom = DateTime.Now.Add(-TimeSpan.FromDays(5));

            var result = neto.Payment.GetPayment(filter);

            foreach (Payment i in result)
            {
                Console.WriteLine($"{i.PaymentID} - {i.PaymentMethodName}");
            }
        }
        static void AddWarehouse(StoreManager neto)
        {
            Warehouse[] warehouse = new Warehouse[] {
                new Warehouse {
                   WarehouseName = "A New Warehouse 4",
                   WarehouseReference = "W4",
                   IsPrimary = true
                }
            };

            var result = neto.Warehouses.AddWarehouse(warehouse);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Warehouse)
                    {
                        Console.WriteLine($"Created ID:{i.WarehouseID} WarehouseReference: {i.WarehouseReference} at {result.CurrentTime}");
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
        static void UpdateWarehouse(StoreManager neto)
        {
            Warehouse[] warehouse = new Warehouse[] {
                new Warehouse {
                    WarehouseID = 1,
                    WarehouseName = "NetoDotNET - Updated"
                }
            };

            var result = neto.Warehouses.UpdateWarehouse(warehouse);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Warehouse)
                    {
                        Console.WriteLine($"Updated ID:{i.WarehouseID} at {result.CurrentTime}");
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
        static void GetWarehouse(StoreManager neto)
        {
            var filter = new GetWarehouseFilter(1);

            var result = neto.Warehouses.GetWarehouse(filter);

            foreach (Warehouse i in result)
            {
                Console.WriteLine($"{i.WarehouseID} - {i.WarehouseName}");
            }
        }
        static void GetRMA(StoreManager neto)
        {
            var filter = new GetRMAFilter(1);

            var result = neto.RMA.GetRMA(filter);

            foreach (Rma i in result)
            {
                Console.WriteLine($"{i.RmaID}");
            }
        }
        static void UpdateContent(StoreManager neto)
        {
            var updateContent = new Content[] {
               new Content
               {
                   ContentID = 105,
                   ContentName = "Clothing Updated"
               }
            };

            var result = neto.Content.UpdateContent(updateContent);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Content)
                    {
                        Console.WriteLine($"Updated ID: {i.ContentID}");
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
        static void AddContent(StoreManager neto)
        {
            Content[] content = new Content[] {
                new Content {
                  ContentName = "New content category",
                  ContentType = "Category"
                }
            };

            var result = neto.Content.AddContent(content);

            switch (result.Ack)
            {
                case Ack.Success:
                    foreach (var i in result.Content)
                    {
                        Console.WriteLine($"Created ID:{i.ContentID} at {result.CurrentTime}");
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
        static void GetContent(StoreManager neto)
        {
            var filter = new GetContentFilter(new string[] { "105", "129", "128" });

            Content[] result = neto.Content.GetContent(filter);

            foreach (Content i in result)
            {
                Console.WriteLine($"{i.ContentID} - {i.ContentName}");
            }
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
