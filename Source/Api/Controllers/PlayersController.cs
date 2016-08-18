using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PoolSkills.Api.Model;
using PoolSkills.Api.Model.Commands;

namespace PoolSkills.Api.Controllers
{
    [Route("api/players")]
    public class PlayersController : Controller
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

        [HttpPost]
        public Guid Post([FromBody] CreatePlayerCommand command)
        {
            return Guid.NewGuid();
        }
    }
}