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
    public partial class CustomerLandingPage : Form
    {
        private void OpenBuyTicketForm(Form BuyTicket, object sender)
        {
            BuyTicket = new BuyTicketForm();
            ActiveForm.Hide();
            ActiveForm = BuyTicket;
            ActiveForm.BringToFront();
            ActiveForm.Show();
        }
        private void ToBuyTicketForm_Click(object sender, EventArgs e)
        {
            BuyTicketForm BuyTicket = new BuyTicketForm();
            OpenBuyTicketForm(BuyTicket, sender);
        }


        public CustomerLandingPage()
        {
            InitializeComponent();
            this.Load += LandingPage_Load;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("movie_name", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("movie_rating", 160, HorizontalAlignment.Center);

        }

        private void LandingPage_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void LogOutButtonFromCust_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void OpenCustomerLandingPage(Form CustomerLanding, object sender)
        {
            CustomerLanding = new CustomerLandingPage();
            ActiveForm.Hide();
            ActiveForm = CustomerLanding;
            ActiveForm.BringToFront();
            ActiveForm.Show();
        }
        private void ToCustomerLandingPage_Click(object sender, EventArgs e)
        {
            CustomerLandingPage CustomerLanding = new CustomerLandingPage();
            OpenCustomerLandingPage(CustomerLanding, sender);
        }

    }
}
