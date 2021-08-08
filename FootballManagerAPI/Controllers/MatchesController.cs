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
    public class MatchesController : ControllerBase
    {
        IMatchRepository _matchRepository = new MatchRepository();

        // GET: api/<MatchesController>
        [HttpGet]
        public IEnumerable<Match> Get()
        {
            return _matchRepository.GetMatches();
        }

        // GET api/<MatchesController>/5
        [HttpGet("{id}")]
        public Match Get(int id)
        {
            return _matchRepository.GetMatche(id);
        }

        // POST api/<MatchesController>
        [HttpPost]
        public void Post(Match value)
        {
            _matchRepository.CreateMatch(value);
        }
    }
}
