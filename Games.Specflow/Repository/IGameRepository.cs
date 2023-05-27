using Games.Specflow.Models;

namespace Games.Specflow.Repository
{
    public interface IGameRepository
    {
        Task<Game> GetByIdAsync(string id);
        Task<IEnumerable<Game>> GetAsync();
        Task<Game> CreateAsync(Game game);
    }
}
