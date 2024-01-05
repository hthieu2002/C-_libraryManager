using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StatisticsBLL
    {
        private StatisticsDAL statisticsDAL;

        public StatisticsBLL()
        {
            statisticsDAL = new StatisticsDAL();
        }
        public DataTable GETCountMemberRole()
        {
            return statisticsDAL.GETCountMemberRole();
        }

        public DataTable GETCountMember()
        {
            return statisticsDAL.GETCountMember();
        }
        public DataTable GETCountBook()
        {
            return statisticsDAL.GETCountBook();
        }
        public DataTable GETCountBookTotal()
        {
            return statisticsDAL.GETCountBookTotal();
        }

        public DataTable GETCountBorrow()
        {
            return statisticsDAL.GETCountBorrow();
        }

        public DataTable GETCountReturn()
        {
            return statisticsDAL.GETCountReturn();
        }
    }
}
