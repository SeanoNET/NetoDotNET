using NetoDotNET.Exceptions;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace NetoDotNET.Resources.Customers
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FilterType
    {
        Prospect,
        Customer
    }
    public class GetCustomerFilter : NetoGetResourceFilter
    {
        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetItem request. These will determine the results returned.
        /// </summary>
        public GetCustomerFilter()
        {

        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetItem request. These will determine the results returned.
        /// </summary>
        public GetCustomerFilter(string[] username) : base()
        {
            this.Username = username;
        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetItem request. These will determine the results returned.
        /// </summary>
        public GetCustomerFilter(string username)
            : this(new string[] { username })
        {
        }


        public string[] Username { get; set; }

        public FilterType[] Type { get; set; }

        public bool[] Active { get; set; }

        public string[] Email { get; set; }

        public string[] Company { get; set; }

        public bool[] OnCreditHold { get; set; }

        public bool[] NewsletterSubscriber { get; set; }

        public string[] UserGroup { get; set; }

        public string[] BillState { get; set; }

        public DateTime DateAddedFrom { get; set; }
        public DateTime DateAddedTo { get; set; }
        public DateTime DateUpdatedFrom { get; set; }
        public DateTime DateUpdatedTo { get; set; }

        public int Page { get; set; }
        public int Limit { get; set; }

        private GetCustomerFilterOutputSelector[] _outputSelector;
        public GetCustomerFilterOutputSelector[] OutputSelector
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
        public enum GetCustomerFilterOutputSelector
        {
            Username,
            ID,
            Type,
            Password,
            EmailAddress,
            SecondaryEmailAddress,
            NewsletterSubscriber,
            BillingAddress,
            ShippingAddress,
            ParentUsername,
            ApprovalUsername,
            ReferralUsername,
            ReferralCommission,
            Gender,
            DateOfBirth,
            IdentificationType,
            IdentificationDetails,
            DefaultDiscounts,
            DefaultDocumentTemplate,
            RegistrationDate,
            InternalNotes,
            ABN,
            WebsiteURL,
            CreditLimit,
            DefaultInvoiceTerms,
            Classification1,
            Classification2,
            SalesChannel,
            DefaultShippingAddress,
            Active,
            OnCreditHold,
            UserGroup,
            AccountBalance,
            AvailableCredit,
            AccountManager,
            DefaultOrderType,
            UserCustom1,
            UserCustom2,
            UserCustom3,
            UserCustom4,
            UserCustom5,
            UserCustom6,
            UserCustom7,
            UserCustom8,
            UserCustom9,
            UserCustom10,
            UserCustom11,
            UserCustom12,
            UserCustom13,
            UserCustom14,
            UserCustom15,
            UserCustom16,
            UserCustom17,
            UserCustom18,
            UserCustom19,
            UserCustom20,
            UserCustom21,
            UserCustom22,
            UserCustom23,
            UserCustom24,
            UserCustom25,
            UserCustom26,
            UserCustom27,
            UserCustom28,
            UserCustom29,
            UserCustom30,
            UserCustom31,
            UserCustom32,
            UserCustom33,
            UserCustom34,
            UserCustom35,
            UserCustom36,
            UserCustom37,
            UserCustom38,
            UserCustom39,
            UserCustom40,
            UserCustom41,
            UserCustom42,
            UserCustom43,
            UserCustom44,
            UserCustom45,
            UserCustom46,
            UserCustom47,
            UserCustom48,
            UserCustom49,
            UserCustom50,
            DateAdded,
            DateAddedLocal,
            DateAddedUTC,
            DateUpdated,
            DateUpdatedLocal,
            DateUpdatedUTC,
            CustomerLog,
        }

        private GetCustomerFilterOutputSelector[] InitEmptyOutputSelector()
        {
            var outputSelectors = new List<GetCustomerFilterOutputSelector>();

            foreach (GetCustomerFilterOutputSelector item in (GetCustomerFilterOutputSelector[])System.Enum.GetValues(typeof(GetCustomerFilterOutputSelector)))
            {
                outputSelectors.Add(item);
            }

            return outputSelectors.ToArray();
        }

        /// <summary>
        /// Checks for at least one filter in the GetCustomer request. 
        /// See GetCustomer Post https://developers.neto.com.au/documentation/engineers/api-documentation/customers/getcustomer
        /// </summary>
        /// <returns>bool</returns>
        internal override bool isValid()
        {
            if (DateAddedFrom != DateTime.MinValue)
                return true;

            if (DateAddedTo != DateTime.MinValue)
                return true;

            if (DateUpdatedFrom != DateTime.MinValue)
                return true;

            if (DateUpdatedTo != DateTime.MinValue)
                return true;

            int requiredFilterCount = Username.NullSafeLength() +
                            Type.NullSafeLength() +
                            Active.NullSafeLength() +
                            Email.NullSafeLength() +
                            Company.NullSafeLength() +
                            OnCreditHold.NullSafeLength() +
                            NewsletterSubscriber.NullSafeLength() +
                            UserGroup.NullSafeLength() +
                            BillState.NullSafeLength();


            if (requiredFilterCount != 0)
                return true;

            throw new NetoRequestException("At least one filter is required in the GetCustomer request");
        }
    }
}