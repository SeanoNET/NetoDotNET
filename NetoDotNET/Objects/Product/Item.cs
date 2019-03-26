using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Objects
{
    public class Item
    {

        public string SupplierItemCode { get; set; }
        public string Features { get; set; }
        public string EditableKitBundle { get; set; }
        public string IsActive { get; set; }
        public string eBayDescription { get; set; }
        public string Misc24 { get; set; }
        public string IsBought { get; set; }
        public string UPC3 { get; set; }
        public string ShippingHeight { get; set; }
        public string PromotionExpiryDateUTC { get; set; }
        public string Misc03 { get; set; }
        public string SubType { get; set; }
        public string ReferenceNumber { get; set; }
        public string Misc32 { get; set; }
        public string ProductURL { get; set; }
        public string Misc16 { get; set; }
        public string ImageURL { get; set; }
        public string Group { get; set; }
        public string Misc30 { get; set; }
        public string ShortDescription { get; set; }
        public string TaxFreeItem { get; set; }
        public string SellUnitQuantity { get; set; }
        public string Brand { get; set; }
        public string BaseUnitPerQuantity { get; set; }
        public Pricegroup[] PriceGroups { get; set; }
        public Itemspecific[] ItemSpecifics { get; set; }
        public string DateAdded { get; set; }
        public string Subtitle { get; set; }
        public string TermsAndConditions { get; set; }
        public string PickZone { get; set; }
        public string Misc13 { get; set; }
        public string RestrictedToUserGroup { get; set; }
        public string BaseUnitOfMeasure { get; set; }
        public string Misc41 { get; set; }
        public string ShippingLength { get; set; }
        public string Misc05 { get; set; }
        public string Misc49 { get; set; }
        public Category[] Categories { get; set; }
        public string NumbersOfLabelsToPrint { get; set; }
        public Warehousequantity WarehouseQuantity { get; set; }
        public string Misc38 { get; set; }
        public string AccountingCode { get; set; }
        public string Misc42 { get; set; }
        public string AvailabilityDescription { get; set; }
        public string DateAddedLocal { get; set; }
        public string Misc21 { get; set; }
        public Saleschannels SalesChannels { get; set; }
        public string SEOPageTitle { get; set; }
        public string Misc35 { get; set; }
        public string DateUpdatedLocal { get; set; }
        public string AutomaticURL { get; set; }
        public string UPC1 { get; set; }
        public string ExpenseAccount { get; set; }
        public string SortOrder2 { get; set; }
        public string Misc37 { get; set; }
        public string SplitForWarehousePicking { get; set; }
        public string Misc02 { get; set; }
        public string AssetAccount { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Job { get; set; }
        public string PickPriority { get; set; }
        public string Misc52 { get; set; }
        public string Misc28 { get; set; }
        public string RequiresPackaging { get; set; }
        public string SerialTracking { get; set; }
        public string ItemLength { get; set; }
        public string CommittedQuantity { get; set; }
        public string Misc44 { get; set; }
        public string Virtual { get; set; }
        public string ID { get; set; }
        public string Misc17 { get; set; }
        public string Misc07 { get; set; }
        public string SortOrder1 { get; set; }
        public string PromotionStartDateUTC { get; set; }
        public string Misc11 { get; set; }
        public string SEOPageHeading { get; set; }
        public string SEOMetaDescription { get; set; }
        public string PromotionPrice { get; set; }
        public string PromotionExpiryDate { get; set; }
        public string Misc25 { get; set; }
        public string Misc23 { get; set; }
        public string PromotionStartDateLocal { get; set; }
        public string Misc50 { get; set; }
        public string SKU { get; set; }
        public string Misc29 { get; set; }
        public string BrochureURL { get; set; }
        public string Misc22 { get; set; }
        public string Model { get; set; }
        public string Misc43 { get; set; }
        public string SEOCanonicalURL { get; set; }
        public string DateArrival { get; set; }
        public string Misc04 { get; set; }
        public string ShippingWidth { get; set; }
        public string Misc48 { get; set; }
        public string SearchKeywords { get; set; }
        public string Misc15 { get; set; }
        public string Misc09 { get; set; }
        public string WhenToRepeatOnStandingOrders { get; set; }
        public Image[] Images { get; set; }
        public string Misc39 { get; set; }
        public string CostOfSalesAccount { get; set; }
        public string PrimarySupplier { get; set; }
        public string Misc10 { get; set; }
        public string Misc34 { get; set; }
        public string Misc19 { get; set; }
        public string Misc33 { get; set; }
        public Warehouselocation[] WarehouseLocations { get; set; }
        public string ItemHeight { get; set; }
        public string Misc46 { get; set; }
        public string[] FreeGifts { get; set; }
        public string Misc20 { get; set; }
        public string CostPrice { get; set; }
        public string Misc40 { get; set; }
        public string Warranty { get; set; }
        public string PromotionStartDate { get; set; }
        public string DateAddedUTC { get; set; }
        public string Misc31 { get; set; }
        public string BarcodeHeight { get; set; }
        public string DefaultPrice { get; set; }
        public string BuyUnitQuantity { get; set; }
        public string Misc36 { get; set; }
        public string DateUpdated { get; set; }
        public string Misc14 { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
        public string Misc01 { get; set; }
        public string DateUpdatedUTC { get; set; }
        public string IsSold { get; set; }
        public string ModelNumber { get; set; }
        public string QuantityPerScan { get; set; }
        public string UPC2 { get; set; }
        public string Misc45 { get; set; }
        public string Format { get; set; }
        public string Approved { get; set; }
        public string IsAsset { get; set; }
        public string CrossSellProducts { get; set; }
        public string Type { get; set; }
        public string ItemURL { get; set; }
        public string DisplayTemplate { get; set; }
        public string MonthlySpendRequirement { get; set; }
        public string ArtistOrAuthor { get; set; }
        public string Misc51 { get; set; }
        public string IncomeAccount { get; set; }
        public string Misc06 { get; set; }
        public string CubicWeight { get; set; }
        public string Misc47 { get; set; }
        public string DateArrivalUTC { get; set; }
        public string ShippingWeight { get; set; }
        public string PromotionExpiryDateLocal { get; set; }
        public string PurchaseTaxCode { get; set; }
        public string Misc27 { get; set; }
        public string RelatedContents { get; set; }
        public string InternalNotes { get; set; }
        public string Misc18 { get; set; }
        public string SEOMetaKeywords { get; set; }
        public string TaxInclusive { get; set; }
        public string RRP { get; set; }
        public string[] UpsellProducts { get; set; }
        public string ParentSKU { get; set; }
        public string ItemWidth { get; set; }
        public string Misc12 { get; set; }
        public string Misc26 { get; set; }
        public string Misc08 { get; set; }
        public string ShippingCategory { get; set; }
        public string IsInventoried { get; set; }
        public string InventoryID { get; set; }
        public string UPC { get; set; }
        public Kitcomponent[] KitComponents { get; set; }
        public string Description { get; set; }



    }

    public class Warehousequantity
    {
        public string WarehouseID { get; set; }
        public string Quantity { get; set; }
    }

    public class Saleschannels
    {
        public Saleschannel[] SalesChannel { get; set; }
    }

    public class Saleschannel
    {
        public string SalesChannelName { get; set; }
        public string SalesChannelID { get; set; }
        public string IsApproved { get; set; }
    }

    public class Pricegroup
    {
        public Pricegroup1 PriceGroup { get; set; }
    }

    public class Pricegroup1
    {
        public string Multiple { get; set; }
        public string Price { get; set; }
        public string MaximumQuantity { get; set; }
        public string MinimumQuantity { get; set; }
        public string Group { get; set; }
        public string GroupID { get; set; }
        public string PromotionPrice { get; set; }
        public string MultipleStartQuantity { get; set; }
    }

    public class Itemspecific
    {
        public Itemspecific1 ItemSpecific { get; set; }
    }

    public class Itemspecific1
    {
        public string Value { get; set; }
        public string Name { get; set; }
    }

    public class Category
    {
        public string CategoryID { get; set; }
        public string Priority { get; set; }
        public string CategoryName { get; set; }
    }

    //public class Category1
    //{
    //    public string CategoryID { get; set; }
    //    public string Priority { get; set; }
    //    public string CategoryName { get; set; }
    //}

    public class Image
    {
        public string URL { get; set; }
        public string Timestamp { get; set; }
        public string ThumbURL { get; set; }
        public string MediumThumbURL { get; set; }
        public string Name { get; set; }
    }

    public class Warehouselocation
    {
        public string WarehouseLocation { get; set; }
    }

    public class Kitcomponent
    {
        public string KitComponent { get; set; }
    }
}
