using System;
using System.Collections.Generic;

namespace Demo.Domain
{
    public class Player
    {
        public Guid  Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<GamePlayer> GamePlayers { get; set; } = new List<GamePlayer>();
        public Resume  Resume { get; set; }
    }
}