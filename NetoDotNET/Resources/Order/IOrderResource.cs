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

        /// <summary>
        /// Use this call to add a new order/invoice.
        /// </summary>
        /// <param name="addOrder">New order to create.</param>
        /// <typeparam name="addOrder">
        /// </typeparam>
        /// <returns>returns the unique identifier (OrderID) for the order, and the date and time the product was added (CurrentTime) <see cref="AddOrderResponse"/></returns>
        AddOrderResponse AddOrder(AddOrder[] addOrder);


        /// <summary>
        /// Use this call to update orders/invoices
        /// </summary>
        /// <param name="order">Order to update. <see cref="Order"/></param>
        /// <typeparam name="order">
        /// </typeparam>
        /// <returns>The unique identifier (OrderID) for the order, and the date and time the product was updated (CurrentTime) <see cref="UpdateOrderResponse"/></returns>
        UpdateOrderResponse UpdateOrder(Order[] order);
    }
}
