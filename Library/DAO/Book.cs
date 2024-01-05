using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string Genre { get; set; }

        public Book()
        {
         
        }
        public Book(int bookID, string title, string author, int publicationYear, int quantity, string status, string genre)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Quantity = quantity;
            Status = status;
            Genre = genre;
        }
    }
}
