using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;
using _5letters.Services;

namespace _5letters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        
        private readonly ILogger<GameController> _logger;

        public static Game NowGame = new Game(new GameDataToStart("123", "носок", "lol"));

        public GameController (ILogger<GameController> logger)
        {
            _logger = logger;
        }
         
        [HttpPost]
        public  IActionResult GameProcess([FromBody]string nowWord) 
        {
            Game result = Game.RunGame(NowGame, nowWord);
            return Ok(result);
        }
        
        
    }
}