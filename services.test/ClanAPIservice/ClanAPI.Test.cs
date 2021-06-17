using ClanAPI.Controllers;
using ClanAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace services.test.ClanAPIservice
{
    public class ClanAPI
    {
        [Fact]
        public void GetClanTest()
        {
            ClanController clanController = new ClanController();
            var clanControllerResponse = clanController.Get();

            Assert.NotNull(clanControllerResponse);
            Assert.IsType<Clan>(clanControllerResponse);
        }
    }
}