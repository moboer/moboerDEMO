using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moboer.IBLL
{
    /// <summary>
    /// 接口基类
    /// </summary>
    /// <remarks>
    /// 创建:2016年8月23日17:13:10
    /// </remarks>
    /// <typeparam name="T">实体</typeparam>
   public interface InterfaceBaseService<T> where T:class
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>添加后的数据实体</returns>
        T Add(T entity);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>是否成功</returns>
        bool Update(T entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>是否成功</returns>
        bool Delete(T entity);
    }
}

