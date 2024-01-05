using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Login
    {
        public string UserName { get; set; }
        private string password;

        public Login(string username, string hashedPassword)
        {
            UserName = username;
            password = hashedPassword;
        }

        public Login() { } 

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }

}
