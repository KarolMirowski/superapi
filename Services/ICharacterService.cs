using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace superapi.Services
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<Character> AddCharacter(Character newCharacter);
    }
}