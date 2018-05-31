using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Emails
    {
        String email;

        public Emails()
        {

        }

        public Emails(String email)
        {
            if (this.IsCorrect(email))
                this.email = email;
        }

        public string Email { get => email; set => email = value; }

        public bool IsCorrect(String email)
        {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            /*
            bool result = true;
            return result;
            if (email.Contains("@mail.ru") || email.Contains("@ukr.net") || email.Contains("@gmail.com") || email.Contains("@rambler.ru")
              || email.Contains("@rambler.ua") || email.Contains("@mail.ua") || email.Contains("@inbox.ru") || email.Contains("@list.ru"))
            {
                result = true;
            }
            */
        }
    }
}
