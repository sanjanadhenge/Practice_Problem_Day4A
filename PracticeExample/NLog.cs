using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExample
{
    public class NLog
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        public void LogInfo(String message)
        {
            logger.Info(message);
        }
        public void LogWarn(String message)
        {
            logger.Warn(message);
        }
        public void LogDebug(String message)
        {
            logger.Debug(message);
        }
        public void LogError(String message)
        {
            logger.Error(message);
        }
    }
}
