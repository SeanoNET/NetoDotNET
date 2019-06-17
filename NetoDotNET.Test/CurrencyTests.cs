using NetoDotNET.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class CurrencyTests : NetoBaseTests
    {
        #region GetCurrencySettings  
        /// <summary>
        /// Test retrieval of all currency settings
        /// </summary>
        [Test]
        public void Should_Get_All_Currency_Settings()
        {
            var netoStore = GetStoreManager();

            List<CurrencySettings> result = netoStore.Currency.GetCurrencySettings();
            Assert.IsNotNull(result);
        }
        #endregion

        #region UpdateCurrencySettings
        /// <summary>
        /// Test update currency settings
        /// </summary>
        [Test]
        public void Should_Update_Currency_Settings()
        {
            var netoStore = GetStoreManager();

            UpdateCurrencySettings settings = new UpdateCurrencySettings
            {
                DefaultCountry = new string[] { "AU" },
                DefaultCurrency = new string[] { "AUD" }

            };

            var result = netoStore.Currency.UpdateCurrencySettings(settings);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
        }

        #endregion
    }
}
