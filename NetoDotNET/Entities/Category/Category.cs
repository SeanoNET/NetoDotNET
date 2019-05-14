using NetoDotNET.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Entities.Categories
{
    public class Category
    {
        public string ID { get; set; }

        public string CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string ParentCategoryID { get; set; }

        public bool Active { get; set; }

        public string SortOrder { get; set; }
        public bool OnSiteMap { get; set; }

        public bool OnMenu { get; set; }

        public bool AllowReviews { get; set; }

        public string RequireLogin { get; set; }

        public string CategoryReference { get; set; }

        public string ShortDescription1 { get; set; }

        public string ShortDescription2 { get; set; }

        public string ShortDescription3 { get; set; }

        public string Description1 { get; set; }

        public string Description2 { get; set; }

        public string Description3 { get; set; }

        public string ExternalSource { get; set; }

        public string ExternalReference1 { get; set; }

        public string ExternalReference2 { get; set; }

        public string ExternalReference3 { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DatePosted { get; set; }

        [JsonConverter(typeof(NetoDateNullConverter<DateTime>))]
        public DateTime? DateUpdated { get; set; }

    }
}
