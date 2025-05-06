using System.Text.Json;
using Verifica3FabioKoffel.Models;

namespace Verifica3FabioKoffel
{
    public partial class MainPage : ContentPage
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Ricette.json");
        List<Ricetta> ricette;

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
                var root = JsonSerializer.Deserialize<Catalogo>(leggiJSON, options);

                if (root?.Ricette != null)
                {
                    ricette = root.Ricette;
                    pickerRicetta.ItemsSource = ricette;
                }
                else
                {
                    DisplayAlert("Errore", "Nessuna ricetta è stata trovata nel file", "OK");
                }
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
            entNumero.Text = selected.NumPersone.ToString();
            entSito.Text = selected.Sito;
            editPreparazione.Text = selected.Preparazione;
            entDifficolta.Text = selected.Difficolta.ToString();
            editCommento.Text = selected.Commento;
        }

        private void btSalva_Clicked(object sender, EventArgs e)
        {

        }
    }

}
