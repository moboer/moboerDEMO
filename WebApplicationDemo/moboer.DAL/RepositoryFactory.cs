using moboer.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moboer.DAL
{
    /// <summary>
    /// 简单工厂
    /// <remarks>创建:2016年8月23日17:08:22</remarks>
    /// </summary>
   public class RepositoryFactory
    {
        /// <summary>
        /// 用户仓储
        /// </summary>
        public static InterfaceUserRepository UserRepository { get { return new UserRepository(); } }
    }
}
