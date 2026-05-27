using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BoardGameCafeApp.Models
{
    public class CafeTable
    {
        public int CafeTableId { get; set; }

        [Required, MaxLength(30)]
        public string TableName { get; set; } = string.Empty;

        [Range(1, 50)]
        public int Capacity { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation
        public List<Booking> Bookings { get; set; } = new();
    }
}
