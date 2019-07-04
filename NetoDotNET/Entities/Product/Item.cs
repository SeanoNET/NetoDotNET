using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetoDotNET.Entities
{
    public class Item
    {

        public string ID { get; set; }

        public string SKU { get; set; }

        public string InventoryID { get; set; }

        public string ParentSKU { get; set; }

        public string AccountingCode { get; set; }

        public bool Virtual { get; set; }

        public bool VirtualSpecified { get; set; }

        public string Brand { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public string SortOrder1 { get; set; }

        public string SortOrder2 { get; set; }

        public decimal RRP { get; set; }

        public bool RRPSpecified { get; set; }

        public decimal DefaultPrice { get; set; }

        public bool DefaultPriceSpecified { get; set; }

        public decimal PromotionPrice { get; set; }

        public bool PromotionPriceSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? PromotionStartDate { get; set; }

        public bool PromotionStartDateSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? PromotionStartDateLocal { get; set; }

        public bool PromotionStartDateLocalSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? PromotionStartDateUTC { get; set; }

        public bool PromotionStartDateUTCSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? PromotionExpiryDate { get; set; }

        public bool PromotionExpiryDateSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? PromotionExpiryDateLocal { get; set; }

        public bool PromotionExpiryDateLocalSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? PromotionExpiryDateUTC { get; set; }

        public bool PromotionExpiryDateUTCSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateArrival { get; set; }

        public bool DateArrivalSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateArrivalUTC { get; set; }

        public bool DateArrivalUTCSpecified { get; set; }

        public decimal CostPrice { get; set; }

        public bool CostPriceSpecified { get; set; }

        public string UnitOfMeasure { get; set; }

        public string BaseUnitOfMeasure { get; set; }

        public decimal BaseUnitPerQuantity { get; set; }

        public bool BaseUnitPerQuantitySpecified { get; set; }

        public string BuyUnitQuantity { get; set; }

        public string QuantityPerScan { get; set; }

        public string SellUnitQuantity { get; set; }

        public string PreorderQuantity { get; set; }

        public string PickPriority { get; set; }

        public string PickZone { get; set; }

        public bool Approved { get; set; }

        public bool ApprovedSpecified { get; set; }

        public bool IsActive { get; set; }

        public bool IsActiveSpecified { get; set; }

        public bool Visible { get; set; }

        public bool VisibleSpecified { get; set; }

        public bool TaxFreeItem { get; set; }

        public bool TaxFreeItemSpecified { get; set; }

        public bool TaxInclusive { get; set; }

        public bool TaxInclusiveSpecified { get; set; }

        public bool ApprovedForPOS { get; set; }

        public bool ApprovedForPOSSpecified { get; set; }

        public bool ApprovedForMobileStore { get; set; }

        public bool ApprovedForMobileStoreSpecified { get; set; }

        public string SearchKeywords { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string TermsAndConditions { get; set; }

        public string Features { get; set; }

        public string Specifications { get; set; }

        public string Warranty { get; set; }

        public string ArtistOrAuthor { get; set; }

        public string Format { get; set; }

        public string ModelNumber { get; set; }

        public string Subtitle { get; set; }

        public string AvailabilityDescription { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<SalesChannel>))]
        public List<SalesChannel> SalesChannels { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<Image>))]
        public List<Image> Images { get; set; }

        public string ImageURL { get; set; }

        public string BrochureURL { get; set; }

        public string ProductURL { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateAdded { get; set; }

        public bool DateAddedSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateAddedLocal { get; set; }

        public bool DateAddedLocalSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateAddedUTC { get; set; }

        public bool DateAddedUTCSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdated { get; set; }

        public bool DateUpdatedSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdatedLocal { get; set; }

        public bool DateUpdatedLocalSpecified { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdatedUTC { get; set; }

        public bool DateUpdatedUTCSpecified { get; set; }

        public string UPC { get; set; }

        public string UPC1 { get; set; }

        public string UPC2 { get; set; }

        public string UPC3 { get; set; }

        public string Type { get; set; }

        public string SubType { get; set; }

        public string NumbersOfLabelsToPrint { get; set; }

        public string ReferenceNumber { get; set; }

        public string InternalNotes { get; set; }

        public string BarcodeHeight { get; set; }

        public string IsInventoried { get; set; }

        public string IsBought { get; set; }

        public string IsSold { get; set; }

        public string ExpenseAccount { get; set; }

        public string PurchaseTaxCode { get; set; }

        public string CostOfSalesAccount { get; set; }

        public string IncomeAccount { get; set; }

        public string AssetAccount { get; set; }

        public decimal ItemHeight { get; set; }

        public bool ItemHeightSpecified { get; set; }

        public decimal ItemLength { get; set; }

        public bool ItemLengthSpecified { get; set; }

        public decimal ItemWidth { get; set; }

        public bool ItemWidthSpecified { get; set; }

        public decimal ShippingHeight { get; set; }

        public bool ShippingHeightSpecified { get; set; }

        public decimal ShippingLength { get; set; }

        public bool ShippingLengthSpecified { get; set; }

        public decimal ShippingWidth { get; set; }

        public bool ShippingWidthSpecified { get; set; }

        public decimal ShippingWeight { get; set; }

        public bool ShippingWeightSpecified { get; set; }

        public decimal CubicWeight { get; set; }

        public bool CubicWeightSpecified { get; set; }

        public string SupplierItemCode { get; set; }

        public string SplitForWarehousePicking { get; set; }

        public string EBayDescription { get; set; }

        public string PrimarySupplier { get; set; }

        public string DisplayTemplate { get; set; }

        public bool EditableKitBundle { get; set; }

        public bool EditableKitBundleSpecified { get; set; }

        public bool RequiresPackaging { get; set; }

        public bool RequiresPackagingSpecified { get; set; }

        public string SEOPageTitle { get; set; }

        public string SEOMetaKeywords { get; set; }

        public string SEOPageHeading { get; set; }

        public string SEOMetaDescription { get; set; }

        public string SEOCanonicalURL { get; set; }

        public bool IsAsset { get; set; }

        public bool IsAssetSpecified { get; set; }

        public string WhenToRepeatOnStandingOrders { get; set; }

        public bool SerialTracking { get; set; }

        public bool SerialTrackingSpecified { get; set; }

        public string Group { get; set; }

        public string ShippingCategory { get; set; }

        public string Job { get; set; }

        public decimal MonthlySpendRequirement { get; set; }

        public bool MonthlySpendRequirementSpecified { get; set; }

        public string RestrictedToUserGroup { get; set; }

        public string ItemURL { get; set; }

        public bool AutomaticURL { get; set; }

        public bool AutomaticURLSpecified { get; set; }

        public string CommittedQuantity { get; set; }

        public string Misc01 { get; set; }

        public string Misc02 { get; set; }

        public string Misc03 { get; set; }

        public string Misc04 { get; set; }

        public string Misc05 { get; set; }

        public string Misc06 { get; set; }

        public string Misc07 { get; set; }

        public string Misc08 { get; set; }

        public string Misc09 { get; set; }

        public string Misc10 { get; set; }

        public string Misc11 { get; set; }

        public string Misc12 { get; set; }

        public string Misc13 { get; set; }

        public string Misc14 { get; set; }

        public string Misc15 { get; set; }

        public string Misc16 { get; set; }

        public string Misc17 { get; set; }

        public string Misc18 { get; set; }

        public string Misc19 { get; set; }

        public string Misc20 { get; set; }

        public string Misc21 { get; set; }

        public string Misc22 { get; set; }

        public string Misc23 { get; set; }

        public string Misc24 { get; set; }

        public string Misc25 { get; set; }

        public string Misc26 { get; set; }

        public string Misc27 { get; set; }

        public string Misc28 { get; set; }

        public string Misc29 { get; set; }

        public string Misc30 { get; set; }

        public string Misc31 { get; set; }

        public string Misc32 { get; set; }

        public string Misc33 { get; set; }

        public string Misc34 { get; set; }

        public string Misc35 { get; set; }

        public string Misc36 { get; set; }

        public string Misc37 { get; set; }

        public string Misc38 { get; set; }

        public string Misc39 { get; set; }

        public string Misc40 { get; set; }

        public string Misc41 { get; set; }

        public string Misc42 { get; set; }

        public string Misc43 { get; set; }

        public string Misc44 { get; set; }

        public string Misc45 { get; set; }

        public string Misc46 { get; set; }

        public string Misc47 { get; set; }

        public string Misc48 { get; set; }

        public string Misc49 { get; set; }

        public string Misc50 { get; set; }

        public string Misc51 { get; set; }

        public string Misc52 { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<FreeGift>))]
        public List<FreeGift> FreeGifts { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<CrossSellProduct>))]
        public List<CrossSellProduct> CrossSellProducts { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<UpsellProduct>))]
        public List<UpsellProduct> UpsellProducts { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<KitComponent>))]
        public List<KitComponent> KitComponents { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<PriceGroup>))]
        public List<PriceGroup> PriceGroups { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<CategoryProduct>))]
        public List<CategoryProduct> Categories { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<ItemSpecific>))]
        public List<ItemSpecific> ItemSpecifics { get; set; }
        [JsonConverter(typeof(SingleOrArrayConverter<WarehouseQuantity>))]
        public List<WarehouseQuantity> WarehouseQuantity { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<WarehouseLocation>))]
        public List<WarehouseLocation> WarehouseLocations { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<RelatedContents>))]
        public List<RelatedContents> RelatedContents { get; set; }
    }

    public class WarehouseQuantity
    {
        public string WarehouseID { get; set; }
        public WarehouseQuantityAction Action { get; set; }
        public string Quantity { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WarehouseQuantityAction
    {
        [EnumMember(Value = "increment")]
        Increment,
        [EnumMember(Value = "decrement")]
        Decrement,
        [EnumMember(Value = "set")]
        Set
    }
    public class SalesChannels
    {
        public SalesChannel[] SalesChannel { get; set; }
    }

    public class SalesChannel
    {
        public string SalesChannelName { get; set; }
        public string SalesChannelID { get; set; }
        public string IsApproved { get; set; }
    }

    public class PriceGroups
    {
        public PriceGroup PriceGroup { get; set; }
    }

    public class PriceGroup
    {
        public string GroupID { get; set; }
        public string Group { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public int Multiple { get; set; }
        public int MultipleStartQuantity { get; set; }
    }

    public class ItemSpecifics
    {
        public ItemSpecific ItemSpecific { get; set; }
    }

    public class ItemSpecific
    {
        public string Name { get; set; }
        public string Value { get; set; }

    }

    public class CategoryProduct
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

    public class WarehouseLocations
    {
        public WarehouseLocation WarehouseLocation { get; set; }
    }

    public class WarehouseLocation
    {
        public string LocationID { get; set; }
        public string WarehouseID { get; set; }
        public string Type { get; set; }
        public int Priority { get; set; }
    }

    public class KitComponents
    {
        public KitComponent KitComponent { get; set; }
    }
    public class KitComponent
    {
        public string ComponentSKU { get; set; }
        public string ComponentValue { get; set; }
        public int AssembleQuantity { get; set; }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public int SortOrder { get; set; }
    }

    public class FreeGift
    {
        public string SKU { get; set; }
    }

    public class CrossSellProduct
    {
        public string SKU { get; set; }
    }
    public class UpsellProduct
    {
        public string SKU { get; set; }
    }
    
    public class RelatedContents
    {
        public int ContentID { get; set; }
        public string ContentName { get; set; }
        public string ContentTypeName { get; set; }
    }
}
