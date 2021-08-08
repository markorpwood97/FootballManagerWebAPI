using FootballManagerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Interfaces
{
    public interface IStaduimRepository
    {
        List<Staduim> GetStaduims();
        Staduim GetStaduim(int id);
        void CreateStaduim(Staduim staduim);
        void SetStaduimTeam(int staduimId, int teamId);
    }
}
