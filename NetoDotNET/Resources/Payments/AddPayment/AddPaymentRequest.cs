namespace NetoDotNET.Resources.Payments
{
    public class AddPaymentRequest : INetoRequest
    {
        private readonly AddPaymentFilter _addPaymentFilter;

        public string NetoAPIAction => "AddPayment";

        public AddPaymentRequest(AddPaymentFilter addPaymentFilter)
        {
            this._addPaymentFilter = addPaymentFilter;
        }


        public bool isValidRequest()
        {
            return _addPaymentFilter.isValid();
        }

        public string GetBody()
        {
            return _addPaymentFilter.ToJSON();
        }
    }
}