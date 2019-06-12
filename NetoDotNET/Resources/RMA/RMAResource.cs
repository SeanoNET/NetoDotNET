using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.RMA
{
    public class RMAResource : NetoResourceBase, IRMAResource
    {
        private const string RESOURCE_ENDPOINT = "/rma";

        public RMAResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }

        public AddRMAResponse AddRma(Rma[] rma)
        {
            AddRMAFilter addRmaFilter = new AddRMAFilter(rma);


            var nRequest = new AddRMARequest(addRmaFilter);
            var nResponse = GetResponse<AddRMAResponse>(nRequest);


            return nResponse;
        }

        public List<Rma> GetRMA(GetRMAFilter rmaFilter)
        {
            var nRequest = new GetRMARequest(rmaFilter);
            var nResponse = GetResponse<GetRMAResponse>(nRequest);

            return nResponse.Rma;
        }
    }
}
