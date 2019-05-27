using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetoDotNET.Resources.Customers
{
    public class UpdateCustomerResponse : NetoResponseBase
    {
        [JsonProperty("Customer")]
        [JsonConverter(typeof(SingleOrArrayConverter<UpdatedCustomer>))]
        public List<UpdatedCustomer> Item { get; private set; }

    }
}