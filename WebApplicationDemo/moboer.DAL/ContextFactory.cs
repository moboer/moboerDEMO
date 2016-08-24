using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace moboer.DAL
{
    /// <summary>
    /// 上下文简单工厂
    /// <remarks>
    /// 创建;2016年8月23日16:56:48
    /// </remarks>
    /// </summary>
    public class ContextFactory
    {

        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        public static moboerDbContext GetCurrentContext()
        {
            moboerDbContext _mContext = CallContext.GetData("moboerContext") as moboerDbContext;
            if (_mContext == null)
            {
                _mContext = new moboerDbContext();
                CallContext.SetData("moboerContext", _mContext);
            }
            return _mContext;
        }
    }
}
