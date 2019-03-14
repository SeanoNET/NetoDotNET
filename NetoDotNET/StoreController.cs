using NetoDotNET.Resources;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET
{
    public class StoreController
    {
        private protected const string _baseEndpoint = @"/do/WS/NetoAPI";
        private readonly StoreConfiguration _configuration;

        public ProductResource Products { get { return new ProductResource(_configuration); } }
   

        /// <summary>
        /// Create a new instance of <see cref="StoreController" />.
        /// </summary>
        /// <param name="configuration">Neto store configuration <see cref="StoreConfiguration"</param>
        public StoreController(StoreConfiguration configuration)
        {
            this._configuration = configuration;
        }


       
    }
}
