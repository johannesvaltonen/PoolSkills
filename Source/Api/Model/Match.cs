using System;

namespace PoolSkills.Api.Model
{
    public class Match
    {
        public Guid Id { get; set; }
        public Player WinningPlayer { get; set; }
        public Player LosingPlayer { get; set; }
        public DateTime PlayedOn { get; set; }
        public bool IsCleanWin { get; set; }
    }
}