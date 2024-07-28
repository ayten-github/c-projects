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
        private string _userpassword;
        private static  int _id;
        public int Id { get;internal set; }
        public string Fullname {  get; set; }
        public string Email {  get; set; }
        public string Password
        {
            get
            {
                return _userpassword;

            }
            set
            {
                if (PasswordChecker(value) == true)
                {
                    _userpassword = value;
                }
            }
        }
         public User(string email, string password ) { 
            Email = email;
            Password = password;
            ++_id;
            Id = _id;
        }

        public User()
        {
        }

        public bool? PasswordChecker(string password)
        {
            if (password == null)
            {
                throw new NullReferenceException("password daxil etmemisiz");
            }
            if (password.Length >= 8 && password.Any(x => char.IsDigit(x)) && password.Any(x => char.IsUpper(x)) && password.Any(x => char.IsLower(x))) return true;
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"id{Id}, Email:{Email},Fullname:{Fullname},password{Password}");
        }

        bool IAccount.PasswordChecker(string password)
        {
            throw new NotImplementedException();
        }
    }
}
