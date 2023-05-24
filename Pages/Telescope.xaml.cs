using MySolarSystem.Data;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Maui.Controls;

namespace MySolarSystem.Pages
{
    public partial class Telescope : ContentPage
    {
        private const string NasaApiUrl = "https://api.nasa.gov/planetary/apod?api_key=9ovGga9KxlnXwBgu9zEkuN7XYOe1JBuvWuoValgJ";

        public Telescope()
        {
            InitializeComponent();
            FetchNasaPictureOfTheDay();
        }

        private async void FetchNasaPictureOfTheDay()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(NasaApiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        NasaPicture picture = JsonConvert.DeserializeObject<NasaPicture>(json);

                        // Update the UI to display the image
                        nasaImage.Source = picture.Url;
                        explanationLabel.Text = picture.Explanation;
                    }
                    else
                    {
                        // Handle the error condition
                        Console.WriteLine("Failed to fetch NASA Picture of the Day");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
