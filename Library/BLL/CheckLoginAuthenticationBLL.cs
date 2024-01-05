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
    public class CheckLoginAuthenticationBLL
    {
        private CheckLoginAuthenticationDAL checkLogin;

        public CheckLoginAuthenticationBLL()
        {
            checkLogin = new CheckLoginAuthenticationDAL();
        }

        public DataTable GetRole_GetInformationUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            return checkLogin.GetRole_GetInformationUser(username, hashedPassword);
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.Unicode.GetBytes(password); // Sử dụng Unicode thay vì UTF-8

                byte[] hashBytes = sha256.ComputeHash(bytes);
                string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower(); // Chuyển đổi thành chuỗi in thường

                return hashedPassword;
            }
        }
    }
}
