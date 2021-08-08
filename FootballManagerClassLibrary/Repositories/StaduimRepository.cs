using FootballManagerClassLibrary.Interfaces;
using FootballManagerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Repositories
{
    public class StaduimRepository : IStaduimRepository
    {
        private List<Staduim> _staduims = new List<Staduim>()
        {
            new Staduim() { ID = 1, Name = "Old Trafford", FootballTeamID = 1 },
            new Staduim() { ID = 2, Name = "Stamford Bridge", FootballTeamID = 2 }
        };

        public List<Staduim> GetStaduims()
        {
            return _staduims;
        }

        public Staduim GetStaduim(int id)
        {
            return _staduims.Where(x => x.ID == id).FirstOrDefault();
        }

        public void CreateStaduim(Staduim staduim)
        {
            staduim.ID = _staduims.Count + 1;
            _staduims.Add(staduim); ;
        }

        public void SetStaduimTeam(int staduimId, int teamId)
        {
            var staduim = GetStaduim(staduimId);
            staduim.FootballTeamID = teamId;
        }
    }
}
