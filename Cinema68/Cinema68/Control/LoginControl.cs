using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema68.Entity;
using Cinema68.Boundary;

namespace Cinema68.Control
{
    class LoginControl : Controller
    {
        Account acct = new Account();
        public void Login()
        {


        }

        public void Validate(Account accToValidate)
        {

                   
        }

        public bool Submit(string email, string pwd)
        {

            bool isSubmitted = false;

            DBConnector dBConnector = new DBConnector();
            dBConnector.GetUser(email, pwd);

            // if email already exists, use getter. Must have DB with this


            // else if email already exists but password is incorrect, 

            // else, set a new account
            acct.setEmail(email);
            acct.setPwd(pwd);
            isSubmitted = true;
            

            
            return isSubmitted;
        }
    }
}
