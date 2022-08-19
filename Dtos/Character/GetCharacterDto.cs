using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_RPG.Dtos.Weapon;
using Dotnet_RPG.Dtos.Skill;

namespace Dotnet_RPG.Dtos.Character
{
    public class GetCharacterDto
    {
        //Exatamente igual ao Models/Character.cs
        public int Id { get; set; }

        public string Name { get; set; } = "Frodo";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knight;

        //Arma do personagem
        public GetWeaponDto Weapon { get; set; }

        //Skills daquele personagem
        public List<GetSkillDto> Skills { get; set; }
         
        //Parte da Luta
        public int Fights { get; set; }
        
        public int Victories { get; set; }
        
        public int Defeats { get; set; }

    }
}