using BuiderDesignPattern.Abstract;
using BuiderDesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ArabaBuilder araba = new OpelConcreteBuilder();
            ArabaUret uret = new ArabaUret();
            uret.Uret(araba);
            Console.WriteLine(araba.Araba.ToString());
        }
    }
}
