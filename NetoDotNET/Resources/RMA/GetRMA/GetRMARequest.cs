using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.RMA
{
    public class GetRMARequest : INetoRequest
    {
        private readonly GetRMAFilter _getRMAFilter;

        public string NetoAPIAction => "GetRma";

        public GetRMARequest(GetRMAFilter getRMAFilter)
        {
            this._getRMAFilter = getRMAFilter;
        }


        public bool isValidRequest()
        {
            return _getRMAFilter.isValid();
        }

        public string GetBody()
        {
            return _getRMAFilter.ToJSON();
        }
    }
}
