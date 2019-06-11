using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities
{
    public class Content
    {
        public int ContentID { get; set; }

        public string ContentName { get; set; }

        /// <summary>
        /// The type of content you are creating. You can add your own content types under the admin menu.
        /// </summary>
        public string ContentType { get; set; }

        public string ParentContentID { get; set; }

        public bool Active { get; set; }

        public string SortOrder { get; set; }

        public bool OnSiteMap { get; set; }

        public bool OnMenu { get; set; }

        public bool AllowReviews { get; set; }

        public string RequireLogin { get; set; }

        public string ContentReference { get; set; }

        public string ShortDescription1 { get; set; }

        public string ShortDescription2 { get; set; }

        public string ShortDescription3 { get; set; }

        public string Description1 { get; set; }

        public string Description2 { get; set; }

        public string Description3 { get; set; }

        public string Author { get; set; }

        public string ContentURL { get; set; }

        public string Label1 { get; set; }

        public string Label2 { get; set; }

        public string Label3 { get; set; }

        public string SEOMetaDescription { get; set; }

        public string SEOMetaKeywords { get; set; }

        public string SEOPageHeading { get; set; }

        public string SEOPageTitle { get; set; }

        public string SEOCanonicalURL { get; set; }

        public string SearchKeywords { get; set; }

        public string HeaderTemplate { get; set; }

        public string BodyTemplate { get; set; }

        public string FooterTemplate { get; set; }

        public string SearchResultsTemplate { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<RelatedContent>))]
        public List<RelatedContent> RelatedContents { get; set; }

        public string ExternalSource { get; set; }

        public string ExternalReference1 { get; set; }

        public string ExternalReference2 { get; set; }

        public string ExternalReference3 { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePosted { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePostedLocal { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePostedUTC { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdated { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdatedLocal { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdatedUTC { get; set; }

    }

    public class RelatedContent
    {
        public string ContentID { get; set; }
    }
}
