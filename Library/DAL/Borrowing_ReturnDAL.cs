using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Borrowing_ReturnDAL
    {
        private ConnectionSqlServer connectionSqlServer;

        public Borrowing_ReturnDAL()
        {
            connectionSqlServer = new ConnectionSqlServer();
        }

        public string GetMaxId()
        {
            string query = "SELECT MAX(BorrowingID) AS MaxMaSo FROM Borrowings";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection()))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
            finally
            {
                connectionSqlServer.CloseConnection();
            }
            return "NoData";
        }
        public DataTable GetMember()
        {
            string query = "SELECT MemberID, FirstName, LastName FROM Members WHERE Role IN (2, 3, 4)";
            return connectionSqlServer.ExecuteQuery(query);
        }

        public DataTable GetBook() {
            string query = "SELECT BookID, Title FROM Books";
            return connectionSqlServer.ExecuteQuery(query);
        }

        public DataTable GetAllBorrowing()
        {
            string query = "SELECT  Borrowings.BorrowingID, Members.FirstName, Members.LastName, Books.Title, BorrowDate, ReturnDate, QuantityBorrowed, BorrowDetails.Status " +
                           "FROM Borrowings " +
                           "INNER JOIN BorrowDetails ON Borrowings.BorrowingID = BorrowDetails.BorrowingID " +
                           "INNER JOIN Books ON BorrowDetails.BookID = Books.BookID " +
                           "INNER JOIN Members ON Members.MemberID = Borrowings.MemberID " +
                           "WHERE BorrowDetails.DeleteBorrow = 1";

            return connectionSqlServer.ExecuteQuery(query);
        }
        public void InsertBorrowing(Brrowing_Return brrowing)
        {
            string queryBorrow = "INSERT INTO Borrowings (BorrowingID, MemberID) " +
                           "VALUES (@BorrowingID, @MemberID)";

            SqlCommand commandBorrow = new SqlCommand(queryBorrow, connectionSqlServer.OpenConnection());

            commandBorrow.Parameters.AddWithValue("@BorrowingID", brrowing.BorrowingID);
            commandBorrow.Parameters.AddWithValue("@MemberID", brrowing.IDMemberBorrowing);

            commandBorrow.ExecuteNonQuery();

            string query = "INSERT INTO BorrowDetails (BookID, BorrowDate, ReturnDate, BorrowingID, QuantityBorrowed, DeleteBorrow) " +
                           "VALUES (@BookID, @BorrowDate, @ReturnDate, @BorrowingID, @QuantityBorrowed, @DeleteBorrow)";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());

            command.Parameters.AddWithValue("@BookID", brrowing.IDBookBorrowingDetails);
            command.Parameters.AddWithValue("@BorrowDate", brrowing.DateBorrowing);
            command.Parameters.AddWithValue("@ReturnDate", brrowing.DateReturnBorrowing);
            command.Parameters.AddWithValue("@BorrowingID", brrowing.BorrowingID);
            command.Parameters.AddWithValue("@QuantityBorrowed", brrowing.quantity);
            command.Parameters.AddWithValue("@DeleteBorrow", brrowing.DeleteBorrowing);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }
        public void delete(string BorrowingID) 
        {
            string query = "UPDATE BorrowDetails SET DeleteBorrow = @DeleteBorrow " +
                   "WHERE BorrowingID = @BorrowingID";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@DeleteBorrow", 0);
            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public void returnBorrow(string value)
        {
            string query = "UPDATE BorrowDetails SET Status = @Status " +
                   "WHERE BorrowingID = @value";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@Status", "paid");
            command.Parameters.AddWithValue("@value", value);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public void reNewBorrow(string key, string value)
        {
            string query = "UPDATE BorrowDetails SET ReturnDate = @ReturnDate " +
                   "WHERE BorrowingID = @key";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@ReturnDate", value);
            command.Parameters.AddWithValue("@key", key);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public DataTable Search(string value)
        {
            string query = $"SELECT Borrowings.BorrowingID, Members.FirstName, Members.LastName, Books.Title, BorrowDate, ReturnDate, QuantityBorrowed, BorrowDetails.Status" +
                $" FROM Borrowings INNER JOIN BorrowDetails ON Borrowings.BorrowingID = BorrowDetails.BorrowingID" +
                $" INNER JOIN Books ON BorrowDetails.BookID = Books.BookID" +
                $" INNER JOIN Members ON Members.MemberID = Borrowings.MemberID" +
                $" WHERE BorrowDetails.DeleteBorrow = 1 AND BorrowDetails.BorrowingID LIKE '%{value}%'";
            return connectionSqlServer.ExecuteQuery(query);
        }

        public DataTable History()
        {
            string query = $"SELECT Borrowings.BorrowingID, Members.FirstName, Members.LastName, Books.Title, BorrowDate, ReturnDate, QuantityBorrowed, BorrowDetails.Status" +
                $" FROM Borrowings INNER JOIN BorrowDetails ON Borrowings.BorrowingID = BorrowDetails.BorrowingID" +
                $" INNER JOIN Books ON BorrowDetails.BookID = Books.BookID" +
                $" INNER JOIN Members ON Members.MemberID = Borrowings.MemberID" +
                $" WHERE BorrowDetails.DeleteBorrow = 0";
            return connectionSqlServer.ExecuteQuery(query);
        }
    }
}
