using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Contents
{
   public class UpdateContentRequest : INetoRequest
    {
        private readonly UpdateContentFilter _updateContentFilter;

        public string NetoAPIAction => "UpdateContent";

        public UpdateContentRequest(UpdateContentFilter updateContentFilter)
        {
            this._updateContentFilter = updateContentFilter;
        }
        public string GetBody()
        {
            return _updateContentFilter.ToJSON();
        }

        public bool isValidRequest()
        {
            return _updateContentFilter.isValid();
        }
    }
}

