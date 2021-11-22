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
    public partial class AdminLandingPage : Form
    {
        public AdminLandingPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HeaderCustLandingPage_Click(object sender, EventArgs e)
        {

        }

        private void AdminLandingPage_Load(object sender, EventArgs e)
        {

        }

        private void OpenAddMovieForm(Form AddMovie, object sender)
        {
            AddMovie = new AddMovieForm();
            ActiveForm.Hide();
            ActiveForm = AddMovie;
            ActiveForm.BringToFront();
            ActiveForm.Show();
        }
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            AddMovieForm AddMovie = new AddMovieForm();
            OpenAddMovieForm(AddMovie, sender);
        }
    }
}
