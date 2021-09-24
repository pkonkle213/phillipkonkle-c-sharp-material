using System;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a specific bid on an item by a particular bidder.
    /// </summary>
    public class Bid
    {
        /// <summary>
        /// Get the bidder name.
        /// </summary>
        public string Bidder { get; }

        /// <summary>
        /// Get the bid amount.
        /// </summary>
        public int BidAmount { get; }

        /// <summary>
        /// Constructor for Bid object. Each Bid requires a bidder and bidAmount
        /// </summary>
        /// <param name="bidder">Who is bidding</param>
        /// <param name="bidAmount">How much bid is for</param>
        public Bid(string bidder, int bidAmount)
        {
            this.Bidder = bidder;
            this.BidAmount = bidAmount;
        }

        /// <summary>
        /// Displays information on the bidder and the bid amount to the user.
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine(this.Bidder + " with " + this.BidAmount.ToString("C")); // ToString("C") formats as a currency. E.G. $24
        }
    }
}
