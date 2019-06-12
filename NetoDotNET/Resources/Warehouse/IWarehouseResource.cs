using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Warehouses
{
    public interface IWarehouseResource
    {
        /// <summary>
        /// Use this call to get warehouse data.
        /// </summary>
        /// <param name="warehouseFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetWarehouseFilter"/></param>
        /// <typeparam name="GetWarehouseFilter">
        /// </typeparam>
        /// <returns>Warehouses matching the GetWarehouseFilter <see cref="Warehouse"/></returns>
        Warehouse[] GetWarehouse(GetWarehouseFilter warehouseFilter);

        /// <summary>
        /// Use this call to add a new warehouse. You can store stock in multiple warehouses with Neto.
        /// </summary>
        /// <param name="warehouse">New warehouse to add.</param>
        /// <typeparam name="Warehouse">
        /// </typeparam>
        /// <returns>returns the unique identifier (WarehouseID) for the product, and the date and time the product was added (CurrentTime) <see cref="AddWarehouseResponse"/></returns>
        AddWarehouseResponse AddWarehouse(Warehouse[] warehouse);

        /// <summary>
        /// Use this call to add a new warehouse. You can store stock in multiple warehouses with Neto.
        /// </summary>
        /// <param name="warehouse">Warehouse to update. <see cref="Warehouse"/></param>
        /// <typeparam name="Warehouse">
        /// </typeparam>
        /// <returns>The unique identifier (WarehouseID) for the product, and the date and time the product was updated (CurrentTime) <see cref="UpdateWarehouseResponse"/></returns>
        UpdateWarehouseResponse UpdateWarehouse(Warehouse[] warehouse);
    }
}
