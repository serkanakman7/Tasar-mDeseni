using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesginPattern.Abstract;
using FactoryDesginPattern.Concrete;

namespace FactoryDesginPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateFactory calculate = new CalculateFactory();
            ICalculater calculater = calculate.CreateCalculation("Topla");
            calculater.Calculate();
            Console.ReadLine();
            
        }
    }
}
