using NetoDotNET.Entities;
using NetoDotNET.Resources.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Orders
{
    public interface IOrderResource
    {

        /// <summary>
        /// Use this call to get order/invoice data.
        /// </summary>
        /// <param name="getOrderFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetItemFilter"/></param>
        /// <typeparam name="GetOrderFilter">
        /// </typeparam>
        /// <returns>Orders matching the GetOrderFilter <see cref="Order"/></returns>
        Order[] GetOrder(GetOrderFilter getOrderFilter);
    }
}
