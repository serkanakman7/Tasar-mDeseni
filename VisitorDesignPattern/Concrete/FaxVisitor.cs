using System;
using System.Collections.Generic;
using System.Text;
using VisitorDesignPattern.Abstract;

namespace VisitorDesignPattern.Concrete
{
    public class FaxVisitor : IVisitor
    {
        public void Visit(HpPrinter hpPrinter)
        {
            Console.WriteLine($"{nameof(HpPrinter)} 'dan faks gönderildi.");
        }

        public void Visit(LexmarkPrinter lexmarkPrinter)
        {
            Console.WriteLine($"{nameof(LexmarkPrinter)}'dan faks gönderildi.");
        }
    }
}
