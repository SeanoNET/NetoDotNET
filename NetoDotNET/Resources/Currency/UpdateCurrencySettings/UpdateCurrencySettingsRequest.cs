using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Currency
{
    class UpdateCurrencySettingsRequest : INetoRequest
    {
        private readonly UpdateCurrencySettingsFilter _updateCurrencySettingsFilter;

        public string NetoAPIAction => "UpdateCurrencySettings";

        public UpdateCurrencySettingsRequest(UpdateCurrencySettingsFilter updateCurrencySettingsFilter)
        {
            this._updateCurrencySettingsFilter = updateCurrencySettingsFilter;
        }
        public string GetBody()
        {
            return _updateCurrencySettingsFilter.ToJSON();
        }

        public bool isValidRequest()
        {
            return _updateCurrencySettingsFilter.isValid();
        }
    }
}
