using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Actions
    {
        private readonly Logger _logger;

        public Actions()
        {
            _logger = Logger.Instance;
        }

        public Result MethodOne()
        {
            _logger.LogInfo($"Start method: {nameof(MethodOne)}");
            return new Result() { Status = true };
        }

        public Result MethodTwo()
        {
            _logger.LogWarning($"Skipped logic in method:{nameof(MethodTwo)}");
            return new Result() { Status = true };
        }

        public Result MethodThree()
        {
            return new Result() { ErrorMessage = "I broke a logic" };
        }

    }
}
