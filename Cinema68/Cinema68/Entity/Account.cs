using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace cinema68.Entity
{
    class Account
    {
        private string password;
        private string email;
        private bool isAdmin;

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
            try
            {
                var addr = new MailAddress(Email);

                Email = addr.Address;

                if (Email.Contains("@augusta.edu"))
                    isAdmin = true;


                else
                    isAdmin = false;
            }

            catch
            {
                throw new ArgumentException("Invalid email address");
            }

        }

        public bool getAdmin()
        {
            return isAdmin;
        }

    }
}
