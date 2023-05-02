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
    public ActionResult<List<Character>> Get()
    {
        return Ok(_characterService.GetAllCharacters());
    }


    [HttpGet("{id}")]
    public ActionResult<Character> GetSingleCharacter(int id)
    {
        return Ok(_characterService.GetCharacterById(id));
    }
    [HttpPost]
    public ActionResult<List<Character>> PostCharactersList(Character newCharacter)
    {
        return Ok(_characterService.AddCharacter(newCharacter));
    }

}
