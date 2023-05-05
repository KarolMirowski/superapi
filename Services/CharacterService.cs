using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace superapi.Services
{
    public class CharacterService : ICharacterService
    {
        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }

        IMapper _mapper;

        private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character(){Name = "Sam", Id = 1, HitPoints = 777}
        };
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            characters.Add(_mapper.Map<Character>(newCharacter));
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }


        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            //return await Task.FromResult(characters);
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterDto>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);
            return serviceResponse;
        }

        
        
    }
}