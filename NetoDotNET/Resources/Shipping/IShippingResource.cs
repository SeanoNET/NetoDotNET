using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Shippings
{
    public interface IShippingResource
    {
        /// <summary>
        /// Use this call to fetch shipping methods.
        /// </summary>
        /// <returns>Shipping methods<see cref="ShippingMethods"/></returns>
        ShippingMethods GetShippingMethods();

        /// <summary>
        /// Use this method to fetch shipping quote.
        /// </summary>
        /// <param name="filter">Shipping info</param>
        /// <typeparam name="GetShippingQuoteFilter">
        /// </typeparam>
        /// <returns>returns shipping quote<see cref="ShippingQuotes"/></returns>
        List<ShippingQuotes> GetShippingQuote(GetShippingQuoteFilter filter);
    }
}
