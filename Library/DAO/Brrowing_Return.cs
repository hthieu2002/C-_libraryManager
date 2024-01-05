using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Brrowing_Return
    {
        public string MaxID { get; set; }
        public string MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? BookID { get; set; }
        public string title { get; set; }

        //backend
        public string BorrowingID { get; set; }
        public string IDMemberBorrowing {  get; set; }
        public string BorrowingIDDetails { get; set; }
        public int IDBookBorrowingDetails { get; set; }
        public string DateBorrowing { get; set; }
        public string DateReturnBorrowing { get; set; }
        public string Status { get; set; }
        public int quantity {  get; set; }
        public int DeleteBorrowing { get; set; }

        public Brrowing_Return() { }

        public Brrowing_Return(string BorrowingID 
            , string IDMemberBorrowing, string BorrowingIDDetails, int IDBookBorrowingDetails, string DateBorrowing, string DateReturnBorrowing
            , string Status, int quantity , int deleteBorrowing)
        {
            this.BorrowingID = BorrowingID;
            this.IDMemberBorrowing = IDMemberBorrowing;
            this.BorrowingIDDetails = BorrowingIDDetails;
            this.IDBookBorrowingDetails = IDBookBorrowingDetails;
            this.DateBorrowing = DateBorrowing;
            this.DateReturnBorrowing = DateReturnBorrowing;
            this.Status = Status;
            this.quantity = quantity;
            this.DeleteBorrowing = deleteBorrowing;
        }
        public override string ToString()
        {
            return $"{MemberID}: {FirstName} {LastName} {BookID} {title}";
        }
    }
}
