using NetoDotNET.Exceptions;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetoDotNET.Resources.RMA
{
    public class GetRMAFilter : NetoGetResourceFilter
    {

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetRMA request. These will determine the results returned.
        /// </summary>
        public GetRMAFilter()
        {

        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetRMA request. These will determine the results returned.
        /// </summary>
        public GetRMAFilter(int[] rmaID) : base()
        {
            this.RmaID = rmaID;
        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetRMA request. These will determine the results returned.
        /// </summary>
        public GetRMAFilter(int rmaID)
            : this(new int[] { rmaID })
        {
        }

        public string[] OrderID { get; set; }

        public string[] Username { get; set; }

        public int[] RmaID { get; set; }

        public string[] InvoiceNumber { get; set; }

        public string[] RmaStatus { get; set; }

        public DateTime DateIssuedFrom { get; set; }

        public DateTime DateIssuedTo { get; set; }

        public DateTime DateUpdatedFrom { get; set; }

        public DateTime DateUpdatedTo { get; set; }

        public DateTime DateApprovedFrom { get; set; }

        public DateTime DateApprovedTo { get; set; }

        public string[] SplitKitComponents { get; set; }


        private GetRMAFilterOutputSelector[] _outputSelector;

        public GetRMAFilterOutputSelector[] OutputSelector
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
        public string[] SortBy { get; set; }

        public int Page { get; set; }
        public int Limit { get; set; }

        private GetRMAFilterOutputSelector[] InitEmptyOutputSelector()
        {
            var outputSelectors = new List<GetRMAFilterOutputSelector>();

            foreach (GetRMAFilterOutputSelector item in (GetRMAFilterOutputSelector[])System.Enum.GetValues(typeof(GetRMAFilterOutputSelector)))
            {
                outputSelectors.Add(item);
            }

            return outputSelectors.ToArray();
        }


        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetRMAFilterOutputSelector
        {
            OrderID,
            InvoiceNumber,
            CustomerUsername,
            StaffUsername,
            PurchaseOrderNumber,
            InternalNotes,
            CurrencyCode,
            RmaStatus,
            ShippingRefundAmount,
            ShippingRefundTaxCode,
            SurchargeRefundAmount,
            RefundSubtotal,
            RefundTotal,
            RefundTaxTotal,
            TaxInclusive,
            DateIssued,
            DateUpdated,
            DateApproved,
            RmaLine,
            [EnumMember(Value = "RmaLine.ItemNumber")]
            RmaLineItemNumber,
            [EnumMember(Value = "RmaLine.Extra")]
            RmaLineExtra,
            [EnumMember(Value = "RmaLine.ExtraOptions")]
            RmaLineExtraOptions,
            [EnumMember(Value = "RmaLine.ItemNotes")]
            RmaLineItemNotes,
            [EnumMember(Value = "RmaLine.ProductName")]
            RmaLineProductName,
            [EnumMember(Value = "RmaLine.RefundSubtotal")]
            RmaLineRefundSubtotal,
            [EnumMember(Value = "RmaLine.Tax")]
            RmaLineTax,
            [EnumMember(Value = "RmaLine.TaxCode")]
            RmaLineTaxCode,
            [EnumMember(Value = "RmaLine.WarehouseID")]
            RmaLineWarehouseID,
            [EnumMember(Value = "RmaLine.WarehouseName")]
            RmaLineWarehouseName,
            [EnumMember(Value = "RmaLine.WarehouseReference")]
            RmaLineWarehouseReference,
            [EnumMember(Value = "RmaLine.ResolutionOutcome")]
            RmaLineResolutionOutcome,
            [EnumMember(Value = "RmaLine.ReturnReason")]
            RmaLineReturnReason,
            [EnumMember(Value = "RmaLine.ItemStatusType")]
            RmaLineItemStatusType,
            [EnumMember(Value = "RmaLine.ItemStatus")]
            RmaLineItemStatus,
            [EnumMember(Value = "RmaLine.ResolutionStatus")]
            RmaLineResolutionStatus,
            [EnumMember(Value = "RmaLine.ManufacturerClaims")]
            RmaLineManufacturerClaims,
            [EnumMember(Value = "RmaLine.IsRestockIssued")]
            RmaLineIsRestockIssued,
            RefundedTotal,
            Refund,
            [EnumMember(Value = "Refund.PaymentMethodID")]
            RefundPaymentMethodID,
            [EnumMember(Value = "Refund.PaymentMethodName")]
            RefundPaymentMethodName,
            [EnumMember(Value = "Refund.DateIssued")]
            RefundDateIssued,
            [EnumMember(Value = "Refund.DateRefunded")]
            RefundDateRefunded,
            [EnumMember(Value = "Refund.RefundStatus")]
            RefundRefundStatus,
        }


        internal override bool isValid()
        {

            if (DateIssuedFrom != DateTime.MinValue)
                return true;

            if (DateIssuedTo != DateTime.MinValue)
                return true;

            if (DateUpdatedFrom != DateTime.MinValue)
                return true;

            if (DateUpdatedTo != DateTime.MinValue)
                return true;

            if (DateApprovedFrom != DateTime.MinValue)
                return true;

            if (DateApprovedTo != DateTime.MinValue)
                return true;

            int requiredFilterCount = OrderID.NullSafeLength() +
                            Username.NullSafeLength() +
                            RmaID.NullSafeLength() +
                            InvoiceNumber.NullSafeLength() +
                            RmaStatus.NullSafeLength() +
                            SplitKitComponents.NullSafeLength();
                           


            if (requiredFilterCount != 0)
                return true;

            throw new NetoRequestException("At least one filter is required in the GetRMA request");
        }
    }
}
