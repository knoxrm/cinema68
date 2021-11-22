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
        public CustomerLandingPage()
        {
            InitializeComponent();
            this.Load += LandingPage_Load;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.View = View.Details;
            //listView1.Columns.Add("ID", 120, HorizontalAlignment.Left);
            //listView1.Columns.Add("movie_name", 120, HorizontalAlignment.Left);
            //listView1.Columns.Add("movie_rating", 120, HorizontalAlignment.Left);

        }

        private void LandingPage_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
