﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        private const string LaptopId = "01874"; // TODO: Replace with a string for your laptop ID. e.g. "12345"
        private readonly string API_URL = $"https://te-mockauction-server.azurewebsites.net/students/{LaptopId}/auctions";
        private readonly IRestClient client;

        public APIService()
        {
            client = new RestClient();
        }

        public APIService(IRestClient restClient)
        {
            client = restClient;
        }

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

            return null;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest requestOne = new RestRequest(API_URL + "/" + auctionId);
            IRestResponse<Auction> response = client.Get<Auction>(requestOne);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

            return null;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            RestRequest request = new RestRequest(API_URL + "?title_like=" + searchTitle);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

            return null;
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(API_URL + "?currentBid_lte=" + searchPrice);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

            return null;
        }

        public Auction AddAuction(Auction newAuction)
        {
            // place code here
            RestRequest request = new RestRequest(API_URL);
            request.AddJsonBody(newAuction);

            IRestResponse<Auction> response = client.Post<Auction>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

            return new Auction();
        }

        public Auction UpdateAuction(Auction auctionToUpdate)
        {
            // place code here
            RestRequest request = new RestRequest(API_URL + "/" + auctionToUpdate.Id);
            request.AddJsonBody(auctionToUpdate);

            IRestResponse<Auction> response = client.Put<Auction>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

            return new Auction();
        }

        public bool DeleteAuction(int auctionId)
        {
            // place code here
            throw new NotImplementedException();
        }
    }
}
