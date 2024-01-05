using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Member
    {
        public string MemberID { get; set; } = string.Empty;
        public string IDMember{ get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
        public int Role { get; set; }

        public Member()
        {

        }
        public Member(string MemberId, string FirstName, string LastName, string Email, int Role, string iDMember)
        {
            this.MemberID = MemberId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Role = Role;
            this.IDMember = iDMember;
        }
    }
}
