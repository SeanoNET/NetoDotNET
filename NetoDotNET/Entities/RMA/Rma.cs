using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class Rma
    {
        public int RmaID { get; set; }

        public string OrderID { get; set; }

        public string InvoiceNumber { get; set; }

        public string CustomerUsername { get; set; }

        public string StaffUsername { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public string InternalNotes { get; set; }

        public string CurrencyCode { get; set; }

        public string RmaStatus { get; set; }

        public decimal ShippingRefundAmount { get; set; }

        public string ShippingRefundTaxCode { get; set; }
        public decimal SurchargeRefundAmount { get; set; }

        public decimal RefundSubtotal { get; set; }

        public decimal RefundTotal { get; set; }

        public decimal RefundTaxTotal { get; set; }

        public bool TaxInclusive { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateIssued { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdated { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateApproved { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<RmaLines>))]
        public List<RmaLines> RmaLines { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<RmaRefunds>))]
        public List<RmaRefunds> Refunds { get; set; }

        public decimal RefundedTotal { get; set; }

    }

    public class RmaLines
    {
        [JsonConverter(typeof(SingleOrArrayConverter<RmaLine>))]
        public List<RmaLine> RmaLine { get; set; }
    }
    public class RmaLine
    {
        public string RmaLineID { get; set; }

        public string SKU { get; set; }

        public int Quantity { get; set; }

        public string ProductName { get; set; }

        public string ItemNotes { get; set; }

        public string ItemNumber { get; set; }

        public string Extra { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<RmaLinesExtraOptions>))]
        public List<RmaLinesExtraOptions> ExtraOptions { get; set; }

        public decimal RefundSubtotal { get; set; }

        public decimal Tax { get; set; }

        public string TaxCode { get; set; }

        public int WarehouseID { get; set; }

        public string WarehouseName { get; set; }

        public string WarehouseReference { get; set; }

        public string ResolutionOutcome { get; set; }

        public string ReturnReason { get; set; }

        public string ItemStatusType { get; set; }

        public string ItemStatus { get; set; }

        public string ResolutionStatus { get; set; }

        public string ManufacturerClaims { get; set; }

        public int ComponentOfKit { get; set; }

        public int KitPartID { get; set; }
    }

    public class RmaLinesExtraOptions
    {
        [JsonConverter(typeof(SingleOrArrayConverter<ExtraOption>))]
        public List<ExtraOption> ExtraOption { get; set; }
    }
    public class ExtraOption
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class RmaRefunds
    {
        public int RefundID { get; set; }

        public decimal RefundAmount { get; set; }

        public int PaymentMethodID { get; set; }

        public string PaymentMethodName { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateIssued { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateRefunded { get; set; }

        public string RefundStatus { get; set; }
    }
}
