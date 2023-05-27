using Microsoft.EntityFrameworkCore;

namespace Games.Specflow.Models
{
    public sealed class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}
