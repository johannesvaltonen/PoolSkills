using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PoolSkills.Api.Model;
using PoolSkills.Api.Model.Commands;

namespace PoolSkills.Api.Controllers
{
    [Route("api/matches")]
    public class MatchController : Controller
    {
        [HttpGet]
        public IEnumerable<Match> GetMatches()
        {
            return new []
            { 
                new Match { Id = Guid.NewGuid(), PlayedOn = DateTime.Now },
                new Match { Id = Guid.NewGuid(), PlayedOn = DateTime.Now }
            };
        }

        [HttpGet("{id}")]
        public Match Get(Guid id)
        {
            return new Match { Id = Guid.NewGuid(), PlayedOn = DateTime.Now };
        }

        [HttpPost]
        public void Post([FromBody] CreateMatchCommand command)
        {
        }
    }
}
