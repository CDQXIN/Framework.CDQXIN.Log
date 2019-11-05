using Framework.CDQXIN.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Framework.CDQXIN.LogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("开始了");
            var filepath = AppDomain.CurrentDomain.BaseDirectory + "log4net.config";
            log4net.Config.XmlConfigurator.Configure(new FileInfo(filepath));
            LogManager.DefaultLogger.ErrorFormat("hahhahah");
            LogManager.DefaultLogger.InfoFormat("hahhahah");
            LogManager.DefaultLogger.Info("1111");
            Console.WriteLine("结束了");
            Console.ReadLine();
        }
    }
}
