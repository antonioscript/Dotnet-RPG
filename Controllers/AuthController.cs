using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dotnet_RPG.Data;
using dotnet_rpg.Dtos.User;

namespace Dotnet_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }


        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User { UserName = request.Username }, request.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}