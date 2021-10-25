using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        // See https://te-mockauction-server.azurewebsites.net/swagger/index.html for API documentation and notes in the readme on relevant methods and working with studentId / id
        // Your requests should go to something like https://te-mockauction-server.azurewebsites.net/students/{YOUR_LAPTOP_ID_HERE}/...

        public List<Auction> GetAllAuctions()
        {
            throw new NotImplementedException();
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            throw new NotImplementedException();
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            throw new NotImplementedException();
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            throw new NotImplementedException();
        }
    }
}
