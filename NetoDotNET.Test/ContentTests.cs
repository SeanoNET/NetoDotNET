using NetoDotNET.Entities;
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
                ContentName = $"NetoDotNET.Test - New Content {random.Next(0, 99999).ToString()}",
                ContentType = "Category",
                Description1 = "New category description"
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

        #region AddContent


        /// <summary>
        /// Test add content page
        /// </summary>
        [Test]
        public void Should_Add_Single_Content()
        {
            var netoStore = GetStoreManager();

            Content[] content = new Content[] {
               GetTestAddContent()
            };

            var result = netoStore.Content.AddContent(content);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Content.Count, 1);
        }

        /// <summary>
        /// Test add multiple content pages
        /// </summary>
        [Test]
        public void Should_Add_Multiple_Content_Pages()
        {
            var netoStore = GetStoreManager();

            Content[] content = new Content[] {
               GetTestAddContent(),
                GetTestAddContent()
            };

            var result = netoStore.Content.AddContent(content);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Content.Count, 2);
        }
        #endregion

        #region UpdateContent


        /// <summary>
        /// Test update an existing content page
        /// </summary>
        /// <param name="contentID"></param>
        [Test]
        [TestCase(105)]
        public void Should_Update_Content_Page(int contentID)
        {
            var netoStore = GetStoreManager();

            var updateContent = new Content[] {
               new Content
               {
                   ContentID = contentID,
                   ContentName = "Clothing Updated"
               }
            };

            var result = netoStore.Content.UpdateContent(updateContent);

            Assert.IsNotNull(result);
            Assert.AreEqual(Ack.Success, result.Ack);
            Assert.AreEqual(result.Content.Count, 1);
        }
        #endregion
    }
}
