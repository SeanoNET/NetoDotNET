using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetoDotNET.Entities.Customers.CustomerLog
{
    public class CustomerLogs
    {
        public CustomerLog[] CustomerLog { get; set; }
    }
    public class CustomerLog
    {
        public int LogID { get; set; }

        public string AllocatedTo { get; set; }

        public string FollowUpType { get; set; }

        public string Username { get; set; }
        public string CustomerName { get; set; }

        // Converters throw Token PropertyName in state Property would result in an invalid JSON object. Path 'CustomerLogs.CustomerLog[0]
        // Should not need them as this object will only be used for adding/updating and will not be deserialized from Neto
        //[JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? LastContacted { get; set; }

        //[JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateRequiredFollowUp { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }

        public string Notes { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        None,
        [EnumMember(Value = "Require Recontact")]
        RequireRecontact,
        Recontacting,
        Completed
    }
}
