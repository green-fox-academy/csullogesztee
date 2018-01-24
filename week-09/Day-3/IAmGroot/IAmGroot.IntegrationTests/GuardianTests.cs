using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IAmGroot.IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task GrootEmptyShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/groot");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GrootWithMessageShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/groot?message=somemessage");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GrootEmptyReturnCreatedStatus()
        {
            var response = await Client.GetAsync("/groot");

            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"error\":\"I am Groot!\"}", json);
        }

        [Fact]
        public async Task GrootWithMessageReturnCreatedStatus()
        {
            var response = await Client.GetAsync("/groot?message=somemessage");

            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"received\":\"somemessage\",\"translated\":\"I am Groot!\"}", json);
        }
    }
}
