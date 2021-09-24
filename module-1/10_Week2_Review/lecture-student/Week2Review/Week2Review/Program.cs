using System;

namespace Week2Review
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Add a VotingMachine class, but with documentation this time!
            VotingMachine machine = new VotingMachine();

            // Get the user's voting choice
            bool stillVoting = true;
            while (stillVoting)
            {
                Console.WriteLine("Who do you want to vote for? (Q to exit)");
                string choice = Console.ReadLine();

                if (choice.ToLower() != "q")
                {
                    machine.RegisterVote(choice);
                } 
                else
                {
                    stillVoting = false;
                }
            }

            // Math.Max(42, 3)

            // 2. Allow the user to vote for someone (class variables)
            // 3. Allow multiple people to vote
            // 4. Calculate a winner
            // 5. Safeguard Democracy by checking to see if voting is still open (default values)
            // 6. Incentivize voting by allowing some votes to be worth more than others at random (overloading)
            // 7. What if we wanted candidates to start on the ballot (in the dictionary)?
            // 8. Add a "Voting provided by X" static method, go over System.Math

            Console.WriteLine("The winner is " + machine.Winner);

            Console.WriteLine("Thank you for voting! I love democracy.");
        }
    }
}
