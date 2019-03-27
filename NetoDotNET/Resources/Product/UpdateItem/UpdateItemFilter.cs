using NetoDotNET.Objects;

namespace NetoDotNET.Resources.Product.UpdateItem
{
    public class UpdateItemFilter : NetoAddResourceFilter
    {
        public Item[] Item { get; set; }

        public UpdateItemFilter(Item[] item)
        {
            this.Item = item;
        }

        internal override bool isValid()
        {
            // TODO: Validate item
            return true;
        }
    }
}