using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities.Contents;

namespace NetoDotNET.Resources.Contents
{
    public class ContentResource : NetoResourceBase, IContentResource
    {
        private const string RESOURCE_ENDPOINT = "/content";

        public ContentResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }

        public Content[] GetContent(GetContentFilter contentFilter)
        {
            var nRequest = new GetContentRequest(contentFilter);
            var nResponse = GetResponse<GetContentResponse>(nRequest);

            return nResponse.Content;
        }
    }
}
