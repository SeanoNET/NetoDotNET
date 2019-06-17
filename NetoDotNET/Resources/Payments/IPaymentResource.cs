using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Payments
{
    public interface IPaymentResource
    {
        /// <summary>
        /// Use this call to get payment data.
        /// </summary>
        /// <param name="productFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetPaymentFilter"/></param>
        /// <typeparam name="GetPaymentFilter">
        /// </typeparam>
        /// <returns>Payments matching the GetPaymentFilter <see cref="Payment"/></returns>
        Payment[] GetPayment(GetPaymentFilter paymentFilter);

        /// <summary>
        /// Use this call to add a new payment to an order/invoice.
        /// </summary>
        /// <param name="Payment">New payment to add.</param>
        /// <typeparam name="Payment">
        /// </typeparam>
        /// <returns>returns the unique identifier (PaymentID) for the new payment, and the date and time the payment was added (CurrentTime) <see cref="AddPaymentResponse"/></returns>
        AddPaymentResponse AddPayment(AddPayment[] addPayment);

        /// <summary>
        /// Use this call to get payment method data.
        /// </summary>
        /// <returns>Payment methods<see cref="PaymentMethods"/></returns>
        PaymentMethods GetPaymentMethods();
    }
}
