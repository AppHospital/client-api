using AppHospital.Account;
using AppHospital.Api.Accounts;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppHospital.Api.Tests.Controllers
{
    public class GetUserProfileTests : IClassFixture<WebApplicationTestingFactory>
    {
        public WebApplicationTestingFactory _factory;
        public Mock<IAccountStore> _mockAccountStore = new Mock<IAccountStore>();

        public GetUserProfileTests(WebApplicationTestingFactory webApplicationFactory)
        {
            _factory = webApplicationFactory;
        }

        [Fact]
        public async Task ShouldReturnFirstname()
        {
            // Given
            var client = _factory
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureTestServices(services =>
                    {
                        services.AddSingleton(_ => _mockAccountStore.Object);
                    });
                })
                .CreateClient();
            _mockAccountStore.Setup(store => store.Find("toto"))
                .ReturnsAsync(new User("test", "lastname"));

            //When
            var response = await client.GetAsync("/api/user/toto");

            //Then
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync();

            var account = JsonConvert.DeserializeObject<UserAccount>(responseText);
            Assert.Equal("test", account.Firstname);
        }
    }
}
