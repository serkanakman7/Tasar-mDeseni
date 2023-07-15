using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Concrete
{
    public class CustomerManager
    {
        private CrossCuttingConcernsFacade _concerns;

        public CustomerManager()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }

        public void Save()
        {
            _concerns.Logging.Log();
            _concerns.Caching.cache();
            _concerns.Authorize.Authorize();
            Console.WriteLine("Saved");
        }
    }
}
