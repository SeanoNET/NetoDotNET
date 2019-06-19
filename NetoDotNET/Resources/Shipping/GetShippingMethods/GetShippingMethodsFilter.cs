using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Shippings
{
      [JsonObject(Title = "Filter")]
    public class GetShippingMethodsFilter : NetoGetResourceFilter
    {
        public GetShippingMethodsFilter()
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