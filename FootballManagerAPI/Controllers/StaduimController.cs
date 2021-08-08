using FootballManagerClassLibrary.Models;
using FootballManagerClassLibrary.Interfaces;
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
    public class StaduimController : ControllerBase
    {
        IStaduimRepository _staduimRepository = new StaduimRepository();

        // GET: api/<StaduimController>
        [HttpGet]
        public IEnumerable<Staduim> Get()
        {
            return _staduimRepository.GetStaduims();
        }

        // GET api/<StaduimController>/5
        [HttpGet("{id}")]
        public Staduim Get(int id)
        {
            return _staduimRepository.GetStaduim(id);
        }

        // POST api/<StaduimController>
        [HttpPost]
        public void Post(Staduim value)
        {
            _staduimRepository.CreateStaduim(value);
        }

        // PUT api/<StaduimController>/5
        [HttpPut("{staduimId}/{teamId}")]
        public void Put(int staduimId, int teamId)
        {
            _staduimRepository.SetStaduimTeam(staduimId, teamId);
        }
    }
}
