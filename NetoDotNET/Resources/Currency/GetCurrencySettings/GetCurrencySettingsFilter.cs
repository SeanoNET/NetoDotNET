using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Currency
{
    [JsonObject(Title = "Filter")]
    public class GetCurrencySettingsFilter : NetoGetResourceFilter
    {
        public GetCurrencySettingsFilter()
        {

        }

        public override string ToJSON()
        {
            return "{}";
        }

        internal override bool isValid()
        {
            return true;
        }
    }
}
