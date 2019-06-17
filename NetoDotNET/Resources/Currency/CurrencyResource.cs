using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Currency
{
    public class CurrencyResource : NetoResourceBase, ICurrencyResource
    {

        private const string RESOURCE_ENDPOINT = "/currencysettings";

        public CurrencyResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }
        public List<CurrencySettings> GetCurrencySettings()
        {
            var nRequest = new GetCurrencySettingsRequest(new GetCurrencySettingsFilter());
            var nResponse = GetResponse<GetCurrencySettingsResponse>(nRequest);

            return nResponse.CurrencySettings;
        }

        public UpdateCurrencySettingsResponse UpdateCurrencySettings(UpdateCurrencySettings currencySettings)
        {
            UpdateCurrencySettingsFilter updateCurrencySettingsFilter = new UpdateCurrencySettingsFilter(currencySettings);

            var nRequest = new UpdateCurrencySettingsRequest(updateCurrencySettingsFilter);
            var nResponse = GetResponse<UpdateCurrencySettingsResponse>(nRequest);

            return nResponse;
        }
    }
}
