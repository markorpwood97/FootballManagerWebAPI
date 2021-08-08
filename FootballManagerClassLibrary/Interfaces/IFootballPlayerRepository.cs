using FootballManagerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Interfaces
{
    public interface IFootballPlayerRepository
    {
        List<FootballPlayer> GetFootballPlayers();
        FootballPlayer GetFootballPlayer(int id);
        void CreateFootballPlayer(FootballPlayer footballPlayer);
        void SetFootballPlayerTeam(int footballPlayer, int footballTeam);
    }
}
