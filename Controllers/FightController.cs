using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}