using NetoDotNET.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources
{
    public class ProductResource : INetoResource<Product>
    {
        private readonly StoreConfiguration _configuration;

        public ProductResource(StoreConfiguration configuration) 
        {
            this._configuration = configuration;
        }

        public Uri BuildURI()
        {
            throw new NotImplementedException();
        }

        public Product Get(string productID)
        {
            Console.WriteLine("Getting product resource");
            return new Product();
        }

    }
}
