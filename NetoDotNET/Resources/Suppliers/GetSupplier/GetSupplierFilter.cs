using NetoDotNET.Exceptions;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Supplier
{
    [JsonObject(Title = "Filter")]
    public class GetSupplierFilter : NetoGetResourceFilter
    {
        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetSupplier request. These will determine the results returned.
        /// </summary>
        public GetSupplierFilter()
        {

        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetSupplier request. These will determine the results returned.
        /// </summary>
        public GetSupplierFilter(string[] supplierID) : base()
        {
            this.SupplierID = supplierID;
        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetSupplier request. These will determine the results returned.
        /// </summary>
        public GetSupplierFilter(string supplierID)
            : this(new string[] { supplierID })
        {
        }

        public string[] SupplierID { get; set; }

        public string[] LeadTime1 { get; set; }

        public string[] LeadTime2 { get; set; }

        public string[] SupplierCompany { get; set; }

        public string[] SupplierCurrencyCode { get; set; }

        public string[] SupplierCity { get; set; }

        public string[] SupplierState { get; set; }

        public string[] SupplierCountry { get; set; }

        public int Page { get; set; }
        public int Limit { get; set; }

        private GetSupplierFilterOutputSelector[] _outputSelector;

        public GetSupplierFilterOutputSelector[] OutputSelector
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
        public enum GetSupplierFilterOutputSelector
        {
            ID,
            SupplierID,
            SupplierReference,
            LeadTime1,
            LeadTime2,
            SupplierCompany,
            SupplierStreet1,
            SupplierStreet2,
            SupplierCity,
            SupplierState,
            SupplierPostcode,
            SupplierCountry,
            SupplierPhone,
            SupplierFax,
            SupplierURL,
            ExportTemplate,
            SupplierCurrencyCode,
            AccountCode,
            FactoryStreet1,
            FactoryStreet2,
            FactoryCity,
            FactoryState,
            FactoryPostcode,
            FactoryCountry,
            SupplierNotes,
        }

        private GetSupplierFilterOutputSelector[] InitEmptyOutputSelector()
        {
            var outputSelectors = new List<GetSupplierFilterOutputSelector>();

            foreach (GetSupplierFilterOutputSelector item in (GetSupplierFilterOutputSelector[])System.Enum.GetValues(typeof(GetSupplierFilterOutputSelector)))
            {
                outputSelectors.Add(item);
            }

            return outputSelectors.ToArray();
        }



        internal override bool isValid()
        {
            int requiredFilterCount = SupplierID.NullSafeLength() +
                            LeadTime1.NullSafeLength() +
                            LeadTime2.NullSafeLength() +
                            SupplierCompany.NullSafeLength() +
                           SupplierCurrencyCode.NullSafeLength() +
                            SupplierCity.NullSafeLength() +
                            SupplierState.NullSafeLength() +
                            SupplierCountry.NullSafeLength();


            if (requiredFilterCount != 0)
                return true;

            throw new NetoRequestException("At least one filter is required in the GetSupplier request");

        }
    }
}
