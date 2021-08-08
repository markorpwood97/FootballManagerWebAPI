using FootballManagerClassLibrary.Interfaces;
using FootballManagerClassLibrary.MemoryDB;
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
        private List<FootballPlayer> _footballPlayers = InMemoryDB.FootballPlayers;

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

        public void SetFootballPlayerTeam(int footballPlayerId, int footballTeamId)
        {
            var footballPlayer = _footballPlayers.Where(x => x.ID == footballPlayerId).FirstOrDefault();
            footballPlayer.FootballTeamID = footballTeamId;
        }
    }
}
