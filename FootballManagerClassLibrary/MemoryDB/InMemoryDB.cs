using FootballManagerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.MemoryDB
{
    static class InMemoryDB
    {
        public static List<FootballPlayer> FootballPlayers = new List<FootballPlayer>()
        {
            new FootballPlayer() { ID = 1, Name = "Dean", Surname = "Henderson", Height = (decimal)1.88, GamesPlayed = 49, GoalsScored = 0, FootballTeamID = 1 },
            new FootballPlayer() { ID = 2, Name = "Phil", Surname = "Jones", Height = (decimal)1.80, GamesPlayed = 200, GoalsScored = 2, FootballTeamID = 1 },
            new FootballPlayer() { ID = 3, Name = "Aaron", Surname = "Wan-Bissaka", Height = (decimal)1.83, GamesPlayed = 111, GoalsScored = 2, FootballTeamID = 1 },
            new FootballPlayer() { ID = 4, Name = "Thiago", Surname = "Silva", Height = (decimal)1.83, GamesPlayed = 23, GoalsScored = 2, FootballTeamID = 2 },
            new FootballPlayer() { ID = 5, Name = "Davide", Surname = "Zappacosta", Height = (decimal)1.85, GamesPlayed = 26, GoalsScored = 1, FootballTeamID = 2 },
            new FootballPlayer() { ID = 6, Name = "Reece", Surname = "James", Height = (decimal)1.82, GamesPlayed = 56, GoalsScored = 1, FootballTeamID = 2 }
        };

        public static List<FootballTeam> FootballTeams = new List<FootballTeam>()
        {
            new FootballTeam() { ID = 1, Name = "Manchester United", Location = "Manchester, United Kingdom" },
            new FootballTeam() { ID = 2, Name = "Chelsea", Location = "Chelsea, London, United Kingdom" }
        };

        public static List<Staduim> Staduims = new List<Staduim>()
        {
            new Staduim() { ID = 1, Name = "Old Trafford", FootballTeamID = 1 },
            new Staduim() { ID = 2, Name = "Stamford Bridge", FootballTeamID = 2 }
        };

        public static List<Match> Matches = new List<Match>()
        {
            new Match() { ID = 1, Date = new DateTime(2021, 12, 01), HomeTeamID = 1, AwayTeamID = 2 }
        };

    }
}
