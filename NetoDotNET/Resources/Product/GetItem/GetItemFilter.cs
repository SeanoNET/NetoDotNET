using NetoDotNET.Exceptions;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace NetoDotNET.Resources
{

    [JsonObject(Title = "Filter")]
    public class GetItemFilter : NetoGetResourceFilter
    {
        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetItem request. These will determine the results returned.
        /// </summary>
        public GetItemFilter()
        {

        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetItem request. These will determine the results returned.
        /// </summary>
        public GetItemFilter(int[] inventoryID) : base()
        {
            this.InventoryID = inventoryID;
        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetItem request. These will determine the results returned.
        /// </summary>
        public GetItemFilter(int inventoryID)
            : this(new int[] { inventoryID })
        {
        }

        public string[] SKU { get; set; }
        public string[] AccountingCode { get; set; }

        public int[] InventoryID { get; set; }
        public string ParentSKU { get; set; }

        public string[] Brand { get; set; }
        public string[] Model { get; set; }
        public string[] Name { get; set; }
        public string[] PrimarySupplier { get; set; }
        public bool[] Approved { get; set; }
        public bool[] ApprovedForPOS { get; set; }
        public bool[] ApprovedForMobileStore { get; set; }
        public GetItemFilterSalesChannel[] SalesChannels { get; set; }
        public bool[] Visible { get; set; }
        public bool[] IsActive { get; set; }
        public DateTime DateAddedFrom { get; set; }
        public DateTime DateAddedTo { get; set; }
        public DateTime DateUpdatedFrom { get; set; }
        public DateTime DateUpdatedTo { get; set; }
        public int[] CategoryID { get; set; }
        public int Priority { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetItemFilterOrderBy OrderBy { get; set; }
        public GetItemFilterOrderDirection OrderDirection { get; set; }

        private GetItemFilterOutputSelector[] _outputSelector;
        public GetItemFilterOutputSelector[] OutputSelector
        {
            get
            {
                return this._outputSelector ?? InitEmptyOutputSelector();
            }
            set
            {
                this._outputSelector = value;
            }
        }

        public partial class GetItemFilterSalesChannel
        {
            public int SalesChannelID { get; set; }
            public bool IsApproved { get; set; }
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetItemFilterOrderBy
        {
            ParentSKU,
            ID,
            Model,
            Name,
            IsActive,
            DateAdded,
            DateUpdated,
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetItemFilterOrderDirection
        {
            ASC,
            DESC,
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetItemFilterOutputSelector
        {
            ParentSKU,
            ID,
            Brand,
            Model,
            Virtual,
            Name,
            PrimarySupplier,
            Approved,
            IsActive,
            FreeGifts,
            CrossSellProducts,
            UpsellProducts,
            PriceGroups,
            ItemLength,
            ItemWidth,
            ItemHeight,
            ShippingLength,
            ShippingWidth,
            ShippingHeight,
            ShippingWeight,
            CubicWeight,
            WarehouseQuantity,
            WarehouseLocations,
            CommittedQuantity,
            ItemSpecifics,
            Categories,
            AccountingCode,
            SortOrder1,
            SortOrder2,
            RRP,
            DefaultPrice,
            PromotionPrice,
            PromotionStartDate,
            PromotionStartDateLocal,
            PromotionStartDateUTC,
            PromotionExpiryDate,
            PromotionExpiryDateLocal,
            PromotionExpiryDateUTC,
            DateArrival,
            DateArrivalUTC,
            CostPrice,
            UnitOfMeasure,
            BaseUnitOfMeasure,
            BaseUnitPerQuantity,
            QuantityPerScan,
            BuyUnitQuantity,
            SellUnitQuantity,
            PreorderQuantity,
            PickPriority,
            PickZone,
            TaxFreeItem,
            TaxInclusive,
            SearchKeywords,
            ShortDescription,
            Description,
            Features,
            Specifications,
            Warranty,
            eBayDescription,
            TermsAndConditions,
            ArtistOrAuthor,
            Format,
            ModelNumber,
            Subtitle,
            AvailabilityDescription,
            Images,
            ImageURL,
            BrochureURL,
            ProductURL,
            DateAdded,
            DateAddedLocal,
            DateAddedUTC,
            DateUpdated,
            DateUpdatedLocal,
            DateUpdatedUTC,
            UPC,
            UPC1,
            UPC2,
            UPC3,
            Type,
            SubType,
            NumbersOfLabelsToPrint,
            ReferenceNumber,
            InternalNotes,
            BarcodeHeight,
            SupplierItemCode,
            SplitForWarehousePicking,
            DisplayTemplate,
            EditableKitBundle,
            RequiresPackaging,
            IsAsset,
            WhenToRepeatOnStandingOrders,
            SerialTracking,
            Group,
            ShippingCategory,
            MonthlySpendRequirement,
            RestrictedToUserGroup,
            IsInventoried,
            IsBought,
            IsSold,
            ExpenseAccount,
            PurchaseTaxCode,
            CostOfSalesAccount,
            IncomeAccount,
            AssetAccount,
            KitComponents,
            SEOPageTitle,
            SEOMetaKeywords,
            SEOPageHeading,
            SEOMetaDescription,
            SEOCanonicalURL,
            ItemURL,
            AutomaticURL,
            Job,
            RelatedContents,
            SalesChannels,
            Misc01,
            Misc02,
            Misc03,
            Misc04,
            Misc05,
            Misc06,
            Misc07,
            Misc08,
            Misc09,
            Misc10,
            Misc11,
            Misc12,
            Misc13,
            Misc14,
            Misc15,
            Misc16,
            Misc17,
            Misc18,
            Misc19,
            Misc20,
            Misc21,
            Misc22,
            Misc23,
            Misc24,
            Misc25,
            Misc26,
            Misc27,
            Misc28,
            Misc29,
            Misc30,
            Misc31,
            Misc32,
            Misc33,
            Misc34,
            Misc35,
            Misc36,
            Misc37,
            Misc38,
            Misc39,
            Misc40,
            Misc41,
            Misc42,
            Misc43,
            Misc44,
            Misc45,
            Misc46,
            Misc47,
            Misc48,
            Misc49,
            Misc50,
            Misc51,
            Misc52,
        }


        private GetItemFilterOutputSelector[] InitEmptyOutputSelector()
        {
            var outputSelectors = new List<GetItemFilterOutputSelector>();

            foreach (GetItemFilterOutputSelector item in (GetItemFilterOutputSelector[])System.Enum.GetValues(typeof(GetItemFilterOutputSelector)))
            {
                outputSelectors.Add(item);
            }

            return outputSelectors.ToArray();
        }


        /// <summary>
        /// Checks for at least one filter in the GetItem request. 
        /// See GetItem Post https://developers.neto.com.au/documentation/engineers/api-documentation/products/getitem
        /// </summary>
        /// <returns>bool</returns>
        internal override bool isValid()
        {

            if (!string.IsNullOrWhiteSpace(ParentSKU))
                return true;

            if(DateAddedFrom != DateTime.MinValue)
                return true;

            if (DateAddedTo != DateTime.MinValue)
                return true;

            if (DateUpdatedFrom != DateTime.MinValue)
                return true;

            if (DateUpdatedTo != DateTime.MinValue)
                return true;

            int requiredFilterCount = SKU.NullSafeLength() +
                            AccountingCode.NullSafeLength() +
                            InventoryID.NullSafeLength() +
                            Brand.NullSafeLength() +
                            Model.NullSafeLength() +
                            Name.NullSafeLength() +
                            PrimarySupplier.NullSafeLength() +
                            Approved.NullSafeLength() +
                            ApprovedForPOS.NullSafeLength() +
                            ApprovedForMobileStore.NullSafeLength() +
                            SalesChannels.NullSafeLength() +
                            Visible.NullSafeLength() +
                            IsActive.NullSafeLength() +
                            CategoryID.NullSafeLength();


            if(requiredFilterCount != 0)
                return true;

            throw new NetoRequestException("At least one filter is required in the GetItem request");
        }
    }
}