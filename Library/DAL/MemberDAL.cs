using DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MemberDAL
    {
        private ConnectionSqlServer connectionSqlServer;
        public MemberDAL()
        {
            connectionSqlServer = new ConnectionSqlServer();
        }

        public DataTable GetAllMember()
        {
            string query = "SELECT * FROM Members";
            return connectionSqlServer.ExecuteQuery(query);
        }
        public void InsertMember(Member member)
        {
            string query = "INSERT INTO Members (MemberID, FirstName, LastName, Email, Role) " +
               "VALUES (@MemberID, @FirstName, @LastName, @Email, @Role)";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@MemberID", member.MemberID);
            command.Parameters.AddWithValue("@FirstName", member.FirstName);
            command.Parameters.AddWithValue("@LastName", member.LastName);
            command.Parameters.AddWithValue("@Email", member.Email);
            command.Parameters.AddWithValue("@Role", member.Role);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public void UpdateMember(Member member)
        {
            string query = "UPDATE Members SET MemberID = @MemberID, FirstName = @FirstName, " +
                   "LastName = @LastName, Email = @Email, Role = @Role " +
                   "WHERE MemberID = @MemberIDW";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@MemberID", member.MemberID);
            command.Parameters.AddWithValue("@FirstName", member.FirstName);
            command.Parameters.AddWithValue("@LastName", member.LastName);
            command.Parameters.AddWithValue("@Email", member.Email);
            command.Parameters.AddWithValue("@Role", member.Role);
            command.Parameters.AddWithValue("@MemberIDW", member.IDMember);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public void DeleteMember(string memberID)
        {
            string query = "DELETE FROM Members WHERE MemberID = @MemberID";

            SqlCommand command = new SqlCommand(query, connectionSqlServer.OpenConnection());
            command.Parameters.AddWithValue("@MemberID", memberID);

            command.ExecuteNonQuery();
            connectionSqlServer.CloseConnection();
        }

        public DataTable SearchMember(string value)
        {
            string query = $"SELECT * FROM Members WHERE Role = '{value}'";
            return connectionSqlServer.ExecuteQuery(query);
        }
    }
}
