using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Newtonsoft.Json;
using static MovieAPI.MovieAPI;

namespace MovieAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly MovieAPI movieAPI = new MovieAPI();
        private  List<MovieAPI.Movie> movies = new List<MovieAPI.Movie>(); // Store movies for easier reference
        private readonly List<string> watchlist = new List<string>();

        // this method to parse the result into a list of movies
        private List<MovieAPI.Movie> ParseMovies(string result)
        {
            var json = JsonConvert.DeserializeObject<dynamic>(result);
            var movieList = new List<MovieAPI.Movie>();

            if (json?.Search != null)
            {
                foreach (var item in json.Search)
                {
                    movieList.Add(new MovieAPI.Movie
                    {
                        Title = item.Title,
                        Year = item.Year
                    });
                }
            }

            return movieList;
        }
        private async void Search_btn_Click(object sender, EventArgs e)
        {
            string query = SearchTextBox.Text.Trim();
            try
            {
                string result = await movieAPI.SearchMoviesAsync(query);
                movies = ParseMovies(result); // Parse the JSON string into a list of Movie objects
                MovieListBox.Items.Clear();     

                
                foreach (var movie in movies)
                {
                    MovieListBox.Items.Add($"{movie.Title} ({movie.Year})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching movies: {ex.Message}");
            }
        }
        
        private async void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedItem != null)
            {
                string imdbId = GetImdbIdFromSelection(MovieListBox.SelectedItem.ToString()); // Implement this helper.string details = await movieAPI.GetMovieDetailsAsync(imdbId);
                string details = await movieAPI.GetMovieDetailsAsync(imdbId);
                DisplayMovieDetails(details); // Implement to populate the UI.
            }
        }

        
        

        // this method to extract IMDb ID from the selected movie string
        private string GetImdbIdFromSelection(string movieSelection)
        {
            // Assuming the format is "Title (Year)" and we want to extract the IMDb ID
            // Modify this if the selection format changes
            return movieSelection.Split(' ')[0]; // Example: returning first part as IMDb ID (this is just an example)
        }

        private void DisplayMovieDetails(string details)
        {
            // Display details in the UI, for example in a label or textbox
            MessageBox.Show(details); // This is a simple placeholder
        }

        private List<string> WatchlistBox = new List<string>();

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedItem != null)
            {
                string selectedMovie = MovieListBox.SelectedItem.ToString();
                if (!WatchlistBox.Contains(selectedMovie))
                {
                    watchlist.Add(selectedMovie);
                    WatchListBox.Items.Add(selectedMovie);
                }
                else
                {
                    MessageBox.Show("Movie already in watchlist!");
                }
            }
        }

        private void WatchListBox_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
