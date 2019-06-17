using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Currency
{
    public class GetCurrencySettingsRequest : INetoRequest
    {
        private readonly GetCurrencySettingsFilter _getCurrencySettingsFilter;

        public string NetoAPIAction => "GetCurrencySettings";

        public GetCurrencySettingsRequest(GetCurrencySettingsFilter getCurrencySettingsFilter)
        {
            this._getCurrencySettingsFilter = getCurrencySettingsFilter;
        }


        public bool isValidRequest()
        {
            return _getCurrencySettingsFilter.isValid();
        }

        public string GetBody()
        {
            return _getCurrencySettingsFilter.ToJSON();
        }
    }
}