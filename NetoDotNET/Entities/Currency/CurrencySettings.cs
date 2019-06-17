using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class CurrencySettings
    {
        public string DefaultCountry { get; set; }

        public string DefaultCurrency { get; set; }

        public string Gst_Amt { get; set; }

    }

 
    public class UpdateCurrencySettings
    {
        [JsonProperty("DEFAULTCOUNTRY")]
        public string[] DefaultCountry { get; set; }
        [JsonProperty("DEFAULTCURRENCY")]
        public string[] DefaultCurrency { get; set; }
        [JsonProperty("GST_INC_CPANEL")]
        public string[] Gst_Inc_Cpannel { get; set; }
        [JsonProperty("GST_AMT")]
        public string[] Gst_Amt { get; set; }

    }
}
