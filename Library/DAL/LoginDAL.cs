using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        private ConnectionSqlServer connectionSqlServer;
        public LoginDAL()
        {
            connectionSqlServer = new ConnectionSqlServer(); 
        }

        public bool ValidateLogin(Login login)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE Username = 'test' AND Password = 'ec278a38901287b2771a13739520384d43e4b078f78affe702def108774cce24'";
            int result = connectionSqlServer.ExecuteQuery(query).Rows[0].Field<int>(0);

            return result > 0;
        }
    }
}
