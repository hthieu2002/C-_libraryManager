using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Borrowing_ReturnBLL
    {
        private Borrowing_ReturnDAL borrowing_Return ;

        public Borrowing_ReturnBLL()
        {
            borrowing_Return = new Borrowing_ReturnDAL();
        }

        public string GetMaxID()
        {
            return borrowing_Return.GetMaxId();
        }

        public DataTable GetMember()
        {
            return borrowing_Return.GetMember();
        }

        public DataTable GetBook()
        {
            return borrowing_Return.GetBook();
        }
        public DataTable GetBorrowing()
        {
            return borrowing_Return.GetAllBorrowing();
        }

        public void InsertBorrow(Brrowing_Return brrowing)
        {
            borrowing_Return.InsertBorrowing(brrowing);
        }

        public void deleteBorrow( string value)
        {
            borrowing_Return.delete( value);
        }

        public void returnBorrow(string value)
        {
            borrowing_Return.returnBorrow(value);
        }
        public void reNewBorrow(string key,string value)
        {
            borrowing_Return.reNewBorrow(key,value);
        }
        public DataTable Search(string value)
        {
            return borrowing_Return.Search(value);
        }

        public DataTable Histoey()
        {
            return borrowing_Return.History();
        }
    }
}
