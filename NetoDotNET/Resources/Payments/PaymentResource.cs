using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Payments
{
    public class PaymentResource : NetoResourceBase, IPaymentResource
    {
        private const string RESOURCE_ENDPOINT = "/payments";

        public PaymentResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }

        public AddPaymentResponse AddPayment(AddPayment[] addPayment)
        {
            AddPaymentFilter addPaymentFilter = new AddPaymentFilter(addPayment);


            var nRequest = new AddPaymentRequest(addPaymentFilter);
            var nResponse = GetResponse<AddPaymentResponse>(nRequest);


            return nResponse;
        }

        public Payment[] GetPayment(GetPaymentFilter paymentFilter)
        {
            var nRequest = new GetPaymentRequest(paymentFilter);
            var nResponse = GetResponse<GetPaymentResponse>(nRequest);

            return nResponse.Payment;
        }

        public PaymentMethod[] GetPaymentMethods(GetPaymentMethodFilter paymentMethodFilter)
        {
            throw new NotImplementedException();
        }
    }
}
