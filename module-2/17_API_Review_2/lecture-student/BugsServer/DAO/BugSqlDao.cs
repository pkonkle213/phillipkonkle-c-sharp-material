using BugsServer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BugsServer.DAO
{
    public class BugSqlDao : IBugDao
    {
        private readonly string connStr;

        public BugSqlDao(string connStr)
        {
            if (string.IsNullOrWhiteSpace(connStr)) throw new ArgumentNullException(nameof(connStr));

            this.connStr = connStr;
        }

        public Bug CreateBug(Bug newBug)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "INSERT INTO Bugs " +
                    "(Summary, Created, IsOpen, ResponsibleDev, Location) " +
                    "VALUES (@summary, @created, @isOpen, @dev, @location); " +
                    "SELECT @@IDENTITY;";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@summary", newBug.Summary);
                    command.Parameters.AddWithValue("@created", DateTime.UtcNow);
                    command.Parameters.AddWithValue("@isOpen", newBug.IsOpen);
                    command.Parameters.AddWithValue("@dev", newBug.ResponsibleDev);
                    command.Parameters.AddWithValue("@location", newBug.Location);

                    newBug.Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return newBug;
        }

        public void DeleteBug(int id)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "DELETE FROM Bugs WHERE id = @id";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void CloseBug(int id)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "UPDATE Bugs SET IsOpen = 0 WHERE id = @id";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public Bug FindById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "SELECT Id, Summary, Created, IsOpen, ResponsibleDev, Location FROM Bugs WHERE Id = @id";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Bug bug = LoadBugFromReader(reader);

                            return bug;
                        }
                    }
                }
            }

            return null;
        }

        public IEnumerable<Bug> GetAllBugs()
        {
            List<Bug> results = new List<Bug>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "SELECT Id, Summary, Created, IsOpen, ResponsibleDev, Location FROM Bugs";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Bug bug = LoadBugFromReader(reader);

                            results.Add(bug);
                        }
                    }
                }
            }

            return results;
        }

        private static Bug LoadBugFromReader(SqlDataReader reader)
        {
            return new Bug
            {
                Id = Convert.ToInt32(reader["Id"]),
                Summary = Convert.ToString(reader["Summary"]),
                Created = Convert.ToDateTime(reader["Created"]),
                IsOpen = Convert.ToBoolean(reader["IsOpen"]),
                ResponsibleDev = Convert.ToString(reader["ResponsibleDev"]),
                Location = Convert.ToString(reader["Location"])
            };
        }

        public Bug UpdateBug(Bug bug)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "UPDATE Bugs SET " +
                    "Summary = @summary, IsOpen = @isOpen, ResponsibleDev = @dev, Location = @location " +
                    "WHERE Id = @id;";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@summary", bug.Summary);
                    command.Parameters.AddWithValue("@isOpen", bug.IsOpen);
                    command.Parameters.AddWithValue("@dev", bug.ResponsibleDev);
                    command.Parameters.AddWithValue("@location", bug.Location);
                    command.Parameters.AddWithValue("@id", bug.Id);

                    command.ExecuteNonQuery();
                }
            }

            return bug;
        }
    }
}
