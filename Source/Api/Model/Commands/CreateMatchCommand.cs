using System;

namespace PoolSkills.Api.Model.Commands
{
    public class CreateMatchCommand
    {
        public Guid WinningPlayerId { get; set; }
        public Guid LosingPlayerId { get; set; }
        public bool IsCleanWin { get; set; }
    }
}