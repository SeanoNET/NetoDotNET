using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;
using NetoDotNET.Entities.Customers.CustomerLog;

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
            AddCustomerFilter addCustomerFilter = new AddCustomerFilter(customer);


            var nRequest = new AddCustomerRequest(addCustomerFilter);
            var nResponse = GetResponse<AddCustomerResponse>(nRequest);


            return nResponse;
        }

        public AddCustomerLogResponse AddCustomerLog(CustomerLog[] customerLog)
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
            UpdateCustomerFilter updateCustomerFilter = new UpdateCustomerFilter(customer);

            var nRequest = new UpdateCustomerRequest(updateCustomerFilter);
            var nResponse = GetResponse<UpdateCustomerResponse>(nRequest);

            return nResponse;
        }

        public UpdateCustomerLogResponse UpdateCustomerLog(CustomerLog[] customerLog)
        {
            throw new NotImplementedException();
        }
    }
}

