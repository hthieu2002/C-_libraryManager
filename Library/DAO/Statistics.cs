using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Statistics
    {
        public int GETstatisticsMemberRole {  get; set; }
        public int GETstatisticsMember { get; set; }
        public int GETstatisticsBook {  get; set; }
        public int GETstatisticsBookTotal {  get; set; }
        public int GETstatiticsBorrow {  get; set; }
        public int GETstatiticsReturn { get; set; }
        public Statistics() { }

        public Statistics(int GETstatisticsMemberRole, int GETstatisticsMember, int gETstatisticsBook, int gETstatisticsBookTotal, int gETstatiticsBorrow, int gETstatiticsReturn)
        {
            this.GETstatisticsMember = GETstatisticsMemberRole;
            this.GETstatisticsMember = GETstatisticsMember;
            this.GETstatisticsBook = gETstatisticsBook;
            this.GETstatisticsBookTotal = gETstatisticsBookTotal;
            this.GETstatiticsBorrow = gETstatiticsBorrow;
            this.GETstatiticsReturn = gETstatiticsReturn;
        }
    }
}
