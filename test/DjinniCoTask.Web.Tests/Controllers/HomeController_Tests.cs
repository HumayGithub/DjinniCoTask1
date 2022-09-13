using System.Threading.Tasks;
using DjinniCoTask.Web.Controllers;
using Shouldly;
using Xunit;

namespace DjinniCoTask.Web.Tests.Controllers
{
    public class HomeController_Tests: DjinniCoTaskWebTestBase
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
