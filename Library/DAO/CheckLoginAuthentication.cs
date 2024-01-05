using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CheckLoginAuthentication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CheckRole {  get; set; }
        public string UrlImage {  get; set; }

        public CheckLoginAuthentication(int Id, string Name, string Password,string UserName, string CheckRole, string UrlImage)
        {
            this.Id = Id;
            this.Name = Name;
            this.Password = Password;
            this.CheckRole = CheckRole;
            this.UserName = UserName;
            this.UrlImage = UrlImage;
        }
        public CheckLoginAuthentication() { }

        public override string ToString()
        {
            return $"{this.Id} {this.Name} {this.CheckRole} {this.UrlImage}";
        }
    }

    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string FullName { get; set; }
        public static string UserRole { get; set; }
        public static string UserImage { get; set; }
    }

}
