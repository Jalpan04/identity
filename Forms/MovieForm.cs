using System;
using System.Linq;
using System.Windows.Forms;
using PersonalInterestApp.Models;

namespace PersonalInterestApp.Forms
{
    public partial class MovieForm : Form
    {
        private System.Collections.Generic.List<Movie> movieList;

        public MovieForm()
        {
            InitializeComponent();
            movieList = DataStore<Movie>.Load("movies");
            UpdateMovieList();
        }

        private void UpdateMovieList()
        {
            lstMovies.Items.Clear();
            foreach (var movie in movieList)
            {
                lstMovies.Items.Add($"{movie.Title} directed by {movie.Director} ({movie.Year})");
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                var movie = new Movie
                {
                    Title = txtTitle.Text,
                    Director = txtDirector.Text,
                    Genre = txtGenre.Text,
                    Year = int.Parse(txtYear.Text)
                };
                movieList.Add(movie);
                DataStore<Movie>.Save(movieList, "movies");
                UpdateMovieList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding movie: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (lstMovies.SelectedItem != null)
            {
                var selectedMovie = lstMovies.SelectedItem.ToString();
                var movieToDelete = movieList.FirstOrDefault(m => selectedMovie.Contains(m.Title));
                if (movieToDelete != null)
                {
                    movieList.Remove(movieToDelete);
                    DataStore<Movie>.Save(movieList, "movies");
                    UpdateMovieList();
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearInputs()
        {
            txtTitle.Text = "";
            txtDirector.Text = "";
            txtGenre.Text = "";
            txtYear.Text = "";
        }
    }
}