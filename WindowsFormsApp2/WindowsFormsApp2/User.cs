using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class User
    {
        String login;
        String email;
        String phone;
        DateTime expiration;
        Passwords password;


        public User(string login, String password, string email, string phone, DateTime expiration)
        {
            this.Login = login;
            this.Password = new Passwords(password);
            this.Email = email;
            this.Phone = phone;
            this.expiration = expiration;
        }
        

        public String ToString()
        {
             return this.login + "\t" + this.password.Password + "\t" + this.email + "\t" + this.phone;
        }

        public string Login { get => login; set => login = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Expiration { get => expiration; set => expiration = value; }
        internal Passwords Password { get => password; set => password = value; }
    }
}
