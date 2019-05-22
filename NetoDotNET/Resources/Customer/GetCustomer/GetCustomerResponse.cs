using NetoDotNET.Entities;
using Newtonsoft.Json;

namespace NetoDotNET.Resources.Customers
{
    public class GetCustomerResponse : NetoResponseBase
    {
        [JsonProperty("Customer")]
        public Customer[] Customer{ get; set; }

    }
}