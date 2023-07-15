using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class SerieAFactory : IFootballFactory
    {
        public IPlayer CreatePlayer()
        {
            return new SerieAPlayer();
        }

        public ITeam CreateTeam()
        {
            return new Juventus();
        }
    }
}
