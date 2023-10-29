using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Infrastructure.DB
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}
