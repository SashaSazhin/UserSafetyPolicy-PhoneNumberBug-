using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class PhoneNumbers
    {
        String phone;

        public PhoneNumbers()
        {

        }

        public PhoneNumbers(String phone)
        {
            if (IsCorrect(phone))
                this.phone = phone;
        }

        public string Phone { get => phone; set => phone = value; }

        public bool IsCorrect(String phone)
        {
            bool result = false;

            if (phone.Length == 13)
            {
                for (int i = 0; i <6; i++)
                {
                    if (phone.Contains("+38099") || phone.Contains("+38066") || phone.Contains("+38095") || phone.Contains("+38050")
                        || phone.Contains("+38093") || phone.Contains("+38069") || phone.Contains("+38073")
                        || phone.Contains("+38067") || phone.Contains("+38096") || phone.Contains("+38097") || phone.Contains("+38098"))
                    {
                        result = true;

                    }
                }
            }

            if(phone.Length == 10)
            {
                for(int i = 0;i<3;i++)
                {
                    if (phone.Contains("099") || phone.Contains("066") || phone.Contains("095") || phone.Contains("050")
                        || phone.Contains("093") || phone.Contains("069") || phone.Contains("073")
                        || phone.Contains("067") || phone.Contains("096") || phone.Contains("097") || phone.Contains("098"))
                    {
                        result = true;

                    }
                }

            }
            return result;
        }
    }
}
