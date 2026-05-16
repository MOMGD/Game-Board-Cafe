using System;
using System.Collections.Generic;
using System.Text;

namespace Board_game.models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int InStock { get; set; }

        // Method stub to check availability
        public bool IsAvailable()
        {
            // TODO: Return true if InStock > 0
            return false;
        }
    }
}
