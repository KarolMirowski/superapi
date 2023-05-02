using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace superapi.Services
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        Character AddCharacter(Character newCharacter);
    }
}