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
    public class UserManagerBLL
    {
        private UserManagerDAL user;

        public UserManagerBLL()
        {
            user = new UserManagerDAL();
        }

        public DataTable GetAllDataUser()
        {
            return user.GetAllDataUser();
        }
        public void InsertUser(UserManager user)
        {
            this.user.InsertUser(user);
        }
        public void DeleteUser(int id)
        {
            this.user.DeleteUser(id);
        }
        public void UpdateAdminRole(int id)
        {
            this.user.UpdateAdminRole(id);
        }

        public void UpdateUser(UserManager user)
        {
            this.user.UpdateUser(user);
        }
    }
}
