using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Logins
    {
        String login;

        public Logins()
        {

        }
        public Logins(String login)
        {
            if (this.IsCorrect(login))
                this.login = login;
        }


        public string Login { get => login; set => login = value; }

        public bool IsCorrect(String login)
        {
            bool result = false;

            if (login.Length >= 3 && login.Length<=20)
            {
                result = true;
            }
            return result;
        }
    }
}
