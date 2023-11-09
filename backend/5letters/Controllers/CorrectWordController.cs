using _5letters.Dtos;
using _5letters.Models;
using _5letters.Services;
using Microsoft.AspNetCore.Mvc;

namespace _5letters.Controllers
{
    [Route("[controller]/[action]")]
    public class CorrectWordController : ControllerBase
    {
        private readonly ICorrectWordService _wordService;

        public CorrectWordController(ICorrectWordService wordService)
        {
            _wordService = wordService;
        }

        [HttpPost]
        public async Task<IActionResult> AddWord([FromBody] CreateCorrectWordRequest word)
        {
            var result = await _wordService.AddCorrectWord(word);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrentWord()
        {
            var word = await _wordService.GetCurrentWord();
            return Ok(word);
        }
    }
}
