using FaceOffAPI;
using FaceOffAPI.Controllers;
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

namespace services.test.FaceOffAPIservice
{
    public class FaceOffAPI
    {
        private AppSettings appSettings = new AppSettings()
        {
            ClassAPIURL = "https://localhost:44359",
            ClanAPIURL = "https://localhost:44345"
    };

        [Fact]
        public async void GetClanTestAsync()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            FaceOffController faceOffController = new FaceOffController(options.Object);

            IActionResult faceOffControllerResponse = await faceOffController.Get();

            Assert.NotNull(faceOffControllerResponse);
            Assert.IsType<OkObjectResult>(faceOffControllerResponse);
        }
    }
}
