using BugsServer.Models;

namespace BugsServer.DAO
{
    public interface IUserDao
    {
        User GetUser(string username);
    }
}