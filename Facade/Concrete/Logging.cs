using Facade.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Concrete
{
    public class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }
}
