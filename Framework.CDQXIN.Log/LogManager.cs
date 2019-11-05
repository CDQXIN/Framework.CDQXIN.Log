using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.CDQXIN.Log
{
    public class LogManager
    {
        /// <summary>
        /// 默认日记录器
        /// </summary>
        public static readonly LogHelper DefaultLogger;

        static LogManager()
        {
            DefaultLogger = new LogHelper();
        }
    }
}
