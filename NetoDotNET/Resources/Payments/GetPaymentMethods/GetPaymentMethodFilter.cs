using Newtonsoft.Json;

namespace NetoDotNET.Resources.Payments
{
    [JsonObject(Title = "Filter")]
    public class GetPaymentMethodFilter : NetoGetResourceFilter
    {
        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetPaymentMethods request. These will determine the results returned.
        /// </summary>
        public GetPaymentMethodFilter()
        {

        }

        internal override bool isValid()
        {
            throw new System.NotImplementedException();
        }
    }
}