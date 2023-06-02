using MySolarSystem.Data;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Maui.Controls;

namespace MySolarSystem.Pages
{
    public partial class Telescope : ContentPage
    {
        private const string NasaApiUrl = "https://api.nasa.gov/planetary/apod?api_key=Whye801lbl12E2UL7TKblEQwj21cMc43CrVkeX0o";

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
                    // Check if the HTTP request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        NasaPicture picture = JsonConvert.DeserializeObject<NasaPicture>(json);

                        // Display the image and the explanation
                        nasaImage.Source = picture.Url;
                        explanationLabel.Text = picture.Explanation;
                        SemanticProperties.SetDescription(explanationLabel, picture.Explanation);
                    }
                    else
                    {
                        // Handle the error condition when the request fails
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
