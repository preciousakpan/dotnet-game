using dotnet_game.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_game.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character { Name = "Pee" },
            new Character { Name = "Jay", Hitpoints = 150 }
        };

        [HttpGet]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }
    }
}