namespace NetoDotNET.Resources.Customers
{
    public class GetCustomerRequest : INetoRequest
    {
        private readonly GetCustomerFilter _getCustomerFilter;

        public string NetoAPIAction => "GetCustomer";

        public GetCustomerRequest(GetCustomerFilter customerFilter)
        {
            this._getCustomerFilter = customerFilter;
        }

        public bool isValidRequest()
        {
            return _getCustomerFilter.isValid();
        }

        public string GetBody()
        {
            return _getCustomerFilter.ToJSON();
        }
    }
}