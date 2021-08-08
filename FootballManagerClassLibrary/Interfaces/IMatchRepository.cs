using FootballManagerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Interfaces
{
    public interface IMatchRepository
    {
        List<Match> GetMatches();
        Match GetMatche(int id);
        void CreateMatch(Match match);
    }
}
