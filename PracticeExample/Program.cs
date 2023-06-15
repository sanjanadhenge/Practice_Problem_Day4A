using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExample
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            DemoExample demo = new DemoExample();
            demo.Sum(5, 9);
        }

    }
}
