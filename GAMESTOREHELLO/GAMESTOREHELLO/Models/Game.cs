﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GAMESTOREHELLO.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}