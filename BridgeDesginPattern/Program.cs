using BridgeDesginPattern.Concrete;
using System;

namespace BridgeDesginPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Abstraction(new ImplamentationA()).Operation());
            Console.ReadLine();
        }
    }
}
