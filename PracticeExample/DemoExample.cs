using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExample
{
    internal class DemoExample
    {
        NLog nlog = new NLog();
        public void Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nlog.LogInfo("Info: Sum()");
                nlog.LogWarn("Warn : a or b is 0");
                nlog.LogError("Error :Either a or b is 0");
            }
            int c = a + b;
            nlog.LogInfo("Info: Sum()");
            nlog.LogDebug("Debug: Sum()" + c);
        }

    }
}
