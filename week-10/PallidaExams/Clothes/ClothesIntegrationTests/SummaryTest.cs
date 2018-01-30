using ClothesMarket;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ClothesIntegrationTests
{
    public class SummaryTest
    {
        private HttpClient Client;
        private TestServer Server;

        public SummaryTest()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task WarehouseOk()
        {
            var response = await Client.GetAsync("warehouse/query");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}