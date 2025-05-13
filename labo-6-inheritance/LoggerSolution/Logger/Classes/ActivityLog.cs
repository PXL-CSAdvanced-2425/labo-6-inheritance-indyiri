using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Data;

namespace Logger.Classes
{
    internal class ActivityLog : Log
    {
        public ActivityLog(string fileName): base(fileName)
        {

        }

        public override void Write(string message)
        {
            base.Write($"ACTIVITY [{message}]");
        }

        public override void DisplayLog()
        {
            foreach (var log in LogData.Logs)
            {
                Console.WriteLine($"{log.Key}: {log.Value}");
            }
        }
    }
}
