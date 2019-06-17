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
        /// Use this method to update a product.
        /// </summary>
        /// <param name="item">Item to update. <see cref="Item"/></param>
        /// <typeparam name="Item">
        /// </typeparam>
        /// <returns>The unique identifier (SKU) for the product, and the date and time the product was updated (CurrentTime) <see cref="UpdateItemResponse"/></returns>
        //UpdateItemResponse UpdateItem(Item[] item);
    }
}
