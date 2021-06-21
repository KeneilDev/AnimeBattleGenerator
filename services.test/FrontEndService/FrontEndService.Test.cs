
using AnimeBattleFrontEnd;
using AnimeBattleFrontEnd.Controllers;
using Microsoft.Extensions.Logging;
using FaceOffAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace services.test.FrontEndService
{
    public class FrontEndService
    {
        private readonly ILogger<HomeController> _logger;

        private AppSettings appSettings = new AppSettings()
        {
            FaceOffAPIURL = "https://localhost:44355",
        };

        [Fact]
        public async void GetClanTestAsync()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);            

            HomeController homeController = new HomeController(_logger, options.Object);

            IActionResult homeControllerResponse = await homeController.Index();

            Assert.NotNull(homeControllerResponse);
            Assert.IsType<ViewResult>(homeControllerResponse);
        }
    }
}
