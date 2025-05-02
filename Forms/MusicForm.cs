using System;
using System.Linq;
using System.Windows.Forms;
using PersonalInterestApp.Models;

namespace PersonalInterestApp.Forms
{
    public partial class MusicForm : Form
    {
        private System.Collections.Generic.List<Music> musicList;

        public MusicForm()
        {
            InitializeComponent();
            musicList = DataStore<Music>.Load("music");
            UpdateMusicList();
        }

        private void UpdateMusicList()
        {
            lstMusic.Items.Clear();
            foreach (var music in musicList)
            {
                lstMusic.Items.Add($"{music.Title} by {music.Artist} ({music.Year})");
            }
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            try
            {
                var music = new Music
                {
                    Title = txtTitle.Text,
                    Artist = txtArtist.Text,
                    Genre = txtGenre.Text,
                    Year = int.Parse(txtYear.Text)
                };
                musicList.Add(music);
                DataStore<Music>.Save(musicList, "music");
                UpdateMusicList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding music: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMusic_Click(object sender, EventArgs e)
        {
            if (lstMusic.SelectedItem != null)
            {
                var selectedMusic = lstMusic.SelectedItem.ToString();
                var musicToDelete = musicList.FirstOrDefault(m => selectedMusic.Contains(m.Title));
                if (musicToDelete != null)
                {
                    musicList.Remove(musicToDelete);
                    DataStore<Music>.Save(musicList, "music");
                    UpdateMusicList();
                }
            }
            else
            {
                MessageBox.Show("Please select a music entry to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearInputs()
        {
            txtTitle.Text = "";
            txtArtist.Text = "";
            txtGenre.Text = "";
            txtYear.Text = "";
        }
    }
}