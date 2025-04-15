namespace AppJSON;

using AppJSON.Helpers;
using AppJSON.Models;
using System.Text.Json;

public partial class Catalogo : ContentPage
{
    Libreria libreria;
    Libro itemSelected;

    private readonly JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        IncludeFields = true
    };

	public Catalogo()
	{
		InitializeComponent();
        ReadData();
	}

    private void ReadData()
    {
        if (File.Exists(PathHelper.GetConfigJsonPath()))
        {
            var jsonString = File.ReadAllText(PathHelper.GetConfigJsonPath());
            libreria = JsonSerializer.Deserialize<Libreria>(jsonString, options);
            pickLibri.ItemsSource = libreria.Libri;
        }
        else
        {
            string jsonString = "{\"Libri\": []}";
            File.AppendAllText(PathHelper.GetConfigJsonPath(), jsonString);
        }
    }
    private void entTitolo_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.Titolo = entTitolo.Text;
    }

    private void entAutore_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.Autore = entAutore.Text;
    }

    private void entPub_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.AnnoPubblicazione = Convert.ToInt32(entPub.Text);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        string jsonString = JsonSerializer.Serialize(libreria, options);
        File.WriteAllText(Path.Combine(PathHelper.GetConfigJsonPath()), jsonString);
    }

    private void pickLibri_SelectedIndexChanged(object sender, EventArgs e)
    {
        itemSelected = (Libro)pickLibri.SelectedItem;
        entAutore.Text = itemSelected.Autore;
        entPub.Text = itemSelected.AnnoPubblicazione.ToString();
        entTitolo.Text = itemSelected.Titolo;
    }
}