using NetoDotNET.Exceptions;
using NetoDotNET.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace NetoDotNET.Resources.Contents
{
    [JsonObject(Title = "GetContentFilter")]
    public class GetContentFilter : NetoGetResourceFilter
    {
        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetContent request. These will determine the results returned.
        /// </summary>
        public GetContentFilter()
        {

        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetContent request. These will determine the results returned.
        /// </summary>
        public GetContentFilter(string[] contentId) : base()
        {
            this.ContentID = contentId;
        }

        /// <summary>
        /// You must specify at least one filter and one OutputSelector in your GetContent request. These will determine the results returned.
        /// </summary>
        public GetContentFilter(string contentId)
            : this(new string[] { contentId })
        {
        }

        public string[] ContentID { get; set; }

        public string[] ParentContentID { get; set; }

        public string[] ContentName { get; set; }

        public bool Active { get; set; }

        public string ContentType { get; set; }

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

        private GetContentFilterOutputSelector[] _outputSelector;
        public GetContentFilterOutputSelector[] OutputSelector
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
        public enum GetContentFilterOutputSelector
        {
            ContentID,
            ID,
            ContentName,
            ContentType,
            ParentContentID,
            Active,
            SortOrder,
            OnSiteMap,
            OnMenu,
            AllowReviews,
            ContentReference,
            ShortDescription1,
            ShortDescription2,
            ShortDescription3,
            Description1,
            Description2,
            Description3,
            Author,
            ContentURL,
            Label1,
            Label2,
            Label3,
            SEOMetaDescription,
            SEOMetaKeywords,
            SEOPageHeading,
            SEOPageTitle,
            SEOCanonicalURL,
            SearchKeywords,
            HeaderTemplate,
            BodyTemplate,
            FooterTemplate,
            SearchResultsTemplate,
            RelatedContents,
            ExternalSource,
            ExternalReference1,
            ExternalReference2,
            ExternalReference3,
            DatePosted,
            DatePostedLocal,
            DatePostedUTC,
            DateUpdated,
            DateUpdatedLocal,
            DateUpdatedUTC,
        }

        private GetContentFilterOutputSelector[] InitEmptyOutputSelector()
        {
            var outputSelectors = new List<GetContentFilterOutputSelector>();

            foreach (GetContentFilterOutputSelector item in (GetContentFilterOutputSelector[])System.Enum.GetValues(typeof(GetContentFilterOutputSelector)))
            {
                outputSelectors.Add(item);
            }

            return outputSelectors.ToArray();
        }

        /// <summary>
        /// Checks for at least one filter in the GetContent request. 
        /// See GetContent Post https://developers.neto.com.au/documentation/engineers/api-documentation/content/getcontent
        /// </summary>
        /// <returns>bool</returns>
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

            int requiredFilterCount = ContentID.NullSafeLength() +
                            ParentContentID.NullSafeLength() +
                            ContentName.NullSafeLength(); 


            if (requiredFilterCount != 0)
                return true;

            throw new NetoRequestException("At least one filter is required in the GetContent request");
        }
    }
}
