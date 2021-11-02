using System;
using System.Collections.Generic;
using System.Text;
using BugTrackerConsoleApp.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace BugTrackerConsoleApp.ApiClients
{
    public class BugApiClient
    {
        private readonly RestClient client = new RestClient("https://localhost:44338/");

        public bool IsLoggedIn { get; private set; }

        public bool CloseBug(int bugId)
        {
            RestRequest request = new RestRequest($"bugs/{bugId}");

            var response = client.Delete<Bug>(request);

            return response.ResponseStatus == ResponseStatus.Completed && response.IsSuccessful;
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

        public bool LogIn(string username, string password)
        {
            // Make a REST call to authenticate
            RestRequest request = new RestRequest("login");

            LoginUser user = new LoginUser();
            user.Username = username;
            user.Password = password;
            request.AddJsonBody(user);

            // Do the POST
            IRestResponse<LoginResult> response = client.Post<LoginResult>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not communicate with the server");
                return false;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine(response.Data.Message);
                return false;
            }

            // If the call succeeds, store the authentication token
            LoginResult loginResult = response.Data;
            client.Authenticator = new JwtAuthenticator(loginResult.Token);
            IsLoggedIn = true;

            return true;
        }

        public void LogOut()
        {
            client.Authenticator = null;
            IsLoggedIn = false;
        }
    }
}
