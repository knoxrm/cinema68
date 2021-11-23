using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace Cinema68.Entity
{
    class Account
    {
        private string password;
        private string email;
        private bool isAdmin;

        public Account(string email, string pword)
        {
            setPwd(pword);
            setEmail(email);
            setAdmin(email);
        }

        public string getPwd()
        {
            return password;
        }

        public void setPwd(string pwd)
        {
            password = pwd;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string Email)
        {
            this.email = Email;

        }

        public bool getAdmin()
        {
            return isAdmin;
        }

        public void setAdmin(string Email)
        {

            if (Email.Contains("@augusta.edu"))
                isAdmin = true;

            else
                isAdmin = false;
        }
    }
}
