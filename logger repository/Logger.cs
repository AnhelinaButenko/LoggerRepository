using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private readonly StringBuilder _logs;

        static Logger()
        {

        }

        private Logger()
        {
            _logs = new StringBuilder();
        }

        public static Logger Instance => _instance;

        public string AllLogs => _logs.ToString();

        public void LogInfo(string message)
        {
            Log(LogType.Info, message);
        }

        public void LogError(string message)
        {
            Log(LogType.Error, message);
        }

        public void LogWarning(string message)
        {
            Log(LogType.Warning, message);
        }

        public void Log(LogType type, string message)
        {
            var log = $"{DateTime.UtcNow} : {type.ToString()}: {message}";
            _logs.AppendLine(log);
            Console.WriteLine(log);
        }
    }
}

