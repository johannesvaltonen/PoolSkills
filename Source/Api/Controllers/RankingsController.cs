using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PoolSkills.Api.Model;

namespace PoolSkills.Api.Controllers
{
    [Route("api/rankings")]
    public class RankingsController : Controller
    {
        [HttpGet]
        public IEnumerable<Player> GetCurrentRanking()
        {
            return new []
            { 
                new Player { Id = Guid.NewGuid(), Name = "John Doe" },
                new Player { Id = Guid.NewGuid(), Name = "Jane Doe" }
            };
        }
    }
}