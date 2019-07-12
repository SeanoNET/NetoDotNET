using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class Customer
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public string Type { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public string SecondaryEmailAddress { get; set; }

        public bool NewsletterSubscriber { get; set; }

        public string ParentUsername { get; set; }

        public string ApprovalUsername { get; set; }

        public string ReferralUsername { get; set; }

        public string ReferralCommission { get; set; }

        public string Gender { get; set; }
        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateOfBirth { get; set; }

        public string IdentificationType { get; set; }

        public string IdentificationDetails { get; set; }

        public string DefaultDiscounts { get; set; }

        public string DefaultDocumentTemplate { get; set; }
        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? RegistrationDate { get; set; }

        public string InternalNotes { get; set; }

        public string ABN { get; set; }

        public string WebsiteURL { get; set; }

        public decimal? CreditLimit { get; set; }

        public string DefaultInvoiceTerms { get; set; }

        public string Classification1 { get; set; }

        public string Classification2 { get; set; }

        public string SalesChannel { get; set; }

        public ShippingAddress ShippingAddress { get; set; }

        public BillingAddress BillingAddress { get; set; }

        public bool Active { get; set; }


        public bool OnCreditHold { get; set; }

        public string UserGroup { get; set; }

        public string AccountBalance { get; set; }

        public string AvailableCredit { get; set; }

        public AccountManager AccountManager { get; set; }

        public string DefaultOrderType { get; set; }

        public string UserCustom1 { get; set; }

        public string UserCustom2 { get; set; }

        public string UserCustom3 { get; set; }

        public string UserCustom4 { get; set; }

        public string UserCustom5 { get; set; }

        public string UserCustom6 { get; set; }

        public string UserCustom7 { get; set; }

        public string UserCustom8 { get; set; }

        public string UserCustom9 { get; set; }

        public string UserCustom10 { get; set; }

        public string UserCustom11 { get; set; }

        public string UserCustom12 { get; set; }

        public string UserCustom13 { get; set; }

        public string UserCustom14 { get; set; }

        public string UserCustom15 { get; set; }

        public string UserCustom16 { get; set; }

        public string UserCustom17 { get; set; }

        public string UserCustom18 { get; set; }

        public string UserCustom19 { get; set; }

        public string UserCustom20 { get; set; }

        public string UserCustom21 { get; set; }

        public string UserCustom22 { get; set; }

        public string UserCustom23 { get; set; }

        public string UserCustom24 { get; set; }

        public string UserCustom25 { get; set; }

        public string UserCustom26 { get; set; }

        public string UserCustom27 { get; set; }

        public string UserCustom28 { get; set; }

        public string UserCustom29 { get; set; }

        public string UserCustom30 { get; set; }

        public string UserCustom31 { get; set; }

        public string UserCustom32 { get; set; }

        public string UserCustom33 { get; set; }

        public string UserCustom34 { get; set; }

        public string UserCustom35 { get; set; }

        public string UserCustom36 { get; set; }

        public string UserCustom37 { get; set; }

        public string UserCustom38 { get; set; }

        public string UserCustom39 { get; set; }

        public string UserCustom40 { get; set; }

        public string UserCustom41 { get; set; }

        public string UserCustom42 { get; set; }

        public string UserCustom43 { get; set; }

        public string UserCustom44 { get; set; }

        public string UserCustom45 { get; set; }

        public string UserCustom46 { get; set; }

        public string UserCustom47 { get; set; }

        public string UserCustom48 { get; set; }

        public string UserCustom49 { get; set; }

        public string UserCustom50 { get; set; }
        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateAdded { get; set; }
        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateAddedLocal { get; set; }
        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateAddedUTC { get; set; }
        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdated { get; set; }
        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdatedLocal { get; set; }
        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdatedUTC { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<CustomerLogs>))]
        public List<CustomerLogs> CustomerLogs { get; set; }
    }
}


public class ShippingAddress
{
    public string ShipCompany { get; set; }

    public string ShipFax { get; set; }

    public string ShipStreetLine1 { get; set; }

    public string ShipCity { get; set; }

    public string ShipState { get; set; }

    public string ShipLastName { get; set; }

    public string ShipFirstName { get; set; }

    public string ShipCountry { get; set; }

    public string ShipStreetLine2 { get; set; }

    public string ShipPostCode { get; set; }

    public string ShipPhone { get; set; }
}

public class BillingAddress
{
    public string BillCompany { get; set; }

    public string BillFax { get; set; }

    public string BillStreetLine1 { get; set; }

    public string BillCity { get; set; }

    public string BillState { get; set; }

    public string BillLastName { get; set; }

    public string BillFirstName { get; set; }

    public string BillCountry { get; set; }

    public string BillStreetLine2 { get; set; }

    public string BillPostCode { get; set; }

    public string BillPhone { get; set; }
}

public class AccountManager
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }
}

public class CustomerLogs
{

    public int LogID { get; set; }

    public string Customer { get; set; }

    public string AllocatedTo { get; set; }

    public string Status { get; set; }
    [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
    public DateTime? DateRequiredFollowUp { get; set; }
    [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
    public DateTime? LastContacted { get; set; }
    [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
    public DateTime? LastContactedLocal { get; set; }
    [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
    public DateTime? LastContactedUTC { get; set; }

    public string Notes { get; set; }
}