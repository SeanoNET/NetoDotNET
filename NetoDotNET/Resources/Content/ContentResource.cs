using System;
using System.Collections.Generic;
using System.Text;
using NetoDotNET.Entities;

namespace NetoDotNET.Resources.Contents
{
    public class ContentResource : NetoResourceBase, IContentResource
    {
        private const string RESOURCE_ENDPOINT = "/content";

        public ContentResource(StoreConfiguration storeCongfiguration, IRestClient restClient)
            : base(storeCongfiguration, RESOURCE_ENDPOINT, restClient)
        {
        }

        public AddContentResponse AddContent(Content[] content)
        {
            AddContentFilter addItemFilter = new AddContentFilter(content);


            var nRequest = new AddContentRequest(addItemFilter);
            var nResponse = GetResponse<AddContentResponse>(nRequest);


            return nResponse;
        }

        public Content[] GetContent(GetContentFilter contentFilter)
        {
            var nRequest = new GetContentRequest(contentFilter);
            var nResponse = GetResponse<GetContentResponse>(nRequest);

            return nResponse.Content;
        }

        public UpdateContentResponse UpdateContent(Content[] content)
        {
            throw new NotImplementedException();
        }
    }
}
