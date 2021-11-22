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
    public partial class StartupPage : Form
    {
        
        public StartupPage()
        {
            InitializeComponent();
        }

        private void OpenLoginPage(Form LoginPage, object sender)
        {
            LoginPage = new LoginForm();
            ActiveForm.Hide();
            ActiveForm = LoginPage;
            ActiveForm.BringToFront();
            ActiveForm.Show();
        }
        private void ToLoginPage_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            OpenLoginPage(loginForm, sender);
        }

        private void StartupPage_Load(object sender, EventArgs e)
        {

        }

        private void Header_Click(object sender, EventArgs e)
        {

        }
    }
}
