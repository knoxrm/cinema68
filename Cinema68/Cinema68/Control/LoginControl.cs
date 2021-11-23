using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema68.Entity;
using Cinema68.Boundary;
using System.Windows.Forms;

namespace Cinema68.Control
{
    class LoginControl
    {

        public bool Validate(Account accToValidate)
        {
            DBConnector dbconnector = new DBConnector();
            string email = accToValidate.getEmail();
            string pwd = accToValidate.getPwd();
            if (dbconnector.ValidateUser(email, pwd))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                return false;
            }
        }

        public bool Submit(string email, string pwd)
        {

            bool isSubmitted = false;

            DBConnector dBConnector = new DBConnector();
            dBConnector.GetUser(email, pwd);

            // if email already exists, use getter. Must have DB with this


            // else if email already exists but password is incorrect, 

            // else, set a new account
            
            isSubmitted = true;


            Account acct = new Account(email, pwd);

            return isSubmitted;
        }
    }
}
