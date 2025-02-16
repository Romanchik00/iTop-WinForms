using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRomRom
{
    public enum UserStatus
    {
        Admin,
        Worker,
        Visitor
    }
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
        public UserStatus Status{ get; set; }
        public User(string login, string password, string email, UserStatus status)
        {
            Login = login;
            Password = password;
            this.email = email;
            Status = status;
        }
        public User() { }
        public override string ToString()
        {
            return $"Login:{Login} Password:{Password} Email:{email} Status:{Status}";
        }
    }
}
