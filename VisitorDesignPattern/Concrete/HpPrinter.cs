using System;
using System.Collections.Generic;
using System.Text;
using VisitorDesignPattern.Abstract;

namespace VisitorDesignPattern.Concrete
{
    public class HpPrinter : IPrint
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Print()
        {
            Console.WriteLine($"{nameof(HpPrinter)} yazdırıyor");
        }
    }
}
