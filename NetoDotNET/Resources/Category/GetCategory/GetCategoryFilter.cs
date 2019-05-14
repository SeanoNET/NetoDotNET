using NetoDotNET.Exceptions;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Resources.Categories
{
    [JsonObject(Title = "Filter")]
    public class GetCategoryFilter : NetoGetResourceFilter
    {

        /// <summary>
        /// You must specify at least one Filter and one OutputSelector in your GetCategory request. These will determine the results returned.
        /// </summary>
        public GetCategoryFilter()
        {

        }
        /// <summary>
        /// You must specify at least one Filter and one OutputSelector in your GetCategory request. These will determine the results returned.
        /// </summary>
        public GetCategoryFilter(int[] categoryID) : base()
        {
            this.CategoryID = categoryID;
        }
        /// <summary>
        /// You must specify at least one Filter and one OutputSelector in your GetCategory request. These will determine the results returned.
        /// </summary>
        public GetCategoryFilter(int categoryID) 
            : this(new int[] { categoryID })
        {
        }
        /// <summary>
        /// You must specify at least one Filter and one OutputSelector in your GetCategory request. These will determine the results returned.
        /// </summary>
        public GetCategoryFilter(string[] categoryName) : base()
        {
            this.CategoryName = categoryName;
        }
        /// <summary>
        /// You must specify at least one Filter and one OutputSelector in your GetCategory request. These will determine the results returned.
        /// </summary>
        public GetCategoryFilter(string categoryName)
          : this(new string[] { categoryName })
        {
        }

        public int[] CategoryID { get; set; }

        public int[] ParentCategoryID { get; set; }

        public string[] CategoryName { get; set; }

        public bool Active { get; set; }

        public bool OnSiteMap { get; set; }

        public bool OnMenu { get; set; }

        public bool AllowReviews { get; set; }

        public bool RequireLogin { get; set; }

        public DateTime DatePostedFrom { get; set; }

        public DateTime DatePostedTo { get; set; }

        public DateTime DateUpdatedFrom { get; set; }

        public DateTime DateUpdatedTo { get; set; }

        public int Page { get; set; }

        public int Limit { get; set; }

        private GetCategoryFilterOutputSelector[] _outputSelector;

        public GetCategoryFilterOutputSelector[] OutputSelector
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
        public enum GetCategoryFilterOutputSelector
        {          
            CategoryID,          
            ID,           
            CategoryName,          
            ParentCategoryID,          
            Active,           
            SortOrder,            
            OnSiteMap,            
            OnMenu,            
            AllowReviews,            
            CategoryReference,            
            ShortDescription1,        
            ShortDescription2,         
            ShortDescription3,          
            Description1,            
            Description2,            
            Description3,            
            ExternalSource,         
            ExternalReference1,        
            ExternalReference2,          
            ExternalReference3,           
            DatePosted,         
            DateUpdated,
        }

        private GetCategoryFilterOutputSelector[] InitEmptyOutputSelector()
        {
            var outputSelectors = new List<GetCategoryFilterOutputSelector>();

            foreach (GetCategoryFilterOutputSelector item in (GetCategoryFilterOutputSelector[])System.Enum.GetValues(typeof(GetCategoryFilterOutputSelector)))
            {
                outputSelectors.Add(item);
            }

            return outputSelectors.ToArray();
        }

        /// <summary>
        /// Checks for at least one filter in the GetCategory request.
        /// See GetCategory Post https://developers.neto.com.au/documentation/engineers/api-documentation/categories/getcategory
        /// </summary>
        /// <returns></returns>
        internal override bool isValid()
        {

            if (DatePostedFrom != DateTime.MinValue)
                return true;

            if (DatePostedTo != DateTime.MinValue)
                return true;

            if (DateUpdatedFrom != DateTime.MinValue)
                return true;

            if (DateUpdatedTo != DateTime.MinValue)
                return true;

            int requiredFilterCount = CategoryID.NullSafeLength() +
                            ParentCategoryID.NullSafeLength() +
                            CategoryName.NullSafeLength();

            if (requiredFilterCount != 0)
                return true;

            throw new NetoRequestException("At least one filter is required in the GetCategory request");
        }
    }
}
