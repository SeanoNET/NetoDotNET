using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Supplier
{
    public interface ISupplierResource
    {
        /// <summary>
        /// Use this call to get supplier data.
        /// </summary>
        /// <param name="supplierFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetSupplierFilter"/></param>
        /// <typeparam name="GetSupplierFilter">
        /// </typeparam>
        /// <returns>Suppliers matching the GetSupplierFilter <see cref="Suppliers"/></returns>
        List<Suppliers> GetSupplier(GetSupplierFilter supplierFilter);

        /// <summary>
        /// Use this call to update an existing Supplier
        /// </summary>
        /// <param name="supplier">Supplier to update. <see cref="Suppliers"/></param>
        /// <typeparam name="Suppliers">
        /// </typeparam>
        /// <returns>The unique identifier (SupplierID) for the supplier, and the date and time the supplier was updated (CurrentTime) <see cref="UpdateSupplierResponse"/></returns>
        UpdateSupplierResponse UpdateSupplier(Suppliers[] supplier);

        /// <summary>
        /// Use this call to add a new supplier.
        /// </summary>
        /// <param name="supplier">New supplier to add.</param>
        /// <typeparam name="Suppliers">
        /// </typeparam>
        /// <returns>returns the unique identifier (SupplierID) for the supplier, and the date and time the supplier was added (CurrentTime) <see cref="AddSupplierResponse"/></returns>
        AddSupplierResponse AddSupplier(Suppliers[] supplier);
    }

}

