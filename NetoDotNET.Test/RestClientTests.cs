using NetoDotNET;
using NUnit.Framework;
using System.Net.Http;

namespace Tests
{
    public class RestClientTests
    {
        private RestClient _restClient;

        [SetUp]
        public void Setup()
        {
            _restClient = new RestClient(null, "www.google.com.au");
        }

        [Test]
        public void Should_Return_Status_200_On_Valid_URL()
        {

            var message = new HttpRequestMessage();

            message.RequestUri = new System.Uri("https://www.google.com.au");
            message.Method = HttpMethod.Get;



            var response = _restClient.ExecuteRequestAsync(message).Result;
            System.Console.WriteLine(response.IsSuccessStatusCode);

            Assert.AreEqual(true, response.IsSuccessStatusCode);
        }
    }
}