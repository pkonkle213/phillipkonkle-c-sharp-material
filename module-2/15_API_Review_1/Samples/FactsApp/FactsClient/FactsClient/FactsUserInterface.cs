using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactsClient
{
    public class FactsUserInterface
    {
        private readonly NorrisApiClient apiClient = new NorrisApiClient("https://localhost:44335/"); // TODO: Customize as needed

        public void RunUserInterface()
        {
            Console.WriteLine("Welcome to the Chuck Norris Fact Database");

            bool keepGoing = true;
            do
            {
                string option = GetMainMenuChoice();

                switch (option.ToUpper())
                {
                    case "1": // Get a list of facts
                        FetchAndDisplayAllFacts();
                        break;

                    case "2": // Get a fact by its ID
                        FetchFactAndDisplayOptions();
                        break;

                    case "3": // Add a new fact
                        CreateFact();
                        break;

                    case "Q":
                        keepGoing = false;
                        break;

                    default:
                        Console.WriteLine("I have no idea what you're talking about");
                        break;
                }
            } while (keepGoing);

            Console.WriteLine("So long and enjoy a world without Chuck Norris facts.");
        }

        private void FetchFactAndDisplayOptions()
        {
            Console.WriteLine("Please enter the ID of the fact you want to fetch");
            string idInput = Console.ReadLine();
            Console.WriteLine();

            bool isValidNumber = int.TryParse(idInput, out int id);
            if (!isValidNumber)
            {
                Console.WriteLine("That's not even a number. Come on.");
                return;
            }

            NorrisApiFact fact = apiClient.GetFact(id);
            if (fact == null)
            {
                Console.WriteLine("A fact with that ID could not be found");
                return;
            }

            DisplayFactDetailsMenu(id, fact);
        }

        private void DisplayFactDetailsMenu(int id, NorrisApiFact fact)
        {
            Console.WriteLine("Chuck Norris Fact:" + fact); // TODO: Customize this display as needed

            string menuInput = GetFactDetailMenuChoice();

            switch (menuInput.ToUpper())
            {
                case "D": // DELETE
                    DeleteFact(id);
                    break;

                case "E": // EDIT
                    EditFact(id);
                    break;

                case "R":
                    Console.WriteLine("I'm glad you didn't delete anything!");
                    break;

                default:
                    Console.WriteLine(
                        "I have no idea what you're talking about. Let's go back to the main menu before you hurt someone.");
                    break;
            }
        }

        private void CreateFact()
        {
            NorrisApiFact newFact = GetFactValuesFromUser();

            int factId = apiClient.AddFact(newFact);

            if (factId > 0)
            {
                Console.WriteLine("A glorious day! The new fact has been created! Its ID is " + factId);
            }
            else
            {
                Console.WriteLine("Could not create the new Chuck Norris Fact.");
            }
        }

        private void EditFact(int id)
        {
            NorrisApiFact newFact = GetFactValuesFromUser();
            apiClient.EditFact(id, newFact);
        }

        private NorrisApiFact GetFactValuesFromUser()
        {
            NorrisApiFact newFact = new NorrisApiFact();

            // TODO: Prompt the user for information about the fact, then set them into newFact
            Console.WriteLine("What is the Chuck Norris fact?");
            string text = Console.ReadLine();

            newFact.Text = text;

            return newFact;
        }

        private void DeleteFact(int id)
        {
            if (apiClient.DeleteFact(id))
            {
                Console.WriteLine("Fact deleted. You monster.");
            }
            else
            {
                Console.WriteLine("The fact could not be deleted. Trust me; this is a good thing.");
            }
        }

        private string GetFactDetailMenuChoice()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("\tD) Delete this *FACT* (why???)");
            Console.WriteLine("\tE) Edit this *FACT* (why???)");
            Console.WriteLine("\tR) Return to the main menu");
            Console.WriteLine();

            string menuInput = Console.ReadLine();
            Console.WriteLine();

            return menuInput;
        }

        private void FetchAndDisplayAllFacts()
        {
            // TODO: Get a list of facts from the client
            IEnumerable<NorrisApiFact> facts = apiClient.GetAllFacts();

            if (facts == null || !facts.Any())
            {
                Console.WriteLine("No facts were returned. Perhaps Chuck Norris facts don't really exist?");
            }
            else
            {
                foreach (NorrisApiFact fact in facts)
                {
                    Console.WriteLine(fact); // TODO: This should be modified or you should override ToString on NorrisApiFact
                    // NOTE: Strongly recommended to display the ID of the fact here as well
                }
            }
        }

        private static string GetMainMenuChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Your Options are:");
            Console.WriteLine();
            Console.WriteLine("\t1) Get a List of Chuck Norris *FACTS*");
            Console.WriteLine("\t2) Get a Chuck Norris *FACT* by its ID");
            Console.WriteLine("\t3) Add a new Chuck Norris *FACT*");
            Console.WriteLine("\tQ) Leave the glory of Chuck Norris and exit this program");
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");

            string option = Console.ReadLine();
            Console.WriteLine();

            return option;
        }
    }
}
