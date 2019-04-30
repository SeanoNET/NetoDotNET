using Microsoft.Extensions.Configuration;
using NetoDotNET.Objects;
using NetoDotNET.Resources;
using System;
using System.IO;

namespace NetoDotNET.Examples
{
    class Program
    {

        static void Main(string[] args)
        {
            // Load configuration
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);

            var config = configBuilder.Build();

            Console.WriteLine($"Loaded Configuration:" + Environment.NewLine +
                $"Neto Store Name: {config.GetSection("NETO_STORENAME").Value}" + Environment.NewLine +
                $"Neto API Key: {config.GetSection("NETO_API_KEY").Value}" + Environment.NewLine +
                $"Neto Username: {config.GetSection("NETO_USERNAME").Value}");

            var neto = new StoreManager(config.GetSection("NETO_STORENAME").Value, config.GetSection("NETO_API_KEY").Value, config.GetSection("NETO_USERNAME").Value);

            // Get Items
            //GetItems(neto);

            // Add Item
            // AddItems(neto);

            // Update Item
            UpdateItems(neto);

        }
        static void UpdateItems(StoreManager neto)
        {
            Item[] item = new Item[] {
                new Item {
                    Name = "Test Item - Updated",
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
                    Name = "Test Item",
                    SKU = "1234",
                    DefaultPrice = "1.00",
                    //Virtual = "sdf"
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
        static void GetItems(StoreManager neto)
        {
            var filter = new GetItemFilter(new int[] { 1, 2, 3 });
    
            Item[] result = neto.Products.GetItem(filter);

            foreach (Item i in result)
            {
                Console.WriteLine($"{i.ID} - {i.Name}");
            }

        }
    }
}
