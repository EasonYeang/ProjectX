using System.Collections.Generic;
using PX.IRepository.IDAL;
using PX.IService.IBLL;

namespace PX.Service.BLL
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns>数据列表</returns>
        public List<TEntity> GetList()
        {
            return _baseRepository.GetList();
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>实体</returns>
        public TEntity Create(TEntity entity)
        {
            return _baseRepository.Create(entity);
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>实体</returns>
        public TEntity Delete(TEntity entity)
        {
            return _baseRepository.Delete(entity);
        }

        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity">实体</param>
        public void Edit(TEntity entity)
        {
            _baseRepository.Edit(entity);
        }

        /// <summary>
        /// 将操作保存到数据库
        /// </summary>
        /// <returns>成功返回的操作行数</returns>
        public int SaveChanges()
        {
            return _baseRepository.SaveChanges();
        }
    }
}