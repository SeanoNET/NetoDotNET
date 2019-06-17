using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Currency
{
    public interface ICurrencyResource
    {
        /// <summary>
        /// Use this method to get currency settings data.
        /// </summary>
        /// <returns>Currency settings<see cref="CurrencySettings"/></returns>
        List<CurrencySettings> GetCurrencySettings();

        /// <summary>
        /// Use this call to update currency settings.
        /// </summary>
        /// <param name="currencySettings">CurrencySettings to update. <see cref="CurrencySettings"/></param>
        /// <typeparam name="CurrencySettings">
        /// </typeparam>
        /// <returns>Neto resource response<see cref="UpdateCurrencySettingsResponse"/></returns>
        UpdateCurrencySettingsResponse UpdateCurrencySettings(UpdateCurrencySettings currencySettings);
    }
}
