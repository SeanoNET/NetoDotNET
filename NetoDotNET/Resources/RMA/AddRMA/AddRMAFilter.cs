using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.RMA
{
    [JsonObject(Title = "AddRma")]
    public class AddRMAFilter : NetoAddResourceFilter
    {
        public Rma[] Rma { get; set; }

        public AddRMAFilter(Rma[] rma)
        {
            this.Rma = rma;
        }


        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}