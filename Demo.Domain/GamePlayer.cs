using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain
{
    public class GamePlayer
    {
        public Guid GameId { get; set; }
        public Guid PlayerId { get; set; }
        public Game   Game { get; set; }
        public Player  Player { get; set; }
    }
}
