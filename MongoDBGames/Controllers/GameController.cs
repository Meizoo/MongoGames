using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MongoDBGames.Helpers;
using MongoDBGames.Model;
using MongoDBGames.Repository;

namespace MongoDBGames.Controllers
{
    [Produces("application/json")]
    [Route("game")]
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpGet("hello")]
        public string Hello() => "Hello world!";

        [BasicAuth]
        [HttpGet("hellosecure")]
        public string HelloSecure() => "Secured Hello world!";

        [HttpGet()]
        [BasicAuth]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _gameRepository.GetAllGames());
        }

        [HttpGet("{name}", Name = "Get")]
        public async Task<IActionResult> Get(string name)
        {
            var game = await _gameRepository.GetGame(name);

            if (game == null)
                return new NotFoundResult();

            return new ObjectResult(game);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Game game)
        {
            await _gameRepository.Create(game);
            return new OkObjectResult(game);
        }

        [HttpPut("{name}")]
        public async Task<IActionResult> Put(string name, [FromBody]Game game)
        {
            var gameFromDb = await _gameRepository.GetGame(name);

            if (gameFromDb == null)
                return new NotFoundResult();

            game.Id = gameFromDb.Id;

            await _gameRepository.Update(game);

            return new OkObjectResult(game);
        }

        [HttpDelete("{name}")]
        public async Task<IActionResult> Delete(string name)
        {
            var gameFromDb = await _gameRepository.GetGame(name);

            if (gameFromDb == null)
                return new NotFoundResult();

            await _gameRepository.Delete(name);

            return new OkResult();
        }
    }
}
