using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IAmGroot.IntegrationTests
{
    public class YonduTests
    {
        private HttpClient Client;
        private TestServer Server;

        public YonduTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task YonduEmptyShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/yondu");

            //assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task YonduWithMessageShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/yondu?distance=100.0&time=10.0");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task YonduEmptyReturnCreatedStatus()
        {
            var response = await Client.GetAsync("/yondu");

            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"error\":\"I am Groot!\"}", json);
        }

        [Fact]
        public async Task YonduWithMessageReturnCreatedStatus()
        {
            var response = await Client.GetAsync("/yondu?distance=100.0&time=10.0");

            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"distance\":100.0,\"time\":10.0,\"speed\":10.0}", json);
        }
    }
}
