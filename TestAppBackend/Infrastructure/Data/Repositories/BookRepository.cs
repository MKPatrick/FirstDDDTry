using Domain.Entities;
using Domain.Infrastructure.DB;
using Domain.Infrastructure.Repositories;

namespace Infrastructure.Data.Repositories
{
    public class BookRepository : BaseRepository<Book>
    {
        public BookRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
