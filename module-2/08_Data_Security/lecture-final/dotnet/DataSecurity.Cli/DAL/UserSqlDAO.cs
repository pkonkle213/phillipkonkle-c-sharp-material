using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataSecurity.Cli.Model;
using DataSecurity.Cli.Security;

namespace DataSecurity.Cli.DAL
{
    public class UserSqlDAO : IUserDao
    {
        private readonly string _connectionString;
        private readonly IPasswordHasher _passwordHasher;

        /// <summary>
        /// Create a new user dao with the supplied data source and the password hasher
        /// that will salt and hash all the passwords for users.
        /// </summary>
        /// <param name="connectionString">database connection string</param>
        /// <param name="passwordHasher">an object to salt and hash passwords</param>
        public UserSqlDAO(string connectionString, IPasswordHasher passwordHasher)
        {
            _connectionString = connectionString;
            _passwordHasher = passwordHasher;
        }

        public IList<User> GetAllUsers()
        {
            IList<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT id, username FROM users";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Id = (int)reader["id"],
                        Username = (string)reader["username"]
                    };
                    users.Add(user);
                }
            }

            return users;
        }

        public bool IsUsernameAndPasswordValid(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                //command.CommandText = $"SELECT password, salt FROM users WHERE username = '{username}'";
                command.CommandText = "SELECT password, salt FROM users WHERE username = @username";
                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string storedPassword = Convert.ToString(reader["password"]);
                    string storedSalt = Convert.ToString(reader["salt"]);
                    string computedHash = _passwordHasher.ComputeHash(password, Convert.FromBase64String(storedSalt));

                    return computedHash == storedPassword;
                }

                return false;
            }
        }

        public User SaveUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                byte[] salt = _passwordHasher.GenerateRandomSalt();
                string hashedPassword = _passwordHasher.ComputeHash(password, salt);

                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO users (username, password, salt)
                                        VALUES (@username, @password, @salt);
                                        SELECT @@IDENTITY;";

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", hashedPassword);
                command.Parameters.AddWithValue("@salt", Convert.ToBase64String(salt));

                int id = Convert.ToInt32(command.ExecuteScalar());

                return new User
                {
                    Id = id,
                    Username = username
                };
            }
        }
    }
}