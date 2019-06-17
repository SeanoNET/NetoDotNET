using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class PaymentMethods
    {
        public PaymentMethod[] PaymentMethod { get; set; }
    }
    public class PaymentMethod
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [JsonConverter(typeof(NetoBooleanConverter<bool>))]
        public bool Active { get; set; }

        [JsonConverter(typeof(NetoBooleanConverter<bool>))]
        public bool Visible { get; set; }

        public string Acc_code { get; set; }
    }
}
