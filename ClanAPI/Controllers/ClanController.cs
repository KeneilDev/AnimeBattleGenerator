using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClanAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClanAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClanController : ControllerBase
    {

        public List<Clan> clans = new List<Clan>();

        private Clan uzamaki = new Clan { Id = 1, Name = "Uzamaki", IconImage = "https://qph.fs.quoracdn.net/main-qimg-2cd09921c5cc731d5bfd3444909a7bf3", Description = "The Uzumaki Clan is one of the clans who are descendants of Hagoromo Otsutsuki and his son Ashura Otsutsuki and are distant blood relatives of the Senju Clan.", Armor = 1, Health = 1, Energy = 1, Magic = 1, MagicResist = 1, Physical = 1, Special = 1 };
        private Clan uchia = new Clan { Id = 2, Name = "Uchia", IconImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Mangekyou_Sharingan_Sasuke_%28Eternal%29.svg/1024px-Mangekyou_Sharingan_Sasuke_%28Eternal%29.svg.png", Description = "The Uchiha Clan is one of the four noble clans of Konohagakure, reputed to be the village's strongest because of their Sharingan and natural battle prowess.", Armor = 1, Health = 1, Energy = 1, Magic = 1, MagicResist = 1, Physical = 1, Special = 1 };
        private Clan yato = new Clan { Id = 3, Name = "Yato", IconImage = "https://img.pngio.com/dateifullmetal-alchemist-anime-logosvg-wikipedia-anime-logo-png-401_409.png", Description = "The Yato Clan is a clan of enormously powerful humanoid Amanto. Each member possesses superior speed, strength, and endurance, all the necessary elements to completely level any battlefield or enemy.", Armor = 1, Health = 1, Energy = 1, Magic = 1, MagicResist = 1, Physical = 1, Special = 1 };
        private Clan elric = new Clan { Id = 4, Name = "Elric", IconImage = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/6c8a9f9d-17b8-4fc4-89a4-3ddd7a778c5d/d72zl78-ba2f6f98-d7b3-4b27-bbe5-541616f80dc7.png", Description = "The Elric's are a family of very powerful alchemists who also contain the philisopher's stone.", Armor = 1, Health = 1, Energy = 1, Magic = 1, MagicResist = 1, Physical = 1, Special = 1 };
        private Clan hanma = new Clan { Id = 5, Name = "Hanma", IconImage = "https://pbs.twimg.com/media/D7rYI0jWwAEEnax.png", Description = "Hanmas are well known to be ruthless, aggressive and absolutely domineering.", Armor = 1, Health = 1, Energy = 1, Magic = 1, MagicResist = 1, Physical = 1, Special = 1 };

        [HttpGet]
        public Clan Get()
        {
            clans.Add(uzamaki);
            clans.Add(uchia);
            clans.Add(yato);
            clans.Add(elric);
            clans.Add(hanma);

            var random = new Random();
            int listIndex = random.Next(clans.Count);
            return clans[listIndex];
        }
    }
}
