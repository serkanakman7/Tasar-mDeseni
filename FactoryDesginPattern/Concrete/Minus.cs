using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesginPattern.Abstract;

namespace FactoryDesginPattern.Concrete
{
    public class Minus : ICalculater
    {
        public void Calculate()
        {
            Console.WriteLine("Çıkarma İşlemi");
        }
    }
}
