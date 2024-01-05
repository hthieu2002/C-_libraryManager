using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectionSqlServer
    {
        private SqlConnection connection;
        private SqlTransaction transaction; 

        private string connectionString = config.ConnectionString;

        public ConnectionSqlServer()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                Console.WriteLine("Connected to the database");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to the database: " + ex.Message);
                return null;
            }
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (transaction != null)
            {
                transaction.Commit();
                transaction = null; // Reset transaction after commit
            }
        }

        public void RollbackTransaction()
        {
            if (transaction != null)
            {
                transaction.Rollback();
                transaction = null; // Reset transaction after rollback
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                Console.WriteLine("Disconnected from the database");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error disconnecting from the database: " + ex.Message);
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing query: " + ex.Message);
                    return null;
                }
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    if (transaction != null)
                        command.Transaction = transaction; // Assign transaction to the command

                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing non-query: " + ex.Message);
                    return -1;
                }
            }
        }
    }
}