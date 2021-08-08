using FootballManagerClassLibrary.Interfaces;
using FootballManagerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Repositories
{
    public class FootballPlayerRepository : IFootballPlayerRepository
    {
        private List<FootballPlayer> _footballPlayers = new List<FootballPlayer>()
        {
            new FootballPlayer() { ID = 1, Name = "", Surname = "", Height = (decimal)1.84, GamesPlayed = 0, PointsScored = 0, FootballTeamID = 1 }
        };

        public List<FootballPlayer> GetFootballPlayers()
        {
            return _footballPlayers;
        }

        public FootballPlayer GetFootballPlayer(int id)
        {
            return _footballPlayers.Where(x => x.ID == id).FirstOrDefault();
        }

        public void CreateFootballPlayer(FootballPlayer footballPlayer)
        {
            footballPlayer.ID = _footballPlayers.Count + 1;
            _footballPlayers.Add(footballPlayer);
        }
    }
}
