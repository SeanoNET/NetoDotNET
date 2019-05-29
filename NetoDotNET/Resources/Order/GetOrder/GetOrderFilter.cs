using NetoDotNET.Exceptions;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetoDotNET.Resources.Orders
{
    [JsonObject(Title = "Filter")]
    public class GetOrderFilter : NetoGetResourceFilter
    {

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetItem request. These will determine the results returned.
        /// </summary>
        public GetOrderFilter()
        {

        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetItem request. These will determine the results returned.
        /// </summary>
        public GetOrderFilter(string[] orderID) : base()
        {
            this.OrderID = orderID;
        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetItem request. These will determine the results returned.
        /// </summary>
        public GetOrderFilter(string orderID)
            : this(new string[] { orderID})
        {
        }

        public string[] OrderID { get; set; }

        public string[] Username { get; set; }

        public string[] SKU { get; set; }

        public string[] Supplier { get; set; }

        public GetOrderFilterOrderStatus[] OrderStatus { get; set; }

        public GetOrderFilterOrderType[] OrderType { get; set; }

        public GetOrderFilterOnHoldType[] OnHoldType { get; set; }

        public GetOrderFilterCompleteStatus[] CompleteStatus { get; set; }

        public GetOrderFilterPaymentStatus[] PaymentStatus { get; set; }

        public GetOrderFilterExportStatus[] ExportStatus { get; set; }

        public string[] WarehouseID { get; set; }

        public bool ExportedToWMS { get; set; }

        public string[] ShippingMethod { get; set; }

        public string[] SalesChannel { get; set; }

        public DateTime DatePaidFrom { get; set; }

        public DateTime DatePaidTo { get; set; }

        public DateTime DateRequiredFrom { get; set; }

        public DateTime DateRequiredTo { get; set; }

        public DateTime DateInvoicedFrom { get; set; }

        public DateTime DateInvoicedTo { get; set; }

        public DateTime DatePlacedFrom { get; set; }

        public DateTime DatePlacedTo { get; set; }

        public DateTime DateUpdatedFrom { get; set; }

        public DateTime DateUpdatedTo { get; set; }

        public DateTime DateCompletedFrom { get; set; }

        public DateTime DateCompletedTo { get; set; }

        public DateTime WarehouseQuantityUpdatedFrom { get; set; }

        public DateTime WarehouseQuantityUpdatedTo { get; set; }

        public bool SplitKitComponents { get; set; }

        public int Page { get; set; }
        public int Limit { get; set; }

        private GetOrderFilterOutputSelector[] _outputSelector;
        public GetOrderFilterOutputSelector[] OutputSelector
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

        public GetOrderFilterUpdateResults updateResults { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetOrderFilterOrderStatus
        {
            New,
            [EnumMember(Value = "New Backorder")]
            NewBackorder,
            [EnumMember(Value = "Backorder Approved")]
            BackorderApproved,
            Pick,
            Pack,
            [EnumMember(Value = "Pending Pickup")]
            PendingPickup,
            [EnumMember(Value = "Pending Dispatch")]
            PendingDispatch,
            Dispatched,
            Cancelled,
            Uncommitted,
            [EnumMember(Value = "On Hold")]
            OnHold,
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetOrderFilterOrderType
        {
            sales,
            dropshipping,
        }
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetOrderFilterOnHoldType
        {
            [EnumMember(Value = "On Hold")]
            OnHold,
            Layby,
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetOrderFilterCompleteStatus
        {
            Approved,
            Incomplete,
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetOrderFilterPaymentStatus
        {
            FullyPaid,
            PartialPaid,
            Pending,
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetOrderFilterExportStatus
        {
            Pending,
            Exported,
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetOrderFilterOutputSelector
        {
            ID,
            ShippingOption,
            DeliveryInstruction,
            RelatedOrderID,
            Username,
            Email,
            ShipAddress,
            BillAddress,
            PurchaseOrderNumber,
            SalesPerson,
            CustomerRef1,
            CustomerRef2,
            CustomerRef3,
            CustomerRef4,
            CustomerRef5,
            CustomerRef6,
            CustomerRef7,
            CustomerRef8,
            CustomerRef9,
            CustomerRef10,
            SalesChannel,
            GrandTotal,
            TaxInclusive,
            OrderTax,
            SurchargeTotal,
            SurchargeTaxable,
            ProductSubtotal,
            ShippingTotal,
            ShippingTax,
            ClientIPAddress,
            CouponCode,
            CouponDiscount,
            ShippingDiscount,
            OrderType,
            OnHoldType,
            OrderStatus,
            OrderPayment,
            [EnumMember(Value = "OrderPayment.PaymentType")]
            OrderPaymentPaymentType,
            [EnumMember(Value = "OrderPayment.DatePaid")]
            OrderPaymentDatePaid,
            DateUpdated,
            DatePlaced,
            DateRequired,
            DateInvoiced,
            DatePaid,
            DateCompleted,
            OrderLine,
            [EnumMember(Value = "OrderLine.ProductName")]
            OrderLineProductName,
            [EnumMember(Value = "OrderLine.ItemNotes")]
            OrderLineItemNotes,
            [EnumMember(Value = "OrderLine.SerialNumber")]
            OrderLineSerialNumber,
            [EnumMember(Value = "OrderLine.PickQuantity")]
            OrderLinePickQuantity,
            [EnumMember(Value = "OrderLine.BackorderQuantity")]
            OrderLineBackorderQuantity,
            [EnumMember(Value = "OrderLine.UnitPrice")]
            OrderLineUnitPrice,
            [EnumMember(Value = "OrderLine.Tax")]
            OrderLineTax,
            [EnumMember(Value = "OrderLine.TaxCode")]
            OrderLineTaxCode,
            [EnumMember(Value = "OrderLine.WarehouseID")]
            OrderLineWarehouseID,
            [EnumMember(Value = "OrderLine.WarehouseName")]
            OrderLineWarehouseName,
            [EnumMember(Value = "OrderLine.WarehouseReference")]
            OrderLineWarehouseReference,
            [EnumMember(Value = "OrderLine.Quantity")]
            OrderLineQuantity,
            [EnumMember(Value = "OrderLine.PercentDiscount")]
            OrderLinePercentDiscount,
            [EnumMember(Value = "OrderLine.ProductDiscount")]
            OrderLineProductDiscount,
            [EnumMember(Value = "OrderLine.CouponDiscount")]
            OrderLineCouponDiscount,
            [EnumMember(Value = "OrderLine.CostPrice")]
            OrderLineCostPrice,
            [EnumMember(Value = "OrderLine.ShippingMethod")]
            OrderLineShippingMethod,
            [EnumMember(Value = "OrderLine.ShippingTracking")]
            OrderLineShippingTracking,
            [EnumMember(Value = "OrderLine.Weight")]
            OrderLineWeight,
            [EnumMember(Value = "OrderLine.Cubic")]
            OrderLineCubic,
            [EnumMember(Value = "OrderLine.Extra")]
            OrderLineExtra,
            [EnumMember(Value = "OrderLine.ExtraOptions")]
            OrderLineExtraOptions,
            [EnumMember(Value = "OrderLine.BinLoc")]
            OrderLineBinLoc,
            [EnumMember(Value = "OrderLine.QuantityShipped")]
            OrderLineQuantityShipped,
            ShippingSignature,
            RealtimeConfirmation,
            InternalOrderNotes,
            [EnumMember(Value = "OrderLine.eBay.eBayUsername")]
            OrderLineeBayeBayUsername,
            [EnumMember(Value = "OrderLine.eBay.eBayStoreName")]
            OrderLineeBayeBayStoreName,
            [EnumMember(Value = "OrderLine.eBay.eBayTransactionID")]
            OrderLineeBayeBayTransactionID,
            [EnumMember(Value = "OrderLine.eBay.eBayAuctionID")]
            OrderLineeBayeBayAuctionID,
            [EnumMember(Value = "OrderLine.eBay.ListingType")]
            OrderLineeBayListingType,
            [EnumMember(Value = "OrderLine.eBay.DateCreated")]
            OrderLineeBayDateCreated,
            CompleteStatus,
            [EnumMember(Value = "OrderLine.eBay.DatePaid")]
            OrderLineeBayDatePaid,
            UserGroup,
            StickyNotes,
        }

        public class GetOrderFilterUpdateResults
        {
            public GetOrderFilterUpdateResultsExportStatus ExportStatus { get; set; }

            public bool ExportedToWMS { get; set; }
        }

        public enum GetOrderFilterUpdateResultsExportStatus
        {
            Pending,
            Exported,
        }

        private GetOrderFilterOutputSelector[] InitEmptyOutputSelector()
        {
            var outputSelectors = new List<GetOrderFilterOutputSelector>();

            foreach (GetOrderFilterOutputSelector item in (GetOrderFilterOutputSelector[])System.Enum.GetValues(typeof(GetOrderFilterOutputSelector)))
            {
                outputSelectors.Add(item);
            }

            return outputSelectors.ToArray();
        }

        internal override bool isValid()
        {

            if (DatePaidFrom != DateTime.MinValue)
                return true;

            if (DatePaidTo != DateTime.MinValue)
                return true;

            if (DateRequiredFrom != DateTime.MinValue)
                return true;

            if (DateRequiredTo != DateTime.MinValue)
                return true;

            if (DateInvoicedFrom != DateTime.MinValue)
                return true;

            if (DateInvoicedTo != DateTime.MinValue)
                return true;

            if (DatePlacedFrom != DateTime.MinValue)
                return true;

            if (DatePlacedTo != DateTime.MinValue)
                return true;

            if (DateUpdatedFrom != DateTime.MinValue)
                return true;

            if (DateUpdatedTo != DateTime.MinValue)
                return true;

            if (DateCompletedFrom != DateTime.MinValue)
                return true;

            if (DateCompletedTo != DateTime.MinValue)
                return true;

            if (WarehouseQuantityUpdatedFrom != DateTime.MinValue)
                return true;

            if (WarehouseQuantityUpdatedTo != DateTime.MinValue)
                return true;

            int requiredFilterCount = OrderID.NullSafeLength() +
                            Username.NullSafeLength() +
                            SKU.NullSafeLength() +
                            Supplier.NullSafeLength() +
                            WarehouseID.NullSafeLength() +
                            ShippingMethod.NullSafeLength() +
                            SalesChannel.NullSafeLength();


            if (requiredFilterCount != 0)
                return true;

            throw new NetoRequestException("At least one filter is required in the GetOrder request");
        }
    }
}
