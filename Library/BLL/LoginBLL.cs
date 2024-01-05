using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        private ConnectionSqlServer connectionSqlServer;
        private LoginDAL loginDAL;

        public LoginBLL()
        {
            connectionSqlServer = new ConnectionSqlServer();
            loginDAL = new LoginDAL();
        }

        public bool ValidateLogin(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            Login login = new Login(username, hashedPassword);
            //Console.Write(login.ToString());
            return loginDAL.ValidateLogin(login);
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
