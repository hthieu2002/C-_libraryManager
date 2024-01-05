using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CheckLoginAuthenticationDAL
    {
        private ConnectionSqlServer connectionSqlServer;

        public CheckLoginAuthenticationDAL()
        {
            connectionSqlServer = new ConnectionSqlServer();
        }

        public DataTable GetRole_GetInformationUser(string username , string password)
        {
            string query = $"SELECT * From Users Where UserName = '{username}' AND Password = '{password}'";
            Console.WriteLine(username + password);
            return connectionSqlServer.ExecuteQuery(query);
        }
    }
}
