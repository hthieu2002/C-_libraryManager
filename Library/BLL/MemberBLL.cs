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
    public class MemberBLL
    {
        private MemberDAL memberDAL;

        public MemberBLL()
        {
            memberDAL = new MemberDAL();
        }
        public DataTable GetAllMembers()
        {
            return memberDAL.GetAllMember();
        }

        public void InsertMember(Member member)
        {
            memberDAL.InsertMember(member);
        }

        public void UpdateMember(Member member)
        {
            memberDAL.UpdateMember(member);
        }

        public void DeleteMember(string member)
        {
            memberDAL.DeleteMember(member);
        }

        public DataTable Search(string value)
        {
            return memberDAL.SearchMember(value);
        }
    }
}
