using NetoDotNET.Entities.Customers.CustomerLog;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetoDotNET.Resources.Customers
{
    public class AddCustomerLogResponse : NetoResponseBase
    {
        [JsonProperty("CustomerLog")]
        [JsonConverter(typeof(SingleOrArrayConverter<AddedCustomerLog>))]
        public List<AddedCustomerLog> CustomerLog { get; private set; }
    }

}