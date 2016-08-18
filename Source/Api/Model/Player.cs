using System;

namespace PoolSkills.Api.Model
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisteredOn { get; set; }
        public double Rating { get; set; }
    }
}