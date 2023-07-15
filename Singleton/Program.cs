using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = CustomerManager.CreateAsSingleton();
            var customerManager2 = CustomerManager.CreateAsSingleton();
     
            Console.WriteLine(customerManager == customerManager2);
            
            Console.ReadLine();
        }
    }
}
