using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace BoardGameCafeApp.Models;


    public class Game
    {
        public int GameId { get; set; }

        [Required, MaxLength(120)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(60)]
        public string Genre { get; set; } = string.Empty;

        [Range(0, 1000)]
        public int TotalCopies { get; set; }

        [Range(0, 100000)]
        public decimal PricePerHour { get; set; }

        // Navigation
        public List<Rental> Rentals { get; set; } = new();
    }