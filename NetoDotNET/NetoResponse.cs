using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET
{
    public class NetoResponse
    {
        public NetoResponse(string body)
        {
            Body = body;
        }

        public string Body { get; }
    }

}
