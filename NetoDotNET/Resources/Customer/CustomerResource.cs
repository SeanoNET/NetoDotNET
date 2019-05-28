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
            AddCustomerFilter addCustomerFilter = new AddCustomerFilter(customer);


            var nRequest = new AddCustomerRequest(addCustomerFilter);
            var nResponse = GetResponse<AddCustomerResponse>(nRequest);


            return nResponse;
        }

        public AddCustomerLogResponse AddCustomerLog(Entities.Customers.CustomerLog.CustomerLogs customerLogs)
        {
            AddCustomerLogFilter addCustomerLogFilter = new AddCustomerLogFilter(customerLogs);


            var nRequest = new AddCustomerLogRequest(addCustomerLogFilter);
            var nResponse = GetResponse<AddCustomerLogResponse>(nRequest);


            return nResponse;
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

        public UpdateCustomerLogResponse UpdateCustomerLog(Entities.Customers.CustomerLog.CustomerLogs customerLogs)
        {
            UpdateCustomerLogFilter updateCustomerLogFilter = new UpdateCustomerLogFilter(customerLogs);

            var nRequest = new UpdateCustomerLogRequest(updateCustomerLogFilter);
            var nResponse = GetResponse<UpdateCustomerLogResponse>(nRequest);

            return nResponse;
        }
    }
}

