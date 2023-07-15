using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class FootballWorld
    {
        private ITeam _team;
        private IPlayer _player;
        private IFootballFactory _footballFactory;

        public FootballWorld(IFootballFactory footballFactory)
        {
            _footballFactory = footballFactory;
            _team = footballFactory.CreateTeam();
            _player = footballFactory.CreatePlayer();
        }

        public string GetFootballTeamColor()
        {
            return _team.GetTeamColor();
        }

        public string GetFootballPlayer()
        {
            return _player.GetTopScorer();
        }

    }
}
