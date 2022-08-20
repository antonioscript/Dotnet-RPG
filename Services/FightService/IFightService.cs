using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_RPG.Dtos.Fight;

namespace Dotnet_RPG.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}