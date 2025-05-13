using Logger.Data;
using Microsoft.Data.SqlClient;
using System.IO;

namespace Logger.Classes
{
	internal abstract class Log
	{
        private  string _fileName;
        private SqlConnection _connection;

        public Log(string fileName)
        {
            _fileName = fileName;
        }

        public Log(SqlConnection connection)
        {
             _connection = connection;
        }

        public virtual void Write(string message)
        {
            LogData.Logs.Add(DateTime.Now, message);

            if (!string.IsNullOrEmpty(_fileName))
            {
                using (StreamWriter sw = new StreamWriter(_fileName, true))
                {
                    sw.WriteLine($"{DateTime.Now}\t {message}");
                }
            }

            if (_connection != null)
            {
                using (_connection)
                {
                    //_connection.Open();

                    //Verder afwerken
                }
            }
        }

        public abstract void DisplayLog();
	}
}
