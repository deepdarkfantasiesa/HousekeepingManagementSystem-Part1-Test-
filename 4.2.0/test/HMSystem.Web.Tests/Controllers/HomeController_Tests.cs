using System.Threading.Tasks;
using HMSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace HMSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: HMSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
