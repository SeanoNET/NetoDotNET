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
        /// <returns>Suppliers matching the GetSupplierFilter <see cref="String"/></returns>
        List<Suppliers> GetSupplier(GetSupplierFilter supplierFilter);
    }

}

