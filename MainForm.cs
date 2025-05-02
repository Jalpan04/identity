using System;
using System.Windows.Forms;
using PersonalInterestApp.Forms;

namespace PersonalInterestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            var form = new MusicForm();
            form.ShowDialog();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            var form = new MovieForm();
            form.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            var form = new BookForm();
            form.ShowDialog();
        }

        private void btnPlaces_Click(object sender, EventArgs e)
        {
            var form = new PlaceForm();
            form.ShowDialog();
        }
    }
}