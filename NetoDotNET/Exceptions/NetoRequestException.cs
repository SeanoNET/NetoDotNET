using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetoDotNET.Exceptions
{
    public class NetoRequestException : Exception
    {
        public NetoRequestException()
        {
        }

        public NetoRequestException(string message) : base(message)
        {
        }

        public NetoRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NetoRequestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
