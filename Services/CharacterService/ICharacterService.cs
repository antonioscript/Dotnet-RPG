using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_RPG.Dtos.Character;

namespace Dotnet_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
        //GET - Pegar todos os personagens
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        //GET - Pegar o personagem por Id específico
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        //POST - Adicionar Persongagem
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

        //PUT - Atualizar o Personagem
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);

        //Delete - Apagar Personagem
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

        //Adicionar Skills
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}