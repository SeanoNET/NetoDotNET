using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Contents
{
    public class GetContentRequest : INetoRequest
    {
        private readonly GetContentFilter _getConentFilter;

        public string NetoAPIAction => "GetContent";

        public GetContentRequest(GetContentFilter getGetContent)
        {
            this._getConentFilter = getGetContent;
        }


        public bool isValidRequest()
        {
            return _getConentFilter.isValid();
        }

        public string GetBody()
        {
            return _getConentFilter.ToJSON();
        }
    }
}
