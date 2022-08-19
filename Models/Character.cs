using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_RPG.Models;

namespace Dotnet_RPG.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; } = "Frodo";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knight;

        //Usuário no qual o personagem pertence
        public User? User { get; set; }

        //Arma do Personagem
        public Weapon Weapon { get; set; }

        //Skills do personagem
        public List<Skill> Skills { get; set; }
    }
}