using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Customers
{
    public class CustomerResource : NetoResourceBase, ICustomerResource
    {
        private const string RESOURCE_ENDPOINT = "/customers";

        public CustomerResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }
        public AddCustomerResponse AddCustomer(Customer[] customer)
        {
            throw new NotImplementedException();
        }

        public Customer[] GetCustomer(GetCustomerFilter customerFilter)
        {
            var nRequest = new GetCustomerRequest(customerFilter);
            var nResponse = GetResponse<GetCustomerResponse>(nRequest);

            return nResponse.Customer;
        }

        public UpdateCustomerResponse UpdateCustomer(Customer[] customer)
        {
            throw new NotImplementedException();
        }
    }
}

