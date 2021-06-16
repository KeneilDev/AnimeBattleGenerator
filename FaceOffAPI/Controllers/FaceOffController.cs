﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FaceOffAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FaceOffAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FaceOffController : ControllerBase
    {
        //ClassAPI Url: https://localhost:44359/
        //ClanAPI Url: https://localhost:44345/


        private IConfiguration Configuration;
        public FaceOffController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //Recieves the Class details
            var classAPI = $"{Configuration["ClassAPI"]}/class";
            var classresponse = await new HttpClient().GetStringAsync(classAPI);
            // Uses JsonConvert to parse the json into a class object
            Class rcClass = Newtonsoft.Json.JsonConvert.DeserializeObject<Class>(classresponse);
            
            //Recieves the Clan details
            var clanAPI = $"{Configuration["ClanAPI"]}/clan";
            var clanresponse = await new HttpClient().GetStringAsync(clanAPI);
            // Uses JsonConvert to parse the json into a class object
            Clan rcClan = Newtonsoft.Json.JsonConvert.DeserializeObject<Clan>(clanresponse);

            //Creates a character based on the results of the clan and class...
            CreatedCharacter cCharacter = new CreatedCharacter
            {
              Name = rcClass.Name +" "+ rcClan.Name, 
              IconImage1 = rcClass.IconImage,
              IconImage2 = rcClan.IconImage,
              Description = rcClass.Description +". "+ rcClan.Description, 
              Armor = rcClass.Armor + rcClan.Armor,
              Health = rcClass.Health + rcClan.Health,
              Energy = rcClass.Energy + rcClan.Energy,
              Magic = rcClass.Magic + rcClan.Magic,
              MagicResist = rcClass.MagicResist + rcClan.MagicResist,
              Physical = rcClass.Physical + rcClan.Physical,
              Special = rcClass.Special + rcClan.Special
            };

            //Calculating Power Level
            int powerLevel = (cCharacter.Armor + cCharacter.Health + cCharacter.Energy + cCharacter.Magic + cCharacter.MagicResist + cCharacter.Physical + cCharacter.Special) / 7;
            cCharacter.PowerLevel = powerLevel;

            return Ok(cCharacter);
        }
    }
}
