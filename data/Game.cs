using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Sql
{
    public class Game
    {
        public int GameID { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public int MinPlayers { get; set; }

        public int CurrentStock { get; set; }

        // Navigation Property
        //one Game->>many Rentals
        public ICollection<Rental> Rentals { get; set; }
    }
}
