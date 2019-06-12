using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetoDotNET.Resources.Payments
{
    public class AddPaymentResponse : NetoResponseBase
    {
        [JsonProperty("Payment")]
        [JsonConverter(typeof(SingleOrArrayConverter<Payment>))]
        public List<Payment> Payment { get; private set; }
    }

}