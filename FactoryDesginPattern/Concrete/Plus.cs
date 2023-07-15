using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesginPattern.Abstract;

namespace FactoryDesginPattern.Concrete
{
    public class Plus : ICalculater
    {
        public void Calculate()
        {
            Console.WriteLine("Toplama İşlemi");
        }
    }
}
