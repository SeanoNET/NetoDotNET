using Newtonsoft.Json;

namespace NetoDotNET.Resources.Payments
{
    public class GetPaymentResponse : NetoResponseBase
    {
        [JsonProperty("Payment")]
        public Payment[] Payment { get; set; }

    }

}