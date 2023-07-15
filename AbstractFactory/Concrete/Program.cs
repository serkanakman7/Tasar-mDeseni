using AbstractFactory.Abstract;
using AbstractFactory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFootballFactory spain = new LaligaFactory();
            FootballWorld footballWorld = new FootballWorld(spain);
            Console.WriteLine(footballWorld.GetFootballPlayer());
            Console.WriteLine(footballWorld.GetFootballTeamColor()); 
            Console.ReadLine();
        }
    }
}
