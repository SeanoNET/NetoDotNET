using Newtonsoft.Json;

namespace NetoDotNET.Resources.Payments
{
    [JsonObject(Title = "Filter")]
    public class GetPaymentsMethodFilter : NetoGetResourceFilter
    {
        public GetPaymentsMethodFilter()
        {

        }

        public override string ToJSON()
        {
            return "{}";
        }

        internal override bool isValid()
        {
            return true;
        }
    }
}