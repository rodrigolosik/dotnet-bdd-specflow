using Games.Specflow.Models;
using Microsoft.EntityFrameworkCore;

namespace Games.Specflow.Repository
{
    public sealed class GameRepository : IGameRepository
    {
        private readonly ApiContext _context;

        public GameRepository(ApiContext context)
        {
            _context = context;
        }

        public async Task<Game> CreateAsync(Game game)
        {
            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();
            return game;
        }

        public async Task<IEnumerable<Game>> GetAsync()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task<Game> GetByIdAsync(string id)
        {
           return await _context.Games.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
