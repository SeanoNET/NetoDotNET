using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Exceptions
{
    class NetoResponseException : Exception
    {
        public NetoResponseException()
        {
            
        }

        public NetoResponseException(string message) : base(message)
        {

        }

        public NetoResponseException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
