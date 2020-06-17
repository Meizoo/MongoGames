using System.Collections.Generic;
using System.Threading.Tasks;

using MongoDBGames.Model;

namespace MongoDBGames.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly IGameContext _context;

        public async Task<IEnumerable<Game>> GetAllGames() => null;
        public IEnumerable<Game> Find   (string name) => null;
        public Task<Game> GetGame(string name) => null;
        public async Task Create(Game game) { }
        public async Task<bool>  Update (Game game)   => false;
        public async Task<bool>  Delete (string name) => false;
    }
}