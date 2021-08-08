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
    public class FootballTeamRepository : IFootballTeamRepository
    {
        IFootballPlayerRepository _footballPlayerRepository = new FootballPlayerRepository();

        private List<FootballTeam> _footballTeams = InMemoryDB.FootballTeams;

        public List<FootballTeam> GetFootballTeams()
        {
            return _footballTeams;
        }

        public FootballTeam GetFootballTeam(int id)
        {
            return _footballTeams.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<FootballPlayer> GetFootballTeamPlayers(int footballTeamId)
        {
            return _footballPlayerRepository.GetFootballPlayers().Where(x => x.FootballTeamID == footballTeamId).ToList();
        }

        public void CreateFootballTeam(FootballTeam footballTeam)
        {
            footballTeam.ID = _footballTeams.Count + 1;
            _footballTeams.Add(footballTeam);
        }
    }
}
