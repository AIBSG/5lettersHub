using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace _5letters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        
        private readonly ILogger<GameController> _logger;

        public static Game NowGame = Game.GameCreator("bla", "bla");//берем из бд и апи (не знаю пока как)

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