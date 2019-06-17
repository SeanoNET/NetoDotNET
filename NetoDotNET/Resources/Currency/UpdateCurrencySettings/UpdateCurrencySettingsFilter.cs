using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Currency
{
    public class UpdateCurrencySettingsFilter : NetoUpdateResourceFilter
    {
        [JsonProperty("CurrencySettings")]
        public UpdateCurrencySettings CurrencySettings { get; set; }

        public UpdateCurrencySettingsFilter(UpdateCurrencySettings currencySettings)
        {
            this.CurrencySettings = currencySettings;
        }

        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}