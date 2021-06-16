using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClassAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassController : ControllerBase
    {
        public List<Class> classes = new List<Class>();

        private Class senpai = new Class { Id = 1, Name = "Senpai", IconImage = "https://svgsilh.com/svg/34541.svg", Description = "Mentor level of expertise", Armor = 1, Health = 1, Energy = 1, Magic = 1, MagicResist = 1, Physical = 1, Special = 1 };
        private Class shihan = new Class { Id = 2, Name = "Shihan", IconImage = "https://www.shareicon.net/data/512x512/2015/10/08/653138_letter_512x512.png", Description = "Master senior instructor", Armor = 1, Health = 1, Energy = 1, Magic = 1, MagicResist = 1, Physical = 1, Special = 1 };
        private Class renshi = new Class { Id = 3, Name = "Renshi", IconImage = "https://cdn.pixabay.com/photo/2012/04/01/19/22/black-24153_1280.png", Description = "Polished expert in the Arts", Armor = 1, Health = 1, Energy = 1, Magic = 1, MagicResist = 1, Physical = 1, Special = 1 };
        private Class kyoshi = new Class { Id = 4, Name = "Kyoshi", IconImage = "https://img2.pngio.com/download-free-png-15-japanese-letters-png-for-free-download-on-japanese-alphabet-png-2000_1923.png", Description = "The teacher of teachers", Armor = 1, Health = 1, Energy = 1, Magic = 1, MagicResist = 1, Physical = 1, Special = 1 };
        private Class shodaiSoke = new Class { Id = 5, Name = "Shodai-Soke", IconImage = "https://png-4.vector.me/files/images/2/5/253103/frower_preview", Description = "The original founder of the family style", Armor = 1, Health = 1, Energy = 1, Magic = 1, MagicResist = 1, Physical = 1, Special = 1 };

        [HttpGet]
        public Class Get()
        {
            classes.Add(senpai);
            classes.Add(shihan);
            classes.Add(renshi);
            classes.Add(kyoshi);
            classes.Add(shodaiSoke);

            var random = new Random();
            int listIndex = random.Next(classes.Count);
            return classes[listIndex];
        }

    }
}
