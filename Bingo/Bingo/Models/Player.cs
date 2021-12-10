using System;
using System.Collections.Generic;
using System.Text;

namespace Bingo.Models
{
    public class Player
    {
        public string playcard_token { get; set; }
        public Card card { get; set; }
    }
}
