using FootballManagerAPI.Controllers;
using FootballManagerClassLibrary.MemoryDB;
using FootballManagerClassLibrary.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FootballManagerTests
{
    public class Tests
    {
        FootballPlayerController _footballPlayerController;
        FootballTeamController _footballTeamController;
        StaduimController _staduimController;
        MatchesController _matchesController;

        [SetUp]
        public void Setup()
        {
            _footballPlayerController = new FootballPlayerController();
            _footballTeamController = new FootballTeamController();
            _staduimController = new StaduimController();
            _matchesController = new MatchesController();
        }

        [Test]
        public void GetFootballPlayer_ReturnsCorrectPlayer()
        {
            var result = _footballPlayerController.Get(1);
            Assert.IsTrue(result.ID == 1);
        }

        [Test]
        public void GetFootballTeam_ReturnsCorrectTeam()
        {
            var result = _footballTeamController.Get(1);
            Assert.IsTrue(result.ID == 1);
        }

        [Test]
        public void GetStaduim_ReturnsCorrectStaduim()
        {
            var result = _staduimController.Get(1);
            Assert.IsTrue(result.ID == 1);
        }

        [Test]
        public void GetMatch_ReturnsCorrectMatch()
        {
            var result = _matchesController.Get(1);
            Assert.IsTrue(result.ID == 1);
        }

        [Test]
        public void GetFootballPlayer_CorrectNumberOfPlayer()
        {
            var result = _footballPlayerController.Get();
            Assert.IsTrue(result.Count() == InMemoryDB.FootballPlayers.Count);
        }

        [Test]
        public void GetFootballTeam_CorrectNumberOfTeam()
        {
            var result = _footballTeamController.Get();
            Assert.IsTrue(result.Count() == InMemoryDB.FootballTeams.Count);
        }

        [Test]
        public void GetStaduim_CorrectNumberOfStaduim()
        {
            var result = _staduimController.Get();
            Assert.IsTrue(result.Count() == InMemoryDB.Staduims.Count);
        }

        [Test]
        public void GetMatch_CorrectNumberOfMatch()
        {
            var result = _matchesController.Get();
            Assert.IsTrue(result.Count() == InMemoryDB.Matches.Count);
        }


    }
}