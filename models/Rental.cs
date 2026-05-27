using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace BoardGameCafeApp.Models
{
    public class Rental
    {
        public int RentalId { get; set; }

        [Required]
        public int GameId { get; set; }

        [Required, MaxLength(120)]
        public string CustomerName { get; set; } = string.Empty;

        public DateTime RentDate { get; set; } = DateTime.Now;

        public DateTime? ReturnDate { get; set; }

        // Navigation
        public Game? Game { get; set; }
    }
}
