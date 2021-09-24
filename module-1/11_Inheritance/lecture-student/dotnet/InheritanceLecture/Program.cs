using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction();

            generalAuction.PlaceBid(new Bid("Matt", 1));
            generalAuction.PlaceBid(new Bid("John", 13));
            generalAuction.PlaceBid(new Bid("Rick Astley", 23));
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids

            // Create a new Reserve auction (buyer can reject small bids)

            // Create a new Buyout auction (big bids can end the auction)

            Console.ReadLine();
        }
    }
}
