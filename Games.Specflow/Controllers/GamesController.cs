using Games.Specflow.Models;
using Games.Specflow.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Games.Specflow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class GamesController : ControllerBase
    {
        private readonly IGameRepository _gameRepository;

        public GamesController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _gameRepository.GetAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Game game)
        {
            return Ok(await _gameRepository.CreateAsync(game));
        }
    }
}
