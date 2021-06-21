using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AnimeBattleFrontEnd.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using Microsoft.Extensions.Options;

namespace AnimeBattleFrontEnd.Controllers
{
    //FaceOffApi URL: https://localhost:44355/
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        //private IConfiguration Configuration;
        private AppSettings Configuration;


        public HomeController(ILogger<HomeController> logger, IOptions<AppSettings> settings)
        {
            _logger = logger;
            Configuration = settings.Value;
        }

        public async Task<IActionResult> Index()
        {
            var faceoOffAPI = $"{Configuration.FaceOffAPIURL}/faceoff";
            var faceOffAPIResponse = await new HttpClient().GetStringAsync(faceoOffAPI);
            CreatedCharacter rcCharacter = Newtonsoft.Json.JsonConvert.DeserializeObject<CreatedCharacter>(faceOffAPIResponse);
            
            ViewBag.Name = rcCharacter.Name;
            ViewBag.IconImage1 = rcCharacter.IconImage1;
            ViewBag.IconImage2 = rcCharacter.IconImage2;
            ViewBag.Description = rcCharacter.Description;
            ViewBag.Armor = rcCharacter.Armor;
            ViewBag.Health = rcCharacter.Health;
            ViewBag.Energy = rcCharacter.Energy;
            ViewBag.Magic = rcCharacter.Magic;
            ViewBag.MagicResist = rcCharacter.MagicResist;
            ViewBag.Physical = rcCharacter.Physical;
            ViewBag.Special = rcCharacter.Special;
            ViewBag.PowerLevel = rcCharacter.PowerLevel;
            return View();
        }

    }
}
