using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    public class Juventus : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and White";
        }
    }
}
