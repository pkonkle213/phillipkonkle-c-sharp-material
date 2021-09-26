using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// A description for this class. It's responsible for all user input and menu code
    /// </summary>

    public class UserInterface
    {
        public UserInterface()
        {
            this.BugManager = new BugManager();
        }
        
        public BugManager BugManager { get; private set; }
        
        /// <summary>
        /// Lists main menu options for the user.
        /// </summary>
        public void ShowMainMenu()
        {
            bool shouldQuit = false;
            while (!shouldQuit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to .NET 15 Bugz");
                Console.WriteLine();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1) Add a bug");
                Console.WriteLine("2) List existing bugs");
                Console.WriteLine("3) Close a Bug");
                Console.WriteLine("4) Quit");
                Console.WriteLine();

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddNewBug();
                        break;

                    case "2":
                        ListBugs();
                        break;

                    case "4":
                        shouldQuit = true;
                        Console.WriteLine("C ya!");
                        break;

                    default:
                        Console.WriteLine("Try following instructions, chump");
                        break;
                }
            }
        }

        private void ListBugs()
        {
            if (this.BugManager.AllBugs.Length == 0)
            {
                Console.WriteLine("Congrats, there's no bugs!");
            }
            else
            {
                foreach (Bug someBug in this.BugManager.AllBugs)
                {
                    Console.WriteLine(someBug.DisplayText);
                }
            }
        }

        private void AddNewBug()
        {
            Console.WriteLine("Please describe the bug: ");
            string description = Console.ReadLine();

            Console.WriteLine("Where do you suspect this bug occurs? ");
            string location = Console.ReadLine();

            Bug bug = new Bug();
            bug.Summary = description;
            bug.Location = location;

            BugManager.AddBug(bug);
        }
    }
}
