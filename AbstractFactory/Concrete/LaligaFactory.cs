using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class LaligaFactory : IFootballFactory
    {
        public IPlayer CreatePlayer()
        {
            return new LaligaPlayer();
        }

        public ITeam CreateTeam()
        {
            return new RealMadrid();
        }
    }
}
