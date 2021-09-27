using System;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a specific bid on an item by a particular bidder.
    /// </summary>
    public class Bid : Object
    {
        /// <summary>
        /// Constructor for Bid object. Each Bid requires a bidder and bidAmount
        /// </summary>
        /// <param name="bidder">Who is bidding</param>
        /// <param name="bidAmount">How much bid is for</param>
        public Bid(string bidder, int bidAmount) : base()
        {
            this.Bidder = bidder;
            this.BidAmount = bidAmount;
        }

        /// <summary>
        /// Get the bidder name.
        /// </summary>
        public string Bidder { get; } // get; only means that it can only be set in the constructor

        /// <summary>
        /// Get the bid amount.
        /// </summary>
        public int BidAmount { get; }

        /// <summary>
        /// Displays information on the bidder and the bid amount to the user.
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine(this); // Calls .ToString()

            // Console.WriteLine($"{Bidder} with {BidAmount.ToString("C")}");
        }

        public override string ToString()
        {
            return $"{Bidder}: {BidAmount.ToString("C")}";
        }

        public override bool Equals(object obj)
        {
            Bid otherBid = obj as Bid;

            if (otherBid != null)
            {
                return this.Bidder == otherBid.Bidder &&
                    this.BidAmount == otherBid.BidAmount;
            }

            return false;
        }
    }
}
