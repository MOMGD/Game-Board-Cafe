using System;
using System.Collections.Generic;
using System.Text;

namespace Board_game.models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int GameID { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentalDate { get; set; }
        public string Status { get; set; } // 'Active' or 'Returned'
    }
}
