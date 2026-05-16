using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Board_game.logic
{
    public static class SessionManager
    {
        // Stub: Keep track of the currently logged-in user object
        public static Models.User CurrentUser { get; set; }

        // Stub: Method to clear session on logout
        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
