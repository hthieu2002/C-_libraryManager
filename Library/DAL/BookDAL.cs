using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookDAL
    {
        private ConnectionSqlServer connectionSqlServer;
        public BookDAL()
        {
            connectionSqlServer = new ConnectionSqlServer();
        }

        public DataTable GetAllBooks()
        {
            string query = "SELECT * FROM Books";
            return connectionSqlServer.ExecuteQuery(query);
        }

        public void InsertBook(Book book)
        {
            string query = "INSERT INTO Books (Title, Author, PublicationYear, Quantity, Genre) " +
               "VALUES (@Title, @Author, @PublicationYear, @Quantity, @Genre)";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@Title", book.Title);
            command.Parameters.AddWithValue("@Author", book.Author);
            command.Parameters.AddWithValue("@PublicationYear", book.PublicationYear);
            command.Parameters.AddWithValue("@Quantity", book.Quantity);
            command.Parameters.AddWithValue("@Genre", book.Genre);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public void UpdateBook(Book book)
        {
            string query = "UPDATE Books SET Title = @Title, Author = @Author, " +
                   "PublicationYear = @PublicationYear, Quantity = @Quantity, Genre = @Genre " +
                   "WHERE BookID = @BookID";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@Title", book.Title);
            command.Parameters.AddWithValue("@Author", book.Author);
            command.Parameters.AddWithValue("@PublicationYear", book.PublicationYear);
            command.Parameters.AddWithValue("@Quantity", book.Quantity);
            command.Parameters.AddWithValue("@Genre", book.Genre);
            command.Parameters.AddWithValue("@BookID", book.BookID);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public void DeleteBook(int bookID)
        {
            string query = "DELETE FROM Books WHERE BookID = @BookID";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@BookID", bookID);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public DataTable SearchBook(string title ,string value)
        {
            string query = $"SELECT * FROM Books WHERE {title} LIKE '%{value}%'";
            return connectionSqlServer.ExecuteQuery(query);
        }
    }
}
