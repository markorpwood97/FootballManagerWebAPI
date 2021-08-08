using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Models
{
    public class Match
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }
        public string Results { get; set; }
    }
}
