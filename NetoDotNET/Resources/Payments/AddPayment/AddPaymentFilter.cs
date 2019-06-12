using Newtonsoft.Json;

namespace NetoDotNET.Resources.Payments
{
    [JsonObject(Title = "AddPayment")]
    public class AddPaymentFilter : NetoAddResourceFilter
    {
        public AddPayment[] Payment { get; set; }

        public AddPaymentFilter(AddPayment[] payment)
        {
            this.Payment = payment;
        }


        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}