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
    }
}