using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NetoDotNET.Test
{
    internal class NetoBaseTests
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
    }
}
