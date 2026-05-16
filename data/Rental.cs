using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Sql
{
    public class Rental
    {
        public int RentalID { get; set; }

        // Foreign Key
        public int GameID { get; set; }

        public string CustomerName { get; set; }

        public DateTime RentalDate { get; set; }

        public string Status { get; set; }

        // Navigation Property
        public Game Game { get; set; }
    }
}
