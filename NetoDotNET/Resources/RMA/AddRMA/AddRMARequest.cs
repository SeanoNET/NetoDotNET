using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.RMA
{
    class AddRMARequest : INetoRequest
    {
        private readonly AddRMAFilter _addRmaFilter;

        public string NetoAPIAction => "AddRma";

        public AddRMARequest(AddRMAFilter addRmaFilter)
        {
            this._addRmaFilter = addRmaFilter;
        }


        public bool isValidRequest()
        {
            return _addRmaFilter.isValid();
        }

        public string GetBody()
        {
            return _addRmaFilter.ToJSON();
        }
    }
}