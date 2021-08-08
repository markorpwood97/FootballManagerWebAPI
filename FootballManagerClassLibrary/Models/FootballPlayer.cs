using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Models
{
    public class FootballPlayer
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Height { get; set; }
        public int GamesPlayed { get; set; }
        public int PointsScored { get; set; }
        public int FootballTeamID { get; set; }
    }
}
