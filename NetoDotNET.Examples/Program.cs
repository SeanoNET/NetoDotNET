using Microsoft.Extensions.Configuration;
using NetoDotNET.Resources;
using Newtonsoft.Json;
using System;
using System.IO;
using static NetoDotNET.Resources.GetItemFilter;

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
            var filter = new GetItemFilter(1);
            filter.OutputSelector = new GetItemFilterOutputSelector[] { GetItemFilterOutputSelector.ID, GetItemFilterOutputSelector.ParentSKU, GetItemFilterOutputSelector.DateAdded };

          


            var result = neto.Products.GetItem(filter);

            Console.WriteLine(result);

        }
    }
}
