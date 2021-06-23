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
        //Creaates a list of Clan class
        public List<Clan> clans = new List<Clan>();

        private Clan uzamaki = new Clan { Name = "Uzamaki", IconImage = "https://qph.fs.quoracdn.net/main-qimg-2cd09921c5cc731d5bfd3444909a7bf3", Description = "The Uzumaki Clan is one of the clans who are descendants of Hagoromo Otsutsuki and his son Ashura Otsutsuki and are distant blood relatives of the Senju Clan.", Armor = 10, Health = 10, Energy = 5, Magic = 0, MagicResist = 5, Physical = 10, Special = 6 };
        private Clan uchia = new Clan { Name = "Uchia", IconImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Mangekyou_Sharingan_Sasuke_%28Eternal%29.svg/1024px-Mangekyou_Sharingan_Sasuke_%28Eternal%29.svg.png", Description = "The Uchiha Clan is one of the four noble clans of Konohagakure, reputed to be the village's strongest because of their Sharingan and natural battle prowess.", Armor = 5, Health = 5, Energy = 9, Magic = 8, MagicResist = 6, Physical = 4, Special = 7 };
        private Clan yato = new Clan { Name = "Yato", IconImage = "https://img.pngio.com/dateifullmetal-alchemist-anime-logosvg-wikipedia-anime-logo-png-401_409.png", Description = "The Yato Clan is a clan of enormously powerful humanoid Amanto. Each member possesses superior speed, strength, and endurance, all the necessary elements to completely level any battlefield or enemy.", Armor = 8, Health = 8, Energy = 8, Magic = 1, MagicResist = 1, Physical = 8, Special = 10 };
        private Clan elric = new Clan { Name = "Elric", IconImage = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/6c8a9f9d-17b8-4fc4-89a4-3ddd7a778c5d/d72zl78-ba2f6f98-d7b3-4b27-bbe5-541616f80dc7.png", Description = "The Elric's are a family of very powerful alchemists who also contain the philisopher's stone.", Armor = 1, Health = 1, Energy = 1, Magic = 10, MagicResist = 10, Physical = 1, Special = 10 };
        private Clan hanma = new Clan { Name = "Hanma", IconImage = "https://pbs.twimg.com/media/D7rYI0jWwAEEnax.png", Description = "Hanmas are well known to be ruthless, aggressive and absolutely domineering.", Armor = 10, Health = 10, Energy = 5, Magic = 0, MagicResist = 5, Physical = 10, Special = 5 };

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

            //Return a randomly indexed clan object.
            return clans[listIndex];
        }
    }
}
