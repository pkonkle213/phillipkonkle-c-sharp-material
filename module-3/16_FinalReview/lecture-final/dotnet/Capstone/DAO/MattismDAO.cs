﻿using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class MattismDAO : IMattismDAO
    {
        private string connectionString;

        public MattismDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Mattism AddMattism(int userId, Mattism itemToAdd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                const string sql = "INSERT INTO mattisms (text, createdByUserId, isFavorite, frequency) " +
                    "VALUES (@text, @userId, @isFavorite, @frequency); SELECT @@IDENTITY;";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@text", itemToAdd.Text);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@isFavorite", itemToAdd.IsFavorite);
                    command.Parameters.AddWithValue("@frequency", itemToAdd.Frequency);

                    int newRowId = Convert.ToInt32(command.ExecuteScalar());
                    //int newRowId = (int)command.ExecuteScalar();
                    itemToAdd.Id = newRowId;
                }
            }

            return itemToAdd;
        }

        public IEnumerable<Mattism> GetAllMattisms()
        {
            List<Mattism> items = new List<Mattism>();

            const string sql = "SELECT id, text, isFavorite, frequency FROM Mattisms ORDER BY id ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    // Set parameters for my SQL here

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mattism ism = new Mattism();

                            ism.Id = Convert.ToInt32(reader["id"]);
                            ism.Text = Convert.ToString(reader["text"]);
                            ism.IsFavorite = Convert.ToBoolean(reader["isFavorite"]);
                            ism.Frequency = Convert.ToString(reader["frequency"]);

                            items.Add(ism);
                        }
                    }
                }
            }

            return items;
        }
    }
}
