using NetoDotNET.Entities;
using Newtonsoft.Json;
using System;

namespace NetoDotNET.Resources.Products
{
    [JsonObject(Title = "AddItem")]
    public class AddItemFilter : NetoAddResourceFilter
    {
        public NewItem[] Item { get; set; }

        public AddItemFilter(NewItem[] item)
        {
            this.Item = item;
        }
        

        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}