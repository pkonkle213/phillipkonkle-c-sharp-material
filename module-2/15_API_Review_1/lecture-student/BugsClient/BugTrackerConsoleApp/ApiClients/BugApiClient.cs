using System;
using System.Collections.Generic;
using System.Text;
using BugTrackerConsoleApp.Models;
using RestSharp;

namespace BugTrackerConsoleApp.ApiClients
{
    public class BugApiClient
    {
        // NOTE: BaseAPI and RestClient aren't set for you. You'll need to create them


        public bool CloseBug(int bugId)
        {
            throw new NotImplementedException();
        }

        public List<Bug> GetAllBugs()
        {
            throw new NotImplementedException();
        }

        public Bug AddBug(Bug bug)
        {
            throw new NotImplementedException();
        }

        // BONUS: Add a method for getting a single bug. You'll need to modify your UserInterface to call this as well.

        // BONUS: Add a method for updating a bug. You'll need to modify your UserInterface to call this as well.
    }
}
