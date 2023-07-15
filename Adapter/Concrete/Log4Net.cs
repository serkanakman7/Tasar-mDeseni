using Adapter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Concrete
{
    public class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Logged with Log4Net {message}");
        }
    }
}
