using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain
{
   public  class Resume
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid PlayerId { get; set; }
        public Player  Player { get; set; }
    }
}
