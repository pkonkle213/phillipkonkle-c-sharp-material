using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        /// <summary>
        /// Get all auctions unless a search parameter is present
        /// </summary>
        [HttpGet("")]
        public List<Auction> GetAllAuctions(string title_like, double currentBid_lte)
        {
            if (title_like == null && currentBid_lte == 0)
            {
                return dao.List();
            }
            else if (currentBid_lte == 0)
            {
                return dao.SearchByTitle(title_like);
            }
            else if (title_like == null)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            else
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
        }

        /// <summary>
        /// Gets the auction with a specific ID
        /// </summary>
        [HttpGet("{id}")]
        public Auction GetOneAuctionByID(int id)
        {
            return dao.Get(id);
        }

        /// <summary>
        /// Add a new auction
        /// </summary>
        [HttpPost("")]
        public Auction AddANewAuction(Auction auction)
        {
            return dao.Create(auction);
        }
    }
}