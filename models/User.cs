using System;
using System.Collections.Generic;
using System.Text;

namespace Board_game.models
{
    public class User
    {
        // Properties
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // e.g., "Admin" or "Staff"

        // Dummy Method: To check if user has admin rights
        public bool IsAdmin()
        {
            // TODO: Logic to return true if Role == "Admin"
            return false;
        }
    }
}