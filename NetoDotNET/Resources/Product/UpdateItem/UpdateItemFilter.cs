using NetoDotNET.Entities.Products;

namespace NetoDotNET.Resources.Product.UpdateItem
{
    public class UpdateItemFilter : NetoUpdateResourceFilter
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