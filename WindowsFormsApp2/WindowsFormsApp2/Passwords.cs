using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Passwords
    {
        String password;
        DateTime expirationDate;
        bool error;


        public Passwords()
        {
                
        }

        public Passwords(String password)
        {
            if (this.IsCorrect(password))
                this.password = password;
        }

        public string Password { get => password; set => this.password = (this.IsCorrect(value)) ? value : ""; }
        public bool Error { get => error; set => error = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }

        public bool IsCorrect(String password)
        {
            bool result = false;

            // length >= 8
            if (password.Length >= 8)
            {
                // existance of A-Z
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] >= 'A' && password[i] <= 'Z')
                    {
                        result = true;
                        break;
                    }
                }

                // existance of a-z
                if (result == true)
                {
                    result = false;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (password[i] >= 'a' && password[i] <= 'z')
                        {
                            result = true;
                            break;
                        }
                    }
                }

                // existance of 0-9
                if (result == true)
                {
                    result = false;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (password[i] >= '0' && password[i] <= '9')
                        {
                            result = true;
                            break;
                        }
                    }
                }

                // existance of !@#$%^&&*()_+
                if (result == true)
                {
                    result = false;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if ((password[i] >= '!' && password[i] <= '/') ||
                            (password[i] >= ':' && password[i] <= '@') ||
                            (password[i] >= '[' && password[i] <= '`') ||
                            (password[i] >= '{' && password[i] <= '~'))
                        {
                            result = true;
                            break;
                        }
                    }
                }
              
            }

            return result;
        }
    }
}
