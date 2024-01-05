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
    public class BookBLL
    {
        private BookDAL bookDAL;

        public BookBLL()
        {
            bookDAL = new BookDAL();
        }

        public DataTable GetAllBooks()
        {
            return bookDAL.GetAllBooks();
        }

        public void InsertBook(Book book)
        {
            bookDAL.InsertBook(book);
        }

        public void UpdateBook(Book book)
        {
            bookDAL.UpdateBook(book);
        }

        public void DeleteBook(int bookID)
        {
            bookDAL.DeleteBook(bookID);
        }
        public DataTable SearchBook(string title, string value)
        {
            return bookDAL.SearchBook(title , value);
        }
    }
}
