using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BoardGameCafeApp.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [Required]
        public int CafeTableId { get; set; }

        [Required, MaxLength(120)]
        public string CustomerName { get; set; } = string.Empty;

        public DateTime StartTime { get; set; } = DateTime.Now;

        public DateTime EndTime { get; set; } = DateTime.Now.AddHours(1);

        [MaxLength(250)]
        public string? Notes { get; set; }

        // Navigation
        public CafeTable? CafeTable { get; set; }
    }
}
