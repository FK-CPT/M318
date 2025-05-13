using System.Text.Json;
using Verifica3FabioKoffel.Models;

namespace Verifica3FabioKoffel
{
    public partial class MainPage : ContentPage
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Ricette.json");
        Catalogo catalogo;
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
            try
            {
                var leggiJSON = File.ReadAllText(path);
                catalogo = JsonSerializer.Deserialize<Catalogo>(leggiJSON, options);
                pickerRicetta.ItemsSource = catalogo.Ricette;
            }
            catch (Exception ex)
            {
                DisplayAlert("Errore", $"Errore nella lettura del file: {ex.Message}", "OK");
            }
        }

        private void pickerRicetta_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Ricetta)pickerRicetta.SelectedItem;
            entNome.Text = selected.Nome;
            entNumero.Text = selected.NumeroPersone.ToString();
            entSito.Text = selected.SitoRicetta;
            editPreparazione.Text = selected.Preparazione;
            entDifficolta.Text = selected.Difficolta.ToString();
            editCommento.Text = selected.Commento;
        }

        private void btSalva_Clicked(object sender, EventArgs e)
        {

        }
    }

}
