using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;

namespace NetoDotNET.Resources.Payments
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public string OrderID { get; set; }

        public decimal AmountPaid { get; set; }

        public string CurrencyCode { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePaid { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePaidLocal { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePaidUTC { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentMethodName { get; set; }

        public string ProcessBy { get; set; }

        public string AuthorisationMessage { get; set; }

        public string CardHolder { get; set; }

        public string CardExpiryDate { get; set; }

        public string CardAuthorisation { get; set; }

        public string AccountName { get; set; }

        public string AccountBSB { get; set; }

        public string AccountNumber { get; set; }

        public string ChequeNumber { get; set; }

        public string PaymentNotes { get; set; }
    }

    public class AddPayment
    {
        public string OrderID { get; set; }

        public string PaymentMethodID { get; set; }

        public string PaymentMethodName { get; set; }

        public string CardAuthorisation { get; set; }

        public decimal AmountPaid { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePaid { get; set; }

        public TransactionNotes[] TransactionNotes { get; set; }
    }

    public class TransactionNotes
    {
        public TransactionNote[] TransactionNote { get; set; }
    }

    public class TransactionNote
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}