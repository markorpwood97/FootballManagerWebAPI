using FootballManagerClassLibrary.Interfaces;
using FootballManagerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private List<Match> _matches = new List<Match>()
        {
            new Match() { ID = 1, Date = new DateTime(2021, 12, 01), HomeTeamID = 1, AwayTeamID = 2 }
        };

        public void CreateMatch(Match match)
        {
            match.ID = _matches.Count + 1;
            _matches.Add(match);
        }

        public List<Match> GetMatches()
        {
            return _matches;
        }
    }
}
