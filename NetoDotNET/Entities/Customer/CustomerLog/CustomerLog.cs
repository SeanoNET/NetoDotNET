using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities.Customers.CustomerLog
{
    public class CustomerLog
    {
        public int LogID { get; set; }

        public string AllocatedTo { get; set; }

        public string FollowUpType { get; set; }

        public string CustomerName { get; set; }
    
        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? LastContacted { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateRequiredFollowUp { get; set; }

        public string Status { get; set; }

        public string Notes { get; set; }
    }
}
