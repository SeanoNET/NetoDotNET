using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Shippings
{
    public interface IShippingResource
    {
        /// <summary>
        /// Use this call to fet shipping methods.
        /// </summary>
        /// <returns>Shipping methods<see cref="ShippingMethods"/></returns>
        ShippingMethods GetShippingMethods();

    }
}
