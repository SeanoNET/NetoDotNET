using NetoDotNET.Objects;
using NetoDotNET.Resources.Product.UpdateItem;

namespace NetoDotNET.Resources
{
    public interface IProductResource
    {
        AddItemResponse AddItem(Item[] item);
        Item[] GetItem(GetItemFilter productFilter);
        UpdateItemResponse UpdateItem(Item[] item);
    }
}