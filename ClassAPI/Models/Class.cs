using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAPI.Models
{
    [ExcludeFromCodeCoverage]
    public class Class
    {
        public string IconImage { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Physical { get; set; }
        public int Energy { get; set; }
        public int Magic { get; set; }
        public int Armor { get; set; }
        public int MagicResist { get; set; }
        public int Special { get; set; }
        public string Description { get; set; }
    }
}
