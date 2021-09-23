using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Review
{
    /// <summary>
    /// This class is responsible for tracking votes for various candidates.
    /// </summary>
    public class VotingMachine
    {
        public Dictionary<string, int> CandidateVotes { get; set; } // = new Dictionary<string, int>();

        public VotingMachine()
        {
            this.CandidateVotes = new Dictionary<string, int>();
        }

        /// <summary>
        /// Registers a vote for a specific candidate
        /// </summary>
        /// <param name="candidateName">The name of the candidate to vote for</param>
        /// <returns>Whether or not the vote was accepted</returns>
        public bool RegisterVote(string candidateName)
        {
            Console.WriteLine("Registered vote for " + candidateName);

            candidateName = candidateName.ToLower();

            if (this.CandidateVotes.ContainsKey(candidateName))
            {
                // An additional vote for someone
                this.CandidateVotes[candidateName] += 1;
            } 
            else
            {
                // This is the first vote for the candidate
                this.CandidateVotes[candidateName] = 1;
            }

            return true; // We allow the vote
        }

        /// <summary>
        /// Calculates the winner of the election and returns their name.
        /// If nobody voted, the winner will be Nobody.
        /// </summary>
        public string Winner
        {
            get
            {
                string leadingCandidate = "Nobody";
                int largestNumberOfVotes = 0;

                // "A"
                // "B"
                // "C"

                // {Key: Loki,  Value: 5}
                // {Key: Thor,  Value: 3}
                // {Key: Vinny, Value: 1}

                foreach (KeyValuePair<string, int> pair in this.CandidateVotes)
                {
                    string candidate = pair.Key;
                    int votes = pair.Value;

                    if (votes > largestNumberOfVotes)
                    {
                        largestNumberOfVotes = votes;
                        leadingCandidate = candidate;
                    }
                }

                return leadingCandidate;
            }
        }
    }
}
