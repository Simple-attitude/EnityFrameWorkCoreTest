using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset ? StartTime { get; set; }
        public List<GamePlayer> GamePlayers { get; set; } = new List<GamePlayer>();
    }
}
