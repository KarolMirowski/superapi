using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace superapi.Services
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character(){Name = "Sam", Id = 1, HitPoints = 777}
        };
        public async Task<Character> AddCharacter(Character newCharacter)
        {
            return characters[0];
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            //return await Task.FromResult(characters);
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);
            if(character is null) 
                throw new Exception("Character not found");
            else    
                return character;
        }
    }
}