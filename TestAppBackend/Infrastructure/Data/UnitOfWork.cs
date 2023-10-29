using Domain;
using Domain.Infrastructure.DB;
using Domain.Infrastructure.Repositories;

namespace Infrastructure.Data
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext dbContext;

        public UnitOfWork(DatabaseContext context)
        {
            dbContext = context;
        }

        public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new BaseRepository<TEntity>(dbContext);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

    }
}
