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

        private string[] _SKU;
        private string[] _accountingCode;
        private int[] _inventoryID;
        private string _parentSKU;
        private string[] _brand;
        private string[] _model;
        private string[] _name;
        private string[] _primarySupplier;
        private bool[] _approved;
        private GetItemFilterApprovedForPOS[] _approvedForPOS;
        private GetItemFilterApprovedForMobileStore[] _approvedForMobileStore;
        private GetItemFilterSalesChannel[] _salesChannels;
        private bool[] _visible;
        private bool[] _isActive;
        private System.DateTime _dateAddedFrom;
        private System.DateTime _dateAddedTo;
        private System.DateTime _dateUpdatedFrom;
        private System.DateTime _dateUpdatedTo;
        private int[] _categoryID;
        private int _priority;
        private int _page;
        private int _limit;
        private GetItemFilterOrderBy _orderBy;
        private GetItemFilterOrderDirection _orderDirection;
        private GetItemFilterOutputSelector[] _outputSelector;

        public GetItemFilter()
        {

        }

        public GetItemFilter(int[] inventoryID) : base()
        {
            this._inventoryID = inventoryID;
        }

        public GetItemFilter(int inventoryID) 
            : this(new int[] { inventoryID })
        {
        }


        public string[] SKU
        {
            get
            {
                return this._SKU;
            }
            set
            {
                this._SKU = value;
            }
        }

        public string[] AccountingCode
        {
            get
            {
                return this._accountingCode;
            }
            set
            {
                this._accountingCode = value;
            }
        }

        public int[] InventoryID
        {
            get
            {
                return this._inventoryID;
            }
            set
            {
                this._inventoryID = value;
            }
        }

        public string ParentSKU
        {
            get
            {
                return this._parentSKU;
            }
            set
            {
                this._parentSKU = value;
            }
        }

        public string[] Brand
        {
            get
            {
                return this._brand;
            }
            set
            {
                this._brand = value;
            }
        }

        public string[] Model
        {
            get
            {
                return this._model;
            }
            set
            {
                this._model = value;
            }
        }

        public string[] Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string[] PrimarySupplier
        {
            get
            {
                return this._primarySupplier;
            }
            set
            {
                this._primarySupplier = value;
            }
        }

        public bool[] Approved
        {
            get
            {
                return this._approved;
            }
            set
            {
                this._approved = value;
            }
        }

        public GetItemFilterApprovedForPOS[] ApprovedForPOS
        {
            get
            {
                return this._approvedForPOS;
            }
            set
            {
                this._approvedForPOS = value;
            }
        }

        public GetItemFilterApprovedForMobileStore[] ApprovedForMobileStore
        {
            get
            {
                return this._approvedForMobileStore;
            }
            set
            {
                this._approvedForMobileStore = value;
            }
        }

        public GetItemFilterSalesChannel[] SalesChannels
        {
            get
            {
                return this._salesChannels;
            }
            set
            {
                this._salesChannels = value;
            }
        }

        public bool[] Visible
        {
            get
            {
                return this._visible;
            }
            set
            {
                this._visible = value;
            }
        }

        public bool[] IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive = value;
            }
        }

        public System.DateTime DateAddedFrom
        {
            get
            {
                return this._dateAddedFrom;
            }
            set
            {
                this._dateAddedFrom = value;
            }
        }

        public System.DateTime DateAddedTo
        {
            get
            {
                return this._dateAddedTo;
            }
            set
            {
                this._dateAddedTo = value;
            }
        }

        public System.DateTime DateUpdatedFrom
        {
            get
            {
                return this._dateUpdatedFrom;
            }
            set
            {
                this._dateUpdatedFrom = value;
            }
        }

        public System.DateTime DateUpdatedTo
        {
            get
            {
                return this._dateUpdatedTo;
            }
            set
            {
                this._dateUpdatedTo = value;
            }
        }

        public int[] CategoryID
        {
            get
            {
                return this._categoryID;
            }
            set
            {
                this._categoryID = value;
            }
        }

        public int Priority
        {
            get
            {
                return this._priority;
            }
            set
            {
                this._priority = value;
            }
        }

        public int Page
        {
            get
            {
                return this._page;
            }
            set
            {
                this._page = value;
            }
        }

        public int Limit
        {
            get
            {
                return this._limit;
            }
            set
            {
                this._limit = value;
            }
        }

        public GetItemFilterOrderBy OrderBy
        {
            get
            {
                return this._orderBy;
            }
            set
            {
                this._orderBy = value;
            }
        }


        public GetItemFilterOrderDirection OrderDirection
        {
            get
            {
                return this._orderDirection;
            }
            set
            {
                this._orderDirection = value;
            }
        }

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


        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetItemFilterApprovedForPOS
        {
            True,
            False,
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetItemFilterApprovedForMobileStore
        {
            True,
            False,
        }
        public partial class GetItemFilterSalesChannel
        {
            private int salesChannelIDField;
            private bool isApprovedField;

            public int SalesChannelID
            {
                get
                {
                    return this.salesChannelIDField;
                }
                set
                {
                    this.salesChannelIDField = value;
                }
            }

            public bool IsApproved
            {
                get
                {
                    return this.isApprovedField;
                }
                set
                {
                    this.isApprovedField = value;
                }
            }
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
        /// </summary>
        /// <returns>bool</returns>
        internal override bool isValid()
        {

            if (!string.IsNullOrWhiteSpace(_parentSKU))
                return true;

            if(_dateAddedFrom != DateTime.MinValue)
                return true;

            if (_dateAddedTo != DateTime.MinValue)
                return true;

            if (_dateUpdatedFrom != DateTime.MinValue)
                return true;

            if (_dateUpdatedTo != DateTime.MinValue)
                return true;

            int requiredFilterCount = _SKU.NullSafeLength() +
                            _accountingCode.NullSafeLength() +
                            _inventoryID.NullSafeLength() +
                            _brand.NullSafeLength() +
                            _model.NullSafeLength() +
                            _name.NullSafeLength() +
                            _primarySupplier.NullSafeLength() +
                            _approved.NullSafeLength() +
                            _approvedForPOS.NullSafeLength() +
                            _approvedForMobileStore.NullSafeLength() +
                            _salesChannels.NullSafeLength() +
                            _visible.NullSafeLength() +
                            _isActive.NullSafeLength() +
                            _categoryID.NullSafeLength();


            if(requiredFilterCount != 0)
                return true;

            // TODO: Implement NetoRequestException
            throw new Exception("At least one filter is required in the GetItem request");
        }
    }
}