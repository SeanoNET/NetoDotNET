using NetoDotNET;
using NUnit.Framework;
using System;
using System.Net.Http;

namespace Tests
{
    public class RestClientTests
    {
        private RestClient _restClient;

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        [TestCase(null, null, "")]
        [TestCase(null, "key", "")]
        [TestCase(null, "", "user")]
        public void ThrowsOnBadInitWithNoAPIKeyAndOrUsername(Uri url, string APIKey, string username)
        {
            Assert.Throws<ArgumentException>(()=>new RestClient(null, url, APIKey, username));
    
        }
    }
}