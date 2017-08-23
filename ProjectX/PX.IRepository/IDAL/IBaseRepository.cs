using System.Collections.Generic;

namespace PX.IRepository.IDAL
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns>数据列表</returns>
        List<TEntity> GetList();

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>实体</returns>
        TEntity Create(TEntity entity);

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>实体</returns>
        TEntity Delete(TEntity entity);

        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity">实体</param>
        void Edit(TEntity entity);

        /// <summary>
        /// 将操作保存到数据库
        /// </summary>
        /// <returns>成功返回的操作行数</returns>
        int SaveChanges();
    }
}