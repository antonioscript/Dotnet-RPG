using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_RPG.Dtos.Fight;
using Dotnet_RPG.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;

        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        [HttpPost("Weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }

    }
}