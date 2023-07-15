using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesginPattern.Abstract;

namespace FactoryDesginPattern.Concrete
{
    public class CalculateFactory
    {
        public ICalculater CreateCalculation(string operation)
        {
            ICalculater calculate = null;
            if (operation == "Topla")
            {
                calculate = new Plus();
            }else if(operation == "Çıkarma")
            {
                calculate = new Minus();
            }else if(operation == "Çarpma")
            {
                calculate = new Multiplication();
            }
            return calculate;
        }
    }
}
