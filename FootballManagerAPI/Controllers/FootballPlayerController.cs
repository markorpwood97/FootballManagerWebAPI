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
    public class FootballPlayerController : ControllerBase
    {
        IFootballPlayerRepository _footballPlayerRepository = new FootballPlayerRepository();

        // GET: api/<FootballPlayerController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return _footballPlayerRepository.GetFootballPlayers();
        }

        // GET api/<FootballPlayerController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return _footballPlayerRepository.GetFootballPlayer(id);
        }

        // POST api/<FootballPlayerController>
        [HttpPost]
        public void Post(FootballPlayer value)
        {
            _footballPlayerRepository.CreateFootballPlayer(value);
        }

        // PUT api/<FootballPlayerController>/5
        [HttpPut("{footballPlayerId}/{footballTeamId}")]
        public void Put(int footballPlayerId, int footballTeamId)
        {
            _footballPlayerRepository.SetFootballPlayerTeam(footballPlayerId, footballTeamId);
        }
    }
}
