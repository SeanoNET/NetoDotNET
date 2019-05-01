using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public enum Ack
    {
        Success,
        Warning,
        Error
    }
    public class ResponseMessage
    {
        [JsonConverter(typeof(SingleOrArrayConverter<ResponseMessageError>))]
        public List<ResponseMessageError> Error { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<ResponseMessageWarning>))]
        public List<ResponseMessageWarning> Warning { get; set; }
    }

    public class ResponseMessageError
    {
        public string Message { get; set; }
        public string SeverityCode { get; set; }
        public string Description { get; set; }
    }

    public class ResponseMessageWarning
    {
        public string Message { get; set; }
        public string SeverityCode { get; set; }
    }

}
