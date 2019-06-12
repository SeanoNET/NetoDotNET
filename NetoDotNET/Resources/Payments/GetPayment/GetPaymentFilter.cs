using NetoDotNET.Exceptions;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Payments
{
    [JsonObject(Title = "Filter")]
    public class GetPaymentFilter : NetoGetResourceFilter
    {
        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetPayment request. These will determine the results returned.
        /// </summary>
        public GetPaymentFilter()
        {

        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetPayment request. These will determine the results returned.
        /// </summary>
        public GetPaymentFilter(int[] paymentID) : base()
        {
            this.PaymentID = paymentID;
        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetPayment request. These will determine the results returned.
        /// </summary>
        public GetPaymentFilter(int paymentID)
            : this(new int[] { paymentID })
        {
        }

        public int[] PaymentID { get; set; }

        public string[] OrderID { get; set; }

        public DateTime DatePaidFrom { get; set; }

        public DateTime DatePaidTo { get; set; }

        public int Page { get; set; }
        public int Limit { get; set; }

        private GetPaymentFilterOutputSelector[] _outputSelector;
        public GetPaymentFilterOutputSelector[] OutputSelector
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
        public enum GetPaymentFilterOutputSelector
        {
            ID,
            AmountPaid,
            CurrencyCode,
            DatePaid,
            DatePaidLocal,
            DatePaidUTC,
            PaymentMethod,
            PaymentMethodName,
            ProcessBy,
            AuthorisationMessage,
            CardHolder,
            CardExpiryDate,
            CardAuthorisation,
            AccountName,
            AccountBSB,
            PaymentNotes,
            AccountNumber,
            ChequeNumber,
        }

        private GetPaymentFilterOutputSelector[] InitEmptyOutputSelector()
        {
            var outputSelectors = new List<GetPaymentFilterOutputSelector>();

            foreach (GetPaymentFilterOutputSelector item in (GetPaymentFilterOutputSelector[])System.Enum.GetValues(typeof(GetPaymentFilterOutputSelector)))
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

            int requiredFilterCount = PaymentID.NullSafeLength() +
                            OrderID.NullSafeLength();


            if (requiredFilterCount != 0)
                return true;

            throw new NetoRequestException("At least one filter is required in the GetPayment request");
        }
    }
}
