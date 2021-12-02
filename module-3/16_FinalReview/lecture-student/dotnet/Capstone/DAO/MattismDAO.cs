using Capstone.Models;
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
