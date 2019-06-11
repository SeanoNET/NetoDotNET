using NetoDotNET.Entities.Contents;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources.Contents;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class ContentTests : NetoBaseTests
    {


        private Content GetTestAddContent()
        {
            Random random = new Random();
            return new Content
            {

            };
        }


        #region Filters
        /// <summary>
        /// Tests that <see cref="NetoRequestException"/> is thrown when an invalid <see cref="GetContentFilter"/> is provided
        /// </summary>
        [Test]
        public void Should_Throw_On_InValid_GetItemFilter()
        {
            var netoStore = GetStoreManager();
            var filter = new GetContentFilter();
            Assert.Throws<NetoRequestException>(() => netoStore.Content.GetContent(filter));
        }
        #endregion

        #region GetContent
        /// <summary>
        /// Test retrieval of single content resource using an ID
        /// </summary>
        /// <param name = "id" ></ param >
        [Test]
        [TestCase("101")]
        public void Should_Get_Single_Content_From_ID(string id)
        {
            var netoStore = GetStoreManager();

            var filter = new GetContentFilter(id);

            Content[] result = netoStore.Content.GetContent(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Length);
        }


        /// <summary>
        /// Test retrieval of limited content with N limit
        /// </summary>
        /// <param name="limit"></param>
        [Test]
        [TestCase(3)]
        public void Should_Get_N_Limit_Content(int limit)
        {
            var netoStore = GetStoreManager();

            var filter = new GetContentFilter();
            filter.DateUpdatedFrom = DateTime.Now.Add(-TimeSpan.FromDays(100));
            filter.Limit = limit;

            Content[] result = netoStore.Content.GetContent(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(limit, result.Length);
        }

        #endregion

    }
}
