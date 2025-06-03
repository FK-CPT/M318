using Progetto.Helpers;
using Progetto.Models;
using System.Text.Json;

namespace Progetto
{
    public partial class MainPage : ContentPage
    {
        Artista artista;

        private readonly JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            IncludeFields = true
        };

        public MainPage()
        {
            InitializeComponent();
            ReadDataArtisti();
        }

        private void ReadDataArtisti()
        {
            if (File.Exists(PathHelper.GetConfigJsonPathArtisti()))
            {
                var jsonString = File.ReadAllText(PathHelper.GetConfigJsonPathArtisti());
                artista = JsonSerializer.Deserialize<Artista>(jsonString, options);
                pickArtista.ItemsSource = artista.Nome;
            }
            else
            {
                string jsonString = "{\"Artisti\": []}";
                File.AppendAllText(PathHelper.GetConfigJsonPathArtisti(), jsonString);
            }
        }

        private void pickArtista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}