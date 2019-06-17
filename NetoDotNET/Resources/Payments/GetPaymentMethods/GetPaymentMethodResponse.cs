using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Payments
{
    public class GetPaymentMethodResponse : NetoResponseBase
    {
        [JsonProperty("PaymentMethods")]
        public PaymentMethods PaymentMethods { get; set; }

    }

}
