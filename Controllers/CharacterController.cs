using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace superapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly ICharacterService _characterService;
    public CharacterController(ICharacterService characterService)
    {
        _characterService = characterService;
    }
    private static Character newCharacter = new Character();


    [HttpGet("GetAll")]
    public async Task<ActionResult<List<Character>>> Get()
    {
        return Ok(await _characterService.GetAllCharacters());
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> GetSingleCharacter(int id)
    {
        return Ok(await _characterService.GetCharacterById(id));
    }
    [HttpPost]
    public async Task<ActionResult<List<Character>>> PostCharactersList(Character newCharacter)
    {
        return Ok(await _characterService.AddCharacter(newCharacter));
    }

}
