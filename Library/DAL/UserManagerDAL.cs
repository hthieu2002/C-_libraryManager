using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class UserManagerDAL
    {
        private ConnectionSqlServer connectionSqlServer;
        public UserManagerDAL()
        {
            connectionSqlServer = new ConnectionSqlServer();
        }

        public DataTable GetAllDataUser()
        {
            string query = "SELECT * FROM users Where role = 'User'";
            return connectionSqlServer.ExecuteQuery(query);
        }
        public void InsertUser(UserManager user)
        {
            string query = "INSERT INTO Users (UserName, Role, Password, FullName, Image) " +
               "VALUES (@UserName, @Role, @Password, @FullName, @Image)";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@Role", "User");
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@FullName", user.FullName);
            command.Parameters.AddWithValue("@Image", user.Image);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public void DeleteUser(int id)
        {
            string query = "DELETE FROM Users WHERE UserId = @ID";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@ID", id);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }
        public void UpdateAdminRole(int id)
        {
            string query = "UPDATE Users SET Role = @role " +
                   "WHERE UserId = @id";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@role", "Admin");
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public void UpdateUser(UserManager user)
        {
            string query = "UPDATE Users SET UserName = @UserName, " +
               "Password = @Password, FullName = @FullName, Image = @Image " +
               "WHERE UserId = @UserId";


            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@FullName", user.FullName);
            command.Parameters.AddWithValue("@Image", user.Image);
            command.Parameters.AddWithValue("@UserId", user.UserID);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }
    }
}
