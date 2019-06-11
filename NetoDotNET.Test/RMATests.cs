using NetoDotNET.Entities;
using NetoDotNET.Exceptions;
using NetoDotNET.Resources.RMA;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET.Test
{
    class RMATests : NetoBaseTests
    {
        #region Filters
        /// <summary>
        /// Tests that <see cref="NetoRequestException"/> is thrown when an invalid <see cref="GetRMAFilter"/> is provided
        /// </summary>
        [Test]
        public void Should_Throw_On_InValid_GetRMAFilter()
        {
            var netoStore = GetStoreManager();
            var filter = new GetRMAFilter();
            Assert.Throws<NetoRequestException>(() => netoStore.RMA.GetRMA(filter));
        }
        #endregion

        #region GetRMA

        /// <summary>
        /// Test retrieval of single RMA using ID
        /// </summary>
        /// <param name = "id" ></ param >
        [Test]
        [TestCase(1)]
        public void Should_Get_Single_RMA_From_ID(int id)
        {
            var netoStore = GetStoreManager();

            var filter = new GetRMAFilter(id);

            var result = netoStore.RMA.GetRMA(filter);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }
        #endregion
    }
}
