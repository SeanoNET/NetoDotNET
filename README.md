# NetoDotNET [![Build Status](https://travis-ci.org/SeanoNET/NetoDotNET.svg?branch=master)](https://travis-ci.org/SeanoNET/NetoDotNET)
A .NET Client wrapper for the Neto API. See [Neto API Documentation](https://developers.neto.com.au/documentation/engineers/api-documentation)



**Currently WIP**

## Getting Started

Install the [NuGet package](https://www.nuget.org/packages/NetoDotNET.Core/)

`Install-Package NetoDotNET.Core`

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
|[Orders / Invoices](https://developers.neto.com.au/documentation/engineers/api-documentation/orders-invoices)| **100%**|
|[Payments](https://developers.neto.com.au/documentation/engineers/api-documentation/payments)| **100%**|
|[RMA](https://developers.neto.com.au/documentation/engineers/api-documentation/rma)| **100%**|
|[Products](https://developers.neto.com.au/documentation/engineers/api-documentation/products) |**100%**|
|[Categories](https://developers.neto.com.au/documentation/engineers/api-documentation/categories) **deprecated** see [Content](https://developers.neto.com.au/documentation/engineers/api-documentation/content)|**100%**|
|[Warehouses](https://developers.neto.com.au/documentation/engineers/api-documentation/warehouses/) |**100%**|
|[Content](https://developers.neto.com.au/documentation/engineers/api-documentation/content) |**100%**|
|[Currency](https://developers.neto.com.au/documentation/engineers/api-documentation/currency)| **100%**|
|[Customers](https://developers.neto.com.au/documentation/engineers/api-documentation/customers) |**100%**|
|[Shipping](https://developers.neto.com.au/documentation/engineers/api-documentation/shipping) |**100%**|
|[Suppliers](https://developers.neto.com.au/documentation/engineers/api-documentation/suppliers) |**100%**|
|Voucher |0%|
|Cart |0%|
|Notification Events (Webhooks) |0%|

## Examples

- [Products](#products)
- [Categories](#categories)
- [Customers](#customers)
- [Orders](#orders)
- [Other](#other-examples)

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
NewItem[] item = new NewItem[] {
    new NewItem {
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

### Categories

#### List categories

Retrieve a category that has an id equal to 99.

```csharp
var filter = new GetCategoryFilter(99);
```

Retrieve a category that has a category name equal to '[Sample] Product Category'.

```csharp
var filter = new GetCategoryFilter("[Sample] Product Category");
```

```csharp
Category[] result = neto.Categories.GetCategory(filter);

foreach (Category i in result)
{
    Console.WriteLine($"{i.CategoryID} - {i.CategoryName}");
}
```
#### Create a new category

```csharp
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
```

#### Update a category

Update an existing category.

```csharp
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
```

### Customers

#### List customers

Get a customer using a username

```csharp
var filter = new GetCustomerFilter("SAMPLE_John");

Customer[] result = neto.Customers.GetCustomer(filter);

foreach (Customer i in result)
{
    Console.WriteLine($"{i.ID} - {i.Username}");
}
```

#### Create a new customer

```csharp
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
```
#### Update a customer

Update an existing customer.

```csharp
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
```

### Orders

#### List orders

Get an order using an id

```csharp
var filter = new GetOrderFilter("DEMO13-7");

Order[] result = neto.Orders.GetOrder(filter);

foreach (Order i in result)
{
    Console.WriteLine($"{i.OrderID} - {i.GrandTotal}");
}
```

#### Create a new order

```csharp
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
```

#### Update an order

Update an existing order.

```csharp
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
```


### Other Examples

See [Program.cs](NetoDotNET.Examples/Program.cs) for more examples

## Contributing

### Running Tests

Add `appsettings.json` to `NetoDotNET.Test` see [Using appsettingsjson](#using-appsettings)

> Integration tests use real data inside of your Neto store. If tests fail it may be because the resource not longer exists or is out of sync