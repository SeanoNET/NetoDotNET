using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class Suppliers
    {
        public string SupplierID { get; set; }

        public int SupplierReference { get; set; }

        public int LeadTime1 { get; set; }

        public int LeadTime2 { get; set; }

        public string SupplierCompany { get; set; }

        public string SupplierStreet1 { get; set; }

        public string SupplierStreet2 { get; set; }

        public string SupplierCity { get; set; }

        public string SupplierState { get; set; }

        public string SupplierPostcode { get; set; }

        public string SupplierCountry { get; set; }

        public string SupplierPhone { get; set; }

        public string SupplierFax { get; set; }

        public string SupplierURL { get; set; }

        public string SupplierEmail { get; set; }

        public bool NotifyByEmail { get; set; }

        public string ExportTemplate { get; set; }

        public string SupplierCurrencyCode { get; set; }

        public string AccountCode { get; set; }

        public string FactoryStreet1 { get; set; }

        public string FactoryStreet2 { get; set; }

        public string FactoryCity { get; set; }

        public string FactoryState { get; set; }

        public string FactoryPostcode { get; set; }

        public string FactoryCountry { get; set; }

        public string SupplierNotes { get; set; }
    }
}
