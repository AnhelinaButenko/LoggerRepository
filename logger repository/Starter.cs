using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Starter
    {
        private const string FilePath = "log.txt";

        private readonly Actions _action;
        private readonly Logger _logger;

        public Starter()
        {
            _action = new Actions();
            _logger = Logger.Instance;
        }

        public void Run()
        {
            var random = new Random();
            var result = new Result();

            for (var i = 0; i < 100; i++)
            {
                switch (random.Next(maxValue: 3))
                {
                    case 0:
                        result = _action.MethodOne();
                        break;
                    case 1:
                        result = _action.MethodTwo();
                        break;
                    case 3:
                        result = _action.MethodThree();
                        break;
                }

                if (!result.Status)
                {
                    _logger.LogError($"Action failed by a reason: {result.ErrorMessage}");
                }
            }

            File.WriteAllText(FilePath, _logger.AllLogs);
        }
    }
}