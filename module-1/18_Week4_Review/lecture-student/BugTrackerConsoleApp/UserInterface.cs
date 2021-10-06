using BugTrackerConsoleApp.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// This class is responsible for all user input and menu code.
    /// </summary>
    public class UserInterface
    {
        private readonly BugManager bugs = new BugManager();

        /// <summary>
        /// Lists main menu options for the user.
        /// </summary>
        public void ShowMainMenu()
        {
            // LOAD BUGS HERE

            bool shouldQuit = false;

            while (!shouldQuit)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to .NET 15 Bugz");
                Console.WriteLine();

                Console.WriteLine("What do you want to do?");
                Console.WriteLine();

                Console.WriteLine("1) Add a Bug");
                Console.WriteLine("2) List Existing Bugs");
                Console.WriteLine("3) Close a Bug");
                Console.WriteLine("4) Quit");
                Console.WriteLine();

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1": // Add a bug
                        AddNewItem();
                        break;

                    case "2": // List existing bugs
                        ListBugs();
                        break;

                    case "3": // Close a bug
                        CloseBug();
                        break;

                    case "4": // Quit
                        shouldQuit = true;
                        Console.WriteLine("That's all folks!");
                        break;

                    default:
                        Console.WriteLine("I'm sorry, that's not a thing");
                        break;
                }
            }
        }

        private void CloseBug()
        {
            Console.WriteLine("What is the bug ID?");
            int bugId = int.Parse(Console.ReadLine());

            bugs.SquashBug(bugId);
        }

        private void ListBugs()
        {
            if (this.bugs.AllBugs.Length <= 0)
            {
                Console.WriteLine("No bugs exist! Ship it!");
            }
            else
            {
                foreach (TrackedItem someBug in this.bugs.AllBugs)
                {
                    Console.WriteLine(someBug.DisplayText);
                }
            }
        }

        private void AddNewItem()
        {
            Console.WriteLine("Please describe the bug");
            string description = Console.ReadLine();

            Console.WriteLine("Is this a bug or a feature? (B/F)");
            string itemType = Console.ReadLine().ToUpper();

            switch (itemType)
            {
                case "B": // bug
                    Console.WriteLine("Where do you suspect this bug occurs?");
                    string location = Console.ReadLine();

                    Bug bug = new Bug(description);
                    bug.Location = location;

                    this.bugs.AddBug(bug);
                    break;

                case "F": // Feature
                    Console.WriteLine("How many hours do you expect this will take?");
                    string estimate = Console.ReadLine();

                    Feature feature = new Feature(description);
                    feature.HoursEstimated = double.Parse(estimate);
                    this.bugs.AddBug(feature);
                    break;

                default: // Some other choice
                    Console.WriteLine("Wrong choice, buddy!");
                    break;
            }

        }
    }
}
