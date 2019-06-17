using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Currency
{
    public class GetCurrencySettingsResponse : NetoResponseBase
    {
        [JsonConverter(typeof(SingleOrArrayConverter<CurrencySettings>))]
        public List<CurrencySettings> CurrencySettings { get; set; }

    }

}
