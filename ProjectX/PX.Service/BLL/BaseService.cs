using System.Collections.Generic;
using PX.IService.IBLL;

namespace PX.Service.BLL
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {


        public List<TEntity> GetList()
        {
            throw new System.NotImplementedException();
        }

        public TEntity Create(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}