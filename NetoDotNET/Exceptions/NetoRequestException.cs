using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Exceptions
{
    class NetoRequestException : Exception
    {
        public NetoRequestException()
        {
            
        }

        public NetoRequestException(string message) : base(message)
        {

        }

        public NetoRequestException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
