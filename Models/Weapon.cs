using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_RPG.Models
{
    public class Weapon
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Damage { get; set; }

        //Um único personagem
        public Character Character { get; set; }

        //Id do personagem
        public int CharacterId { get; set; }
        
    }
}