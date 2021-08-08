using FootballManagerClassLibrary.Interfaces;
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

        private List<FootballTeam> _footballTeams = new List<FootballTeam>()
        {
            new FootballTeam() { ID = 1, Name = "Manchester United", Location = "Manchester, United Kingdom" },
            new FootballTeam() { ID = 2, Name = "Chelsea", Location = "Chelsea, London, United Kingdom" }
        };

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
