using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Customers
{
   public interface ICustomerResource
    {
        /// <summary>
        /// Use this call to get customer data. 
        /// </summary>
        /// <param name="customerFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetCustomerFilter"/></param>
        /// <typeparam name="GetCustomerFilter">
        /// </typeparam>
        /// <returns>Items matching the GetCustomerFilter <see cref="Customer"/></returns>
        Customer[] GetCustomer(GetCustomerFilter customerFilter);

        /// <summary>
        /// Use this call to add a new customer.
        /// </summary>
        /// <param name="customer">New customer to add.</param>
        /// <typeparam name="Customer">
        /// </typeparam>
        /// <returns>returns the unique identifier (Username) for the customer <see cref="AddCustomerResponse"/></returns>
        AddCustomerResponse AddCustomer(Customer[] customer);

        /// <summary>
        /// Use this call to update a customer.
        /// </summary>
        /// <param name="customer">Customer to update.<see cref="Customer"/></param>
        /// <typeparam name="Customer">
        /// </typeparam>
        /// <returns>returns the unique identifier (Username) for the customer <see cref="AddCustomerResponse"/></returns>
        UpdateCustomerResponse UpdateCustomer(Customer[] customer);
    }
}
