using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace NetoDotNET.Test
{
    class StoreManagerTests
    {

        [Test]
        [TestCase("", "", "")]
        [TestCase("my-neto-store", "", "")]
        [TestCase(null, "key", "")]
        [TestCase(null, null, null)]
        public void Throws_On_Invalid_Store_Configuration(string storename, string APIKey, string username)
        {
            Assert.Throws<ArgumentNullException>(() => new StoreManager(storename, APIKey, username));
        }
    }
}
