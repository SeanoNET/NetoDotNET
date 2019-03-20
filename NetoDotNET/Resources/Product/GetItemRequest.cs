using System.Net.Http;

namespace NetoDotNET.Resources
{
    public class GetItemRequest : INetoRequest
    {
        private readonly GetItemFilter _getItemFilter;

        public string NetoAPIAction => "GetItem";

        public GetItemRequest(GetItemFilter getItemFilter)
        {
            this._getItemFilter = getItemFilter;
        }

   
        public bool isValidRequest()
        {
            return _getItemFilter.isValid();
        }

        public string GetBody()
        {
            return _getItemFilter.ToJSON();
        }
    }
}