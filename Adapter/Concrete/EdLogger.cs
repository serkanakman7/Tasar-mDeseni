using Adapter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Concrete
{
    public class EdLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged {message}");
        }
    }
}
