using System.Collections.Generic;
using System.IO;
using System.Linq;
using BugsServer.Models;

namespace BugsServer.DAO
{
    public class UserDao : IUserDao
    {
        private static readonly List<User> _users = new List<User>();

        public UserDao()
        {
            if (_users.Count == 0)
            {
                _users.AddRange(new User[] 
                {
                    new User()
                    {
                        Id = 1,
                        FirstName = "Test",
                        LastName = "User",
                        Username = "test",
                        PasswordHash = "dlCleO5RZDPTPzqSeIdtsml5XjQ=", // test
                        Salt = "EB8/nsddIKk=",
                        Role = "view"
                    },
                    new User()
                    {
                        Id = 2,
                        FirstName = "Johnny",
                        LastName = "Creator",
                        Username = "johnny",
                        PasswordHash = "NAPA8k9bqwISE2vZu+ILndzI818=", // test
                        Salt = "3uKPKL7XvPc=",
                        Role = "creator"
                    },
                    new User()
                    {
                        Id = 3,
                        FirstName = "Bobby",
                        LastName = "Tables",
                        Username = "admin",
                        PasswordHash = "uRl1apapRCSAzMvKJzIIR6z6L7o=", // admin
                        Salt = "PV09N/b0lz0=",
                        Role = "admin"
                    }
                });
            }
        }

        public User GetUser(string username)
        {
            var user = _users.FirstOrDefault(x => x.Username == username);

            return user;
        }
    }
}
