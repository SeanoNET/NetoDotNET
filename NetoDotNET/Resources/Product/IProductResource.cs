using NetoDotNET.Entities;
namespace NetoDotNET.Resources.Products
{
    public interface IProductResource
    {

        /// <summary>
        /// Use this method to get product data.
        /// </summary>
        /// <param name="productFilter">You must specify at least one filter and one OutputSelector. These will determine the results returned. <see cref="GetItemFilter"/></param>
        /// <typeparam name="GetItemFilter">
        /// </typeparam>
        /// <returns>Items matching the GetItemFilter <see cref="Item"/></returns>
        Item[] GetItem(GetItemFilter productFilter);

        /// <summary>
        /// Use this method to add a new product.
        /// </summary>
        /// <param name="item">New item to add.</param>
        /// <typeparam name="Item">
        /// </typeparam>
        /// <returns>returns the unique identifier (SKU) for the product, and the date and time the product was added (CurrentTime) <see cref="AddItemResponse"/></returns>
        AddItemResponse AddItem(Item[] item);

        /// <summary>
        /// Use this method to update a product.
        /// </summary>
        /// <param name="item">Item to update. <see cref="Item"/></param>
        /// <typeparam name="Item">
        /// </typeparam>
        /// <returns>The unique identifier (SKU) for the product, and the date and time the product was updated (CurrentTime) <see cref="UpdateItemResponse"/></returns>
        UpdateItemResponse UpdateItem(Item[] item);
    }
}