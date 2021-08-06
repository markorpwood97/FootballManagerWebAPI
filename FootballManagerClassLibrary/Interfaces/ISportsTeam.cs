using FootballManagerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Interfaces
{
    public interface ISportsTeam
    {
        List<SportsTeam> GetSportsTeams();
        SportsTeam GetSportsTeam(int id);
        List<Player> GetTeamsPlayers(int id);
    }
}
