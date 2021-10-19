using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Transactions;

namespace WorldGeography.Tests.DAL
{
    [TestClass]
    public abstract class WorldDAOTestsBase
    {
        protected string ConnectionString { get; } = "Server=.\\SQLEXPRESS;Database=World;Trusted_Connection=True;";

        /// <summary>
        /// The transaction for each test.
        /// </summary>
        private TransactionScope transaction;

        [TestInitialize]
        public void Setup()
        {
            // Begin the transaction
            transaction = new TransactionScope(); // Equivalent to BEGIN TRANSACTION

            // Get the SQL Script to run
            string sql = File.ReadAllText("test-script.sql");

            // Execute the script
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Roll back the transaction
            if (transaction != null)
            {
                transaction.Dispose(); // Equivalent to ROLLBACK TRANSACTION
            }
        }

        /// <summary>
        /// Gets the row count for a table.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        protected int GetRowCount(string table)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {table}", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
        }
    }
}
