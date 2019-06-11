using NetoDotNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.RMA
{
    public interface IRMAResource
    {

        // <summary>
        /// Use this method to get RMA data.
        /// </summary>
        /// <param name="rmaFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetRMAFilter"/></param>
        /// <typeparam name="GetRMAFilter">
        /// </typeparam>
        /// <returns>RMA matching the GetRMAFilter <see cref="Rma"/></returns>
        List<Rma> GetRMA(GetRMAFilter rmaFilter);
    }
}
