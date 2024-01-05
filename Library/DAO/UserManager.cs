using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UserManager
    {
        public int UserID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } 
        public string Role { get; set; }
        public string FullName { get; set; }
        public string Image {  get; set; }
        public UserManager() { }

        public UserManager(int userID, string userName, string password, string role, string fullName, string image)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            Role = role;
            FullName = fullName;
            Image = image;
        }
    }
}
