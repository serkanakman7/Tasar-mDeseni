using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    public class RealMadrid : ITeam
    {
        public string GetTeamColor()
        {
            return "Blue and White";
        }
    }
}
