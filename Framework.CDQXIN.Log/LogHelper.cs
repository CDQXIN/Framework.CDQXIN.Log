using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.CDQXIN.Log
{
    /// <summary>
    /// Log4net日志
    /// </summary>
    public class LogHelper
    {
        private readonly ILog _log;

        internal LogHelper()
        {
            _log = log4net.LogManager.GetLogger("CDQXIN");
        }

        public LogHelper(string loggerName)
        {
            _log = log4net.LogManager.GetLogger(loggerName);
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="content"></param>
        public void Error(object content)
        {
            try
            {
                _log.Error(content);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="content"></param>
        /// <param name="exception"></param>
        public void Error(object content, Exception exception)
        {
            try
            {
                _log.Error(content, exception);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="format"></param>
        /// <param name="orgs"></param>
        public void ErrorFormat(string format, params object[] orgs)
        {
            try
            {
                if (orgs == null)
                {
                    _log.Error(format);
                }
                else
                {
                    _log.ErrorFormat(format, orgs);
                }
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 普通信息
        /// </summary>
        /// <param name="content"></param>
        public void Info(object content)
        {
            try
            {
                _log.Info(content);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 普通信息
        /// </summary>
        /// <param name="content"></param>
        /// <param name="exception"></param>
        public void Info(object content, Exception exception)
        {
            try
            {
                _log.Info(content, exception);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 普通信息
        /// </summary>
        /// <param name="format"></param>
        /// <param name="orgs"></param>
        public void InfoFormat(string format, params object[] orgs)
        {
            try
            {
                if (orgs == null)
                {
                    _log.Info(format);
                }
                else
                {
                    _log.InfoFormat(format, orgs);
                }
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 警告信息
        /// </summary>
        /// <param name="content"></param>
        public void Warn(object content)
        {
            try
            {
                _log.Warn(content);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 警告信息
        /// </summary>
        /// <param name="content"></param>
        /// <param name="exception"></param>
        public void Warn(object content, Exception exception)
        {
            try
            {
                _log.Warn(content, exception);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 警告信息
        /// </summary>
        /// <param name="format"></param>
        /// <param name="orgs"></param>
        public void WarnFormat(string format, params object[] orgs)
        {
            try
            {
                if (orgs == null)
                {
                    _log.Warn(format);
                }
                else
                {
                    _log.WarnFormat(format, orgs);
                }
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Debug信息
        /// </summary>
        /// <param name="content"></param>
        public void Debug(object content)
        {
            try
            {
                _log.Debug(content);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Debug信息
        /// </summary>
        /// <param name="content"></param>
        /// <param name="exception"></param>
        public void Debug(object content, Exception exception)
        {
            try
            {
                _log.Debug(content, exception);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Debug信息
        /// </summary>
        /// <param name="format"></param>
        /// <param name="orgs"></param>
        public void DebugFormat(string format, params object[] orgs)
        {
            try
            {
                if (orgs == null)
                {
                    _log.Debug(format);
                }
                else
                {
                    _log.DebugFormat(format, orgs);
                }
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 致命异常
        /// </summary>
        /// <param name="content"></param>
        public void Fatal(object content)
        {
            try
            {
                _log.Fatal(content);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 致命异常
        /// </summary>
        /// <param name="content"></param>
        /// <param name="exception"></param>
        public void Fatal(object content, Exception exception)
        {
            try
            {
                _log.Fatal(content, exception);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// 致命异常
        /// </summary>
        /// <param name="format"></param>
        /// <param name="orgs"></param>
        public void FatalFormat(string format, params object[] orgs)
        {
            try
            {
                if (orgs == null)
                {
                    _log.Fatal(format);
                }
                else
                {
                    _log.FatalFormat(format, orgs);
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}
