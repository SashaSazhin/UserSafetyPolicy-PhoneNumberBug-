using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<User> Users;
        List<DateTime> endDate;
        DialogResult ok_cancel;

        public Form1()
        {
            InitializeComponent();
            Users = new List<User>();
            endDate = new List<DateTime>();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Passwords p = new Passwords();
            p.Password = tbPassword.Text;

            Logins l = new Logins();
            l.Login = tbLogin.Text;

            Emails em = new Emails();
            em.Email = tbEmail.Text;

            PhoneNumbers ph = new PhoneNumbers();
            ph.Phone = tbPhone.Text;

            if (p.IsCorrect(p.Password) == true && l.IsCorrect(l.Login) == true && em.IsCorrect(em.Email) == true && ph.IsCorrect(ph.Phone) == true)
            {
                if (CheckPsw(tbPassword.Text.ToString()))
                {
                    Users.Add(new User(tbLogin.Text, tbPassword.Text, tbEmail.Text, tbPhone.Text, dateTimeExpiration.Value));
                    listBoxUsers.Items.Add(Users[Users.Count - 1].ToString() + '\n');
                    tbPassword.BackColor = Color.White;
                    tbPhone.BackColor = Color.White;
                    tbEmail.BackColor = Color.White;
                    tbLogin.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("You're trying to enter the same password\n" +
                                     "You can't.Chenge it please");
                }
                endDate.Add(dateTimeExpiration.Value);
            }
            else if (p.IsCorrect(p.Password) == false)
            {
                if (tbPassword.BackColor != Color.Red)
                {
                    tbPassword.BackColor = Color.Red;
                    MessageBox.Show("Hey.It seems like you've made a mistake\n" +
                                    "in password field.You need to correct it");
                }
            }
            if (l.IsCorrect(l.Login) == false)
            {
                if (tbLogin.BackColor != Color.Red)
                {
                    tbLogin.BackColor = Color.Red;
                    MessageBox.Show("How did you manage to make a mistake \n" +
                                     "in a Login field? Correct it before anyone sees it");

                }
            }
            if (em.IsCorrect(em.Email) == false)
            {
                if (tbEmail.BackColor != Color.Red)
                {
                    tbEmail.BackColor = Color.Red;
                    MessageBox.Show("Another mistake\n" +
                    "Will you correct it?");
                }
            }
            if (ph.IsCorrect(ph.Phone) == false)
            {
                if (tbPhone.BackColor != Color.Red)
                {
                    tbPhone.BackColor = Color.Red;
                    MessageBox.Show("Just correct it.Please");
                }
            }


        }
         

        private bool CheckPsw(string password)
        {
            

            bool checkpass = true;
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Password.IsCorrect(tbPassword.Text))
                    {
                    if (Users[i].Password.Password == password)
                    {
                        tbPassword.BackColor = Color.Red;
                        checkpass = false;
                        break;
                    }
                }
                
            }
            return checkpass;
        }
        
       

      

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Password.ExpirationDate < DateTime.Today)
                {
                    ok_cancel = MessageBox.Show("Program is going to delete expired password or passwords.\n" + "Press OK to do it and Cancel to stop it",  "DeleteBox", MessageBoxButtons.OKCancel);
                    break;
                }
            }

            if (ok_cancel == DialogResult.OK)
            {
                listBoxUsers.Items.Clear();
                for (int i = 0; i < Users.Count; i++)
                {
                    if (endDate[i] <= DateTime.Today)
                    {
                        Users.RemoveAt(i);
                    }
                    else
                    {
                        listBoxUsers.Items.Add(Users[i].ToString() + "\n");
                    }
                }
            }


        }

    }
}

/*if (tbPassword.Text == "" || tbLogin.Text == "" || tbEmail.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("WTF&&&&");

            }
*/