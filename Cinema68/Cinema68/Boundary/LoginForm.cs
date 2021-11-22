using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema68.Boundary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            PasswordField.PasswordChar = '*';
        }
        private void OpenLandingPage(Form LandingPage, object sender)
        {
            LandingPage = new CustomerLandingPage();
            ActiveForm.Hide();
            ActiveForm = LandingPage;
            ActiveForm.BringToFront();
            ActiveForm.Show();
        }
        private void ToLandingPage_Click(object sender, EventArgs e)
        {
            CustomerLandingPage LandingPage= new CustomerLandingPage();
            OpenLandingPage(LandingPage, sender);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void Header2_Click(object sender, EventArgs e)
        {

        }
    }
}
