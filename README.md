# NetoDotNET [![Build Status](https://dev.azure.com/SeanoNET/NetoDotNET/_apis/build/status/SeanoNET.NetoDotNET?branchName=master)](https://dev.azure.com/SeanoNET/NetoDotNET/_build/latest?definitionId=1&branchName=master)
A .NET Client wrapper for the Neto API. See [Neto API Documentation](https://developers.neto.com.au/documentation/engineers/api-documentation)



**Currently WIP**

## Getting Started

### Configure StoreManager

```csharp
var neto = new StoreManager("STORE_NAME", "NETO_API_KEY", "NETO_USERNAME");
```

#### Using appsettings

1. Copy `appsettings.example.json` and rename it to `appsettings.json`
2. Set your `NETO_STORENAME`, `NETO_API_KEY`, `NETO_USERNAME`

```JSON
{
  "NETO_STORENAME": "<YOUR_NETO_STORE_NAME>",
  "NETO_API_KEY": "<YOUR_NETO_API_KEY>",
  "NETO_USERNAME": "<YOUR_NETO_USERNAME>"
}
```
3. Install [Microsoft.Extensions.Configuration](https://www.nuget.org/packages/Microsoft.Extensions.Configuration/) nuget package 

```
Install-Package Microsoft.Extensions.Configuration -Version 2.2.0
```

Configure `StoreManager` using the config values from `appsettings.json`

```csharp
// Load from configuration
var configBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", true, true);

var config = configBuilder.Build();

var neto = new StoreManager(config.GetSection("NETO_STORENAME").Value, config.GetSection("NETO_API_KEY").Value, config.GetSection("NETO_USERNAME").Value);
```

See [Microsoft.Extensions.Configuration](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration?view=aspnetcore-2.2)

## Implementation Status

|Resource| Complete|
|---|---|
|Accounting System| 0%|
| Orders / Invoices| 0%|
|Payments| 0%|
|RMA| 0%|
|[Products](https://developers.neto.com.au/documentation/engineers/api-documentation/products) |**100%**|
|Categories |0%|
|Warehouses |0%|
|Content |0%|
|Currency| 0%|
|Customers |0%|
|Shipping |0%|
|Suppliers |0%|
|Voucher |0%|
|Cart |0%|
|Notification Events (Webhooks) |0%|

## Examples

- [Products](#products)


### Products

#### List products

Retrieve products that have an id equal to 1, 2 or 3.

```csharp
var filter = new GetItemFilter(new int[] { 1, 2, 3 });

Item[] result = neto.Products.GetItem(filter);

foreach (Item i in result)
{
    Console.WriteLine($"{i.ID} - {i.Name}");
}
```

#### Add a product

Add a new product.

```csharp
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
```

#### Update a product

Update an existing product.

```csharp
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
```

## Contributing

### Running Tests

Add `appsettings.json` to `NetoDotNET.Test` see [Using appsettingsjson](#using-appsettings)

> Integration tests use real data inside of your Neto store. If tests fail it may be because the resource not longer exists or is out of sync