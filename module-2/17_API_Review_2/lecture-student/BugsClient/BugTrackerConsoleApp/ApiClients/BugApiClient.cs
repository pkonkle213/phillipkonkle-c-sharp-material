using System;
using System.Collections.Generic;
using System.Text;
using BugTrackerConsoleApp.Models;
using RestSharp;

namespace BugTrackerConsoleApp.ApiClients
{
    public class BugApiClient
    {
        private readonly RestClient client = new RestClient("https://localhost:44338/");

        // NOTE: BaseAPI and RestClient aren't set for you. You'll need to create them

        public bool CloseBug(int bugId)
        {
            RestRequest request = new RestRequest($"bugs/{bugId}");

            var response = client.Delete<Bug>(request);

            return response.ResponseStatus == ResponseStatus.Completed && response.IsSuccessful;

            /* Get and a Put instead:
            RestRequest request = new RestRequest($"bugs/{bugId}");
            var response = client.Get<Bug>(request);

            Bug bug = response.Data;

            bug.IsOpen = false;

            request = new RestRequest($"bugs/{bugId}");
            request.AddJsonBody(bug);

            response = client.Put<Bug>(request);

            return response.Data != null;
             */
        }

        public List<Bug> GetAllBugs()
        {
            RestRequest request = new RestRequest("bugs");

            var response = client.Get<List<Bug>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not communicate with the server");
                return new List<Bug>();
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Could not get bugs. Error status code " + (int)response.StatusCode);
                return new List<Bug>();
            }

            return response.Data;
        }

        public Bug AddBug(Bug bug)
        {
            RestRequest request = new RestRequest("bugs");
            request.AddJsonBody(bug);

            var response = client.Post<Bug>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not communicate with the server");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Could not add bug. Error status code " + (int)response.StatusCode);
                return null;
            }

            return response.Data;
        }

        // BONUS: Add a method for getting a single bug. You'll need to modify your UserInterface to call this as well.

        // BONUS: Add a method for updating a bug. You'll need to modify your UserInterface to call this as well.
    }
}
