using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDBGames.Model;

namespace MongoDBGames.Repository
{
    public interface IGameRepository
    {
        Task<IEnumerable<Game>> GetAllGames();
        IEnumerable<Game> Find(string name);
        Task<Game> GetGame(string name);
        Task Create(Game game);
        Task<bool> Update(Game game);
        Task<bool> Delete(string name);
    }
}