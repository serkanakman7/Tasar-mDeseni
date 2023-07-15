using Adapter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Concrete
{
    public class Log4NetAdapter : ILogger
    {
        private Log4Net log4Net = new Log4Net();
        public void Log(string message)
        {
            log4Net.LogMessage(message);
        }
    }
}
