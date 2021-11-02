using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp.Models
{
    public class LoginResult
    {
        public string Role { get; set; }
        public string Token { get; set; }

        public string Message { get; set; }
    }
}
