using CatalogoVideogame.Helpers;
using CatalogoVideogame.Models;
using System.Text.Json;

namespace CatalogoVideogame;

public partial class AggiungiVideogioco : ContentPage
{
    Catalogo catalogo;
    Videogame itemSelected;

    private readonly JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        IncludeFields = true
    };

    public AggiungiVideogioco()
	{
		InitializeComponent();
        ReadData();
    }

    private void ReadData()
    {
        if (File.Exists(PathHelper.GetConfigJsonPath()))
        {
            var jsonString = File.ReadAllText(PathHelper.GetConfigJsonPath());
            catalogo = JsonSerializer.Deserialize<Catalogo>(jsonString, options);
        }
        else
        {
            string jsonString = "{\"Videogames\": []}";
            File.AppendAllText(PathHelper.GetConfigJsonPath(), jsonString);
        }
    }

    private void entAggiungiVideogioco_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.Title = entAggiungiVideogioco.Text;
    }

    private void entAggiungiDescrizione_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.Description = entAggiungiDescrizione.Text;
    }

    private void entAggiungiSviluppatore_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.Developer = entAggiungiSviluppatore.Text;
    }

    private void entAggiungiValutazione_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.Commento = entAggiungiValutazione.Text;
    }

    private void entAggiungiImmagine_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.Image = entAggiungiImmagine.Text;
    }

    private void btAggiungi_Clicked(object sender, EventArgs e)
    {
        try
        {
            catalogo.AggiungiVideogame(new Videogame(entAggiungiVideogioco.Text, entAggiungiSviluppatore.Text, entAggiungiDescrizione.Text, entAggiungiDescrizione.Text, entAggiungiValutazione.Text));
            string jsonString = JsonSerializer.Serialize(catalogo, options);
            File.WriteAllText(Path.Combine(PathHelper.GetConfigJsonPath()), jsonString);
            AlertMessage("Videogioco aggiunto con successo");
        }
        catch (Exception ex)
        {
            AlertMessage(ex.Message);
        }
        CleanControl();
    }

    private async void AlertMessage(string message)
    {
        await DisplayAlert("Alert", message, "OK");
    }

    private void CleanControl()
    {
        entAggiungiVideogioco.Text = string.Empty;
        entAggiungiValutazione.Text = string.Empty;
        entAggiungiSviluppatore.Text = string.Empty;
        entAggiungiImmagine.Text = string.Empty;
        entAggiungiDescrizione.Text = string.Empty;
    }
}