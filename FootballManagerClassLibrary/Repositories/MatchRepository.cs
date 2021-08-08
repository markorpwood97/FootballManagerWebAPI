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
    public class MatchRepository : IMatchRepository
    {
        private List<Match> _matches = InMemoryDB.Matches;

        public List<Match> GetMatches()
        {
            return _matches;
        }

        public void CreateMatch(Match match)
        {
            match.ID = _matches.Count + 1;
            _matches.Add(match);
        }
    }
}
