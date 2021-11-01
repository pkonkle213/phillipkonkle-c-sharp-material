using BugsServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsServer.DAO
{
    public interface IBugDao
    {
        Bug CreateBug(Bug newBug);

        Bug FindById(int id);

        IEnumerable<Bug> GetAllBugs();

        Bug UpdateBug(Bug bug);

        void CloseBug(int id);
        void DeleteBug(int id);
    }
}
