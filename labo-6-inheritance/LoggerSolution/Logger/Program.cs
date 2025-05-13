using Logger.Classes;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Log baseLog = new Log();
            //baseLog.Write("This is a base log message.");

            ActivityLog activityLog = new ActivityLog("LogFile.txt");
            activityLog.Write("This is an activity log message.");

            ErrorLog errorLog = new ErrorLog(new SqlConnection(""));
            errorLog.Write("This is an error log message.");

            //log.DisplayLog();
            activityLog.DisplayLog();
            //error.DisplayLog();
        }
    }
}
