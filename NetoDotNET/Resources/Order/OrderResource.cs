using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Orders
{
    public class OrderResource : NetoResourceBase, IOrderResource
    {
        private const string RESOURCE_ENDPOINT = "/orders";

        public OrderResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }

        public AddOrderResponse AddOrder(AddOrder[] addOrder)
        {
            AddOrderFilter addOrderFilter = new AddOrderFilter(addOrder);


            var nRequest = new AddOrderRequest(addOrderFilter);
            var nResponse = GetResponse<AddOrderResponse>(nRequest);


            return nResponse;
        }

        public Order[] GetOrder(GetOrderFilter getOrderFilter)
        {
            var nRequest = new GetOrderRequest(getOrderFilter);
            var nResponse = GetResponse<GetOrderResponse>(nRequest);

            return nResponse.Order;
        }

        public UpdateOrderResponse UpdateOrder(Order[] order)
        {
            UpdateOrderFilter updateOrderFilter = new UpdateOrderFilter(order);

            var nRequest = new UpdateOrderRequest(updateOrderFilter);
            var nResponse = GetResponse<UpdateOrderResponse>(nRequest);

            return nResponse;
        }
    }
}
