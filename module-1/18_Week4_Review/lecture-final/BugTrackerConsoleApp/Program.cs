using System;

namespace BugTrackerConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            ui.ShowMainMenu();
        }
    }
}
