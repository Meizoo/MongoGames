using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

using Microsoft.AspNetCore.Mvc;

using MongoDBGames.Model;

namespace MongoDBGames.Controllers
{
    public class GameController : Controller
    {
        public Link[] List() => null;
        public IEnumerable<Game> Search(string name) => null;
        public string Hello() => "Hello world!";
        public string HelloSecure() => "Secured Hello world!";

        public async Task<ActionResult<IEnumerable<Game>>> Get   () => null;
        public async Task<ActionResult<Game>>              Get   (string name) => null;
        public async Task<IActionResult>                   Post  (Game game  ) => null;
        public async Task<IActionResult>                   Put   (string name, Game game) => null;
        public async Task<IActionResult>                   Delete(string name) => null;
    }
}
