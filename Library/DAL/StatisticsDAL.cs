using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StatisticsDAL
    {
        private ConnectionSqlServer connectionSqlServer;
        public StatisticsDAL()
        {
            connectionSqlServer = new ConnectionSqlServer();
        }

        public DataTable GETCountMemberRole()
        {
            string query = "SELECT COUNT(*) AS TotalRows FROM Members Where Role IN (2,3,4)";
            return connectionSqlServer.ExecuteQuery(query);
        }

        public DataTable GETCountMember()
        {
            string query = "SELECT COUNT(*) AS TotalRows FROM Members";
            return connectionSqlServer.ExecuteQuery(query);
        }
        public DataTable GETCountBook()
        {
            string query = "SELECT SUM(Quantity) AS TotalQuantity FROM Books";
            return connectionSqlServer.ExecuteQuery(query);
        }
        public DataTable GETCountBookTotal()
        {
            string query = "SELECT SUM(QuantityBorrowed) AS TotalQuantity FROM BorrowDetails WHERE Status = 'borrowed'";
            return connectionSqlServer.ExecuteQuery(query);
        }
        public DataTable GETCountBorrow()
        {
            string query = "SELECT COUNT(status) AS TotalStatus FROM BorrowDetails WHERE Status = 'borrowed' AND DeleteBorrow = 1";
            return connectionSqlServer.ExecuteQuery(query);
        }
        public DataTable GETCountReturn()
        {
            string query = "SELECT COUNT(status) AS TotalStatus FROM BorrowDetails WHERE Status = 'paid' AND DeleteBorrow = 1";
            return connectionSqlServer.ExecuteQuery(query);
        }
    }
}
