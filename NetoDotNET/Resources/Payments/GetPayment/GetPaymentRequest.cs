namespace NetoDotNET.Resources.Payments
{
    public class GetPaymentRequest : INetoRequest
    {
        private readonly GetPaymentFilter _getPaymentFilter;

        public string NetoAPIAction => "GetPayment";

        public GetPaymentRequest(GetPaymentFilter getPaymentFilter)
        {
            this._getPaymentFilter = getPaymentFilter;
        }


        public bool isValidRequest()
        {
            return _getPaymentFilter.isValid();
        }

        public string GetBody()
        {
            return _getPaymentFilter.ToJSON();
        }
    }
}