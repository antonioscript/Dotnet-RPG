using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
        //GET - Pegar todos os personagens
        Task<ServiceResponse<List<Character>>> GetAllCharacters();

        //GET - Pegar o personagem por Id específico
        Task<ServiceResponse<Character>> GetCharacterById(int id);

        //POST - Adicionar Persongagem
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}