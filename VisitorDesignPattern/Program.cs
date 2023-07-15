using System;
using VisitorDesignPattern.Abstract;
using VisitorDesignPattern.Concrete;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HpPrinter Hp = new HpPrinter();
            LexmarkPrinter Lexmark = new LexmarkPrinter();
            IVisitor faks = new FaxVisitor();

            Hp.Print();
            Lexmark.Print();

            Hp.Accept(faks);
            Lexmark.Accept(faks);

        }
    }
}
