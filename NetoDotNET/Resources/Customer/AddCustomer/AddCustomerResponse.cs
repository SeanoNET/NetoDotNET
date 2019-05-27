using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetoDotNET.Resources.Customers
{
    public class AddCustomerResponse : NetoResponseBase
    {
        [JsonProperty("Customer")]
        [JsonConverter(typeof(SingleOrArrayConverter<AddedCustomer>))]
        public List<AddedCustomer> Customer { get; private set; }
    }

}
