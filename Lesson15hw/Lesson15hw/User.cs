using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15hw
{
    public class User : IAccount
    {
        private static  int _id;
        public int Id { get; set; }
        public string Fullname {  get; set; }
        public string Email {  get; set; }
        public string Password {  get; set; }
         public User(string email, string password ) { 
            Email = email;
            Password = password;
            ++_id;
            Id = _id;
        }

        public User()
        {
        }

        public  bool? PasswordChecker(string password) {
            if (password == null) return null;
            if (password.Length >= 8 && password.Any(x => char.IsDigit(x)) && password.Any(x => char.IsUpper(x)) && password.Any(x => char.IsLower(x))) return true;
            return false;          
            
        }
        public string ShowInfo() {
            return $"Id: {Id} Fullname: {Fullname} Email: {Email}";
                }

        bool IAccount.PasswordChecker(string password)
        {
            throw new NotImplementedException();
        }

        string IAccount.ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
