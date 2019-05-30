using NetoDotNET.Entities;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetoDotNET.Entities
{
    public class Order
    {

        public OrderLine[] OrderLine { get; set; }

        public string OrderID { get; set; }

        public string ID { get; set; }

        public string ComponentOfKit { get; set; }

        public string KitPartID { get; set; }

        public string ShippingOption { get; set; }

        public string DeliveryInstruction { get; set; }

        public string RelatedOrderID { get; set; }

        public string GrandTotal { get; set; }

        public bool TaxInclusive { get; set; }

        public decimal OrderTax { get; set; }

        public decimal SurchargeTotal { get; set; }

        public decimal SurchargeTaxable { get; set; }

        public decimal ShippingTotal { get; set; }

        public decimal ShippingTax { get; set; }

        public decimal ShippingDiscount { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateRequired { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateInvoiced { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePaid { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePlaced { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdated { get; set; }

        public bool ShippingSignature { get; set; }

        public string RealtimeConfirmation { get; set; }

        public string InternalOrderNotes { get; set; }

        public string Username { get; set; }

        public string OrderStatus { get; set; }

        public OrderType OrderType { get; set; }

        public OnHoldType OnHoldType { get; set; }

        public string Email { get; set; }

        public string SalesPerson { get; set; }

        public string CustomerRef1 { get; set; }

        public string CustomerRef2 { get; set; }

        public string CustomerRef3 { get; set; }

        public string CustomerRef4 { get; set; }

        public string CustomerRef5 { get; set; }

        public string CustomerRef6 { get; set; }

        public string CustomerRef7 { get; set; }

        public string CustomerRef8 { get; set; }

        public string CustomerRef9 { get; set; }

        public string CustomerRef10 { get; set; }

        public string SalesChannel { get; set; }

        public string ShipFirstName { get; set; }

        public string ShipLastName { get; set; }

        public string ShipCompany { get; set; }

        public string ShipStreetLine1 { get; set; }

        public string ShipStreetLine2 { get; set; }

        public string ShipCity { get; set; }

        public string ShipCountry { get; set; }

        public string ShipState { get; set; }

        public string ShipPostCode { get; set; }

        public string ShipPhone { get; set; }

        public string ShipFax { get; set; }

        public string BillFirstName { get; set; }

        public string BillLastName { get; set; }

        public string BillCompany { get; set; }

        public string BillStreetLine1 { get; set; }

        public string BillStreetLine2 { get; set; }

        public string BillCity { get; set; }

        public string BillCountry { get; set; }

        public string BillState { get; set; }

        public string BillPostCode { get; set; }

        public string BillPhone { get; set; }

        public string BillFax { get; set; }

        public decimal ProductSubtotal { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public string CouponCode { get; set; }

        public decimal CouponDiscount { get; set; }

        public string CompleteStatus { get; set; }

        public OrderEBay eBay { get; set; }

        public OrderPayment[] OrderPayment { get; set; }

        public StickyNotes[] StickyNotes { get; set; }
    }

    public class OrderLine
    {
        public int Quantity { get; set; }

        public string SKU { get; set; }

        public string OrderLineID { get; set; }

        public string ProductName { get; set; }

        public string ItemNotes { get; set; }

        public string SerialNumber { get; set; }

        public int PickQuantity { get; set; }

        public int BackorderQuantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Tax { get; set; }

        public string TaxCode { get; set; }

        public int WarehouseID { get; set; }

        public string WarehouseName { get; set; }

        public string WarehouseReference { get; set; }

        public decimal PercentDiscount { get; set; }

        public decimal ProductDiscount { get; set; }

        public decimal CostPrice { get; set; }

        public string ShippingMethod { get; set; }

        public string ShippingTracking { get; set; }

        public decimal Shipping { get; set; }

        public decimal Weight { get; set; }

        public decimal Cubic { get; set; }

        public string Extra { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<ExtraOptions>))]
        public List<ExtraOptions> ExtraOptions { get; set; }

        public string BinLoc { get; set; }

        public int QuantityShipped { get; set; }

        public decimal CouponDiscount { get; set; }

        public OrderLineEBay eBay { get; set; }
    }

    public class ExtraOptions
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
    public class OrderPayment
    {
        public string OrderPaymentID { get; set; }
        public decimal OrderPaymentAmount { get; set; }
        public string PaymentType { get; set; }
    }

    public class OrderEBay
    {
        public string eBayUsername { get; set; }
    }

    public class OrderLineEBay
    {
        public string eBayUsername { get; set; }

        public string eBayStoreName { get; set; }

        public string eBayAuctionID { get; set; }

        public string eBayTransactionID { get; set; }

        public string ListingType { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateCreated { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePaid { get; set; }
    }

    public class StickyNotes
    {
        public int StickyNoteID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

[JsonConverter(typeof(StringEnumConverter))]
//public enum GetOrderFilterOrderStatus.
public enum OrderStatus
{
    Quote,
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
//public enum GetOrderFilterOrderType
public enum OrderType
{
    Sales,
    Dropshipping,
    Quote,
}

[JsonConverter(typeof(StringEnumConverter))]
//public enum GetOrderFilterOnHoldType
public enum OnHoldType
{
    [EnumMember(Value = "On Hold")]
    OnHold,
    Layby,
}


#region AddedOrder

[JsonObject(Title = "Order")]
public class AddOrder
{
    public string OrderID { get; set; }

    public string PurchaseOrderNumber { get; set; }

    public OrderType OrderType { get; set; }

    public OnHoldType OnHoldType { get; set; }

    public string UserGroup { get; set; }

    public string DocumentTemplate { get; set; }

    public DateTime DatePlaced { get; set; }

    public DateTime DateRequired { get; set; }

    public DateTime DateInvoiced { get; set; }

    public DateTime DateDue { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }

    public string BillFirstName { get; set; }

    public string BillLastName { get; set; }

    public string BillCompany { get; set; }

    public string BillStreet1 { get; set; }

    public string BillStreet2 { get; set; }

    public string BillCity { get; set; }

    public string BillState { get; set; }

    public string BillPostCode { get; set; }

    public string BillContactPhone { get; set; }

    public string BillCountry { get; set; }

    public string ShipFirstName { get; set; }

    public string ShipLastName { get; set; }

    public string ShipCompany { get; set; }

    public string ShipStreet1 { get; set; }

    public string ShipStreet2 { get; set; }

    public string ShipCity { get; set; }

    public string ShipState { get; set; }

    public string ShipPostCode { get; set; }

    public string ShipContactPhone { get; set; }

    public string ShipCountry { get; set; }

    public string SalesPerson { get; set; }

    public string CustomerRef1 { get; set; }

    public string CustomerRef2 { get; set; }

    public string CustomerRef3 { get; set; }

    public string CustomerRef4 { get; set; }

    public string CustomerRef5 { get; set; }

    public string CustomerRef6 { get; set; }

    public string CustomerRef7 { get; set; }

    public string CustomerRef8 { get; set; }

    public string CustomerRef9 { get; set; }

    public string CustomerRef10 { get; set; }

    public string SalesChannel { get; set; }

    public string ShipInstructions { get; set; }

    public string InternalOrderNotes { get; set; }

    public string StickyNoteTitle { get; set; }

    public string StickyNote { get; set; }

    public StickyNotes[] StickyNotes { get; set; }

    public OrderStatus OrderStatus { get; set; }

    public bool OrderApproval { get; set; }

    public string PaymentMethod { get; set; }

    public string PaymentTerms { get; set; }

    public bool TaxInclusive { get; set; }

    public bool TaxFreeShipping { get; set; }

    public string BPAYCRN { get; set; }

    public string ShippingMethod { get; set; }

    public decimal ShippingCost { get; set; }

    public bool SignatureRequired { get; set; }

    public string CurrencyCode { get; set; }

    public AddOrderLine[] orderLine { get; set; }

    public decimal OrderRounding { get; set; }

}


[JsonObject(Title = "OrderLine")]
public class AddOrderLine
{
    public string SKU { get; set; }

    public string ItemNotes { get; set; }

    public string ItemDescription { get; set; }

    public string ItemSerialNumber { get; set; }

    public string Dropshipper { get; set; }

    public string WarehouseName { get; set; }

    public string WarehouseReference { get; set; }

    public bool TaxFree { get; set; }

    public string WarehouseID { get; set; }

    public string Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal UnitCost { get; set; }

    public decimal ShippingWeight { get; set; }

    public string QuantityShipped { get; set; }

    public decimal DiscountPercent { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal Cubic { get; set; }

    public OrderLineKitComponents[] kitComponents { get; set; }

    public string[] Text { get; set; }
}


[JsonObject(Title = "KitComponents")]
public class OrderLineKitComponents
{
    public string ComponentSKU { get; set; }

    public decimal ComponentValue { get; set; }

    public string AssembleQuantity { get; set; }

    public bool ComponentTaxFree { get; set; }
}
#endregion