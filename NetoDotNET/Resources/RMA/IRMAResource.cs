using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.RMA
{
    public interface IRMAResource
    {

        // <summary>
        /// Use this method to get RMA (Return Merchadise Authorisation) data.
        /// </summary>
        /// <param name="rmaFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetRMAFilter"/></param>
        /// <typeparam name="GetRMAFilter">
        /// </typeparam>
        /// <returns>RMA matching the GetRMAFilter <see cref="Rma"/></returns>
        List<Rma> GetRMA(GetRMAFilter rmaFilter);


        /// <summary>
        /// Use this call to add a new RMA (Return Merchadise Authorisation).
        /// </summary>
        /// <param name="rma">New Rma to add.</param>
        /// <typeparam name="Rma">
        /// </typeparam>
        /// <returns>returns the unique identifier for the RMA, and the date and time the product was added (CurrentTime) <see cref="AddRMAResponse"/></returns>
        AddRMAResponse AddRma(Rma[] rma);
    }
}
