using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolkadotRPC.Models;

namespace PolkadotRPC.Tests
{
    [TestClass]
    public class MethodTests
    {
        private readonly IPolkadotRPC _client;

        public MethodTests()
        {
            _client = PolkadotClient.GetClient(Configuration.BaseUrl);
        }


        [TestMethod]
        public async Task GetMethods()
        {
            var result = await _client.Methods(new MethodsRequest());

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Result);
            Assert.IsTrue(result.Result.Methods.Any());
        }

    }
}