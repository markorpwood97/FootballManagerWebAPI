using FootballManagerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Interfaces
{
    public interface IFootballTeamRepository
    {
        List<FootballTeam> GetFootballTeams();
        FootballTeam GetFootballTeam(int id);
        void CreateFootballTeam(FootballTeam footballTeam);
        List<FootballPlayer> GetFootballTeamPlayers(int id);
    }
}
