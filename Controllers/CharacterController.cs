using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Dotnet_RPG.Models; uso global

namespace Dotnet_RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();
        
        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(knight);
        }
    }
}