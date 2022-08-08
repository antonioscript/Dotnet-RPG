using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
        //GET - Pegar todos os personagens
        List<Character> GetAllCharacters();

        //GET - Pegar o personagem por Id específico
        Character GetCharacterById(int id);

        //POST - Adicionar Persongagem
        List<Character> AddCharacter(Character newCharacter);
    }
}