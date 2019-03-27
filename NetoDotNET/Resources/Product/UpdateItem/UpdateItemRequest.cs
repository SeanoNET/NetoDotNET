using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Product.UpdateItem
{
    class UpdateItemRequest : INetoRequest
    {
        private readonly UpdateItemFilter _updateItemFilter;

        public string NetoAPIAction => "UpdateItem";

        public string GetBody()
        {
            return _updateItemFilter.ToJSON();
        }

        public bool isValidRequest()
        {
            return _updateItemFilter.isValid();
        }
    }
}
