using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dotnet_RPG.Data;
using Dotnet_RPG.Dtos.Fight;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_RPG.Services.FightService
{
    public class FightService : IFightService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public FightService(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request)
        {
            var response = new ServiceResponse<AttackResultDto>();
            try
            {
                var attacker = await _context.Characters
                    .Include(c => c.Weapon)
                    .FirstOrDefaultAsync(c => c.Id == request.AttackerId);
                var opponent = await _context.Characters
                   .FirstOrDefaultAsync(c => c.Id == request.OpponentId);
                int damage = DoWeaponAttack(attacker, opponent);

                if (opponent.HitPoints <= 0)
                    response.Message = $"{opponent.Name} Foi Derrotado";

                await _context.SaveChangesAsync();

                response.Data = new AttackResultDto
                {
                    Attacker = attacker.Name,
                    Opponent = opponent.Name,
                    AttackerHP = attacker.HitPoints,
                    OpponentHP = opponent.HitPoints,
                    Damage = damage
                };
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}