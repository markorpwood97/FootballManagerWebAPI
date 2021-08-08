using FootballManagerClassLibrary.Interfaces;
using FootballManagerClassLibrary.Models;
using FootballManagerClassLibrary.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballTeamController : ControllerBase
    {
        IFootballTeamRepository _footballTeamRepository = new FootballTeamRepository();

        // GET: api/<FootballTeamController>
        [HttpGet]
        public IEnumerable<FootballTeam> Get()
        {
            return _footballTeamRepository.GetFootballTeams();
        }

        // GET api/<FootballTeamController>/5
        [HttpGet("{id}")]
        public FootballTeam Get(int id)
        {
            return _footballTeamRepository.GetFootballTeam(id);
        }

        // POST api/<FootballTeamController>
        [HttpPost]
        public void Post(FootballTeam value)
        {
            _footballTeamRepository.CreateFootballTeam(value);
        }

        // GET api/<FootballTeamController>/5
        [HttpGet("{id}/players")]
        public IEnumerable<FootballPlayer> GetTeamPlayers(int id)
        {
            return _footballTeamRepository.GetFootballTeamPlayers(id);
        }
    }
}
