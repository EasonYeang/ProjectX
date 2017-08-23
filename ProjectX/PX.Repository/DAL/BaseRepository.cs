using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using PX.IRepository.IDAL;
using PX.Utility.DbContext;

namespace PX.Repository.DAL
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbContext = DbContextFactory.GetCurrentDbContext();

        protected DbSet<TEntity> DbSet => _dbContext.Set<TEntity>();

        public List<TEntity> GetList()
        {
            return DbSet.ToList();
        }

        public TEntity Create(TEntity entity)
        {
            return DbSet.Add(entity);
        }

        public TEntity Delete(TEntity entity)
        {
            return DbSet.Remove(entity);
        }

        public void Edit(TEntity entity)
        {
            DbSet.AddOrUpdate(entity);
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}