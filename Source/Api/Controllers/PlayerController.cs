using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PoolSkills.Api.Model;
using PoolSkills.Query;

namespace PoolSkills.Api.Controllers
{
    [Route("api/players")]
    public class PlayerController : Controller
    {
        [HttpGet]
        public IEnumerable<Player> GetPlayers()
        {
            return new []
            { 
                new Player { Id = Guid.NewGuid(), Name = "John Doe" },
                new Player { Id = Guid.NewGuid(), Name = "Jane Doe" }
            };
        }

        [HttpGet("{id}")]
        public Player Get(Guid id)
        {
            return new Player { Id = Guid.NewGuid(), Name = "John Doe" };
        }

        [HttpGet("testvalues")]
        public IEnumerable<string> Get()
        {
            var queryService = new QueryService();
            return queryService.GetValues();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
