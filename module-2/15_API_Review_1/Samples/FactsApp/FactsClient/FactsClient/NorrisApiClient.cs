using System;
using System.Collections.Generic;
using RestSharp;

namespace FactsClient
{
    public class NorrisApiClient
    {
        private readonly string baseUrl;
        private readonly RestClient client;

        public NorrisApiClient(string baseUrl)
        {
            this.baseUrl = baseUrl;
            this.client = new RestClient();
        }

        public IEnumerable<NorrisApiFact> GetAllFacts()
        {
            RestRequest request = new RestRequest(baseUrl + "facts");

            IRestResponse<List<NorrisApiFact>> response = client.Get<List<NorrisApiFact>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Oh noes! An error occurred: " + response.StatusDescription);
                return null;
            }

            return response.Data;
        }

        public NorrisApiFact GetFact(int id)
        {
            RestRequest request = new RestRequest(baseUrl + "facts/" + id);

            IRestResponse<NorrisApiFact> response = client.Get<NorrisApiFact>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Oh noes! An error occurred: " + response.StatusDescription);
                return null;
            }

            return response.Data;
        }

        public void EditFact(int id, NorrisApiFact fact)
        {
            // Ensure the ID of the fact is set
            fact.Id = id;

            RestRequest request = new RestRequest(baseUrl + "facts");
            request.AddJsonBody(fact);

            IRestResponse response = client.Put(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server");
                return;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Oh noes! An error occurred: " + response.StatusDescription);
                return;
            }

            return;
        }

        public bool DeleteFact(int id)
        {
            RestRequest request = new RestRequest(baseUrl + "facts/" + id);

            IRestResponse response = client.Delete(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server");
                return false;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Oh noes! An error occurred: " + response.StatusDescription);
                return false;
            }

            return true;
        }

        public int AddFact(NorrisApiFact newFact)
        {
            RestRequest request = new RestRequest(baseUrl + "facts");
            request.AddJsonBody(newFact);

            IRestResponse<NorrisApiFact> response = client.Post<NorrisApiFact>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server");
                return -1;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Oh noes! An error occurred: " + response.StatusDescription);
                return -1;
            }

            NorrisApiFact createdFact = response.Data;

            return createdFact.Id;
        }
    }
}