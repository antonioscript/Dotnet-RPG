using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_RPG.Models
{
    public class Skill
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public int Damage { get; set; }

        //Personagens que possui a Skill
        public List<Character> Characters { get; set; }
    }
}