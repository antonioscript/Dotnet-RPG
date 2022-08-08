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
        private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character {Name = "Sam "}
        };
        
        //Pegar todos os personagens
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        //Pegar personagem por Id Específico
        [HttpGet]
        public ActionResult<List<Character>> GetSingle()
        {
            return Ok(characters[0]);
        }
    }
}