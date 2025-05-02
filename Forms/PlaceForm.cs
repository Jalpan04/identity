using System;
using System.Linq;
using System.Windows.Forms;
using PersonalInterestApp.Models;

namespace PersonalInterestApp.Forms
{
    public partial class PlaceForm : Form
    {
        private System.Collections.Generic.List<Place> placeList;

        public PlaceForm()
        {
            InitializeComponent();
            placeList = DataStore<Place>.Load("places");
            UpdatePlaceList();
        }

        private void UpdatePlaceList()
        {
            lstPlaces.Items.Clear();
            foreach (var place in placeList)
            {
                lstPlaces.Items.Add($"{place.Name} in {place.Location} ({place.Type})");
            }
        }

        private void btnAddPlace_Click(object sender, EventArgs e)
        {
            try
            {
                var place = new Place
                {
                    Name = txtName.Text,
                    Location = txtLocation.Text,
                    Type = txtType.Text
                };
                placeList.Add(place);
                DataStore<Place>.Save(placeList, "places");
                UpdatePlaceList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding place: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePlace_Click(object sender, EventArgs e)
        {
            if (lstPlaces.SelectedItem != null)
            {
                var selectedPlace = lstPlaces.SelectedItem.ToString();
                var placeToDelete = placeList.FirstOrDefault(p => selectedPlace.Contains(p.Name));
                if (placeToDelete != null)
                {
                    placeList.Remove(placeToDelete);
                    DataStore<Place>.Save(placeList, "places");
                    UpdatePlaceList();
                }
            }
            else
            {
                MessageBox.Show("Please select a place to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtLocation.Text = "";
            txtType.Text = "";
        }
    }
}