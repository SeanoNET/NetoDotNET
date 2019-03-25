namespace NetoDotNET.Resources
{
    public class AddItemRequest : INetoRequest
    {
        private readonly AddItemFilter _addItemFilter;

        public string NetoAPIAction => "AddItem";

        public AddItemRequest(AddItemFilter addItemFilter)
        {
            this._addItemFilter = addItemFilter;
        }


        public bool isValidRequest()
        {
            return _addItemFilter.isValid();
        }

        public string GetBody()
        {
            return _addItemFilter.ToJSON();
        }
    }
}