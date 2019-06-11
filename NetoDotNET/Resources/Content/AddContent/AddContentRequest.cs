using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Contents
{
    public class AddContentRequest : INetoRequest
    {
        private readonly AddContentFilter _addContentFilter;

        public string NetoAPIAction => "AddContent";

        public AddContentRequest(AddContentFilter addContentFilter)
        {
            this._addContentFilter = addContentFilter;
        }


        public bool isValidRequest()
        {
            return _addContentFilter.isValid();
        }

        public string GetBody()
        {
            return _addContentFilter.ToJSON();
        }
    }
}