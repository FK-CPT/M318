using System.Text.Json;
using Verifica3FabioKoffel.Helpers;
using Verifica3FabioKoffel.Models;

namespace Verifica3FabioKoffel;

public partial class InsertPage : ContentPage
{
	Catalogo catalogo;
    private readonly JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        IncludeFields = true
    };

    public InsertPage()
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
            string jsonString = "{\"Ricette\":[]}";
            File.AppendAllText(PathHelper.GetConfigJsonPath(), jsonString);
        }
    }

    private void btInserisci_Clicked(object sender, EventArgs e)
    {
        try
        {
            catalogo.AggiungiRicetta(new Ricetta(entInsNome.Text, Convert.ToInt32(entInsNumPers.Text), entInsLink.Text, entInsPreparazione.Text, Convert.ToInt32(entInsDifficolta.Text), entInsCommento.Text));
            string jsonString = JsonSerializer.Serialize(catalogo, options);
        }
        catch (Exception ex)
        {
            AlertMesage(ex.Message);
        }
        CleanControl();
    }

    private async void AlertMesage(string message)
    {
        await DisplayAlert("Alert", message, "OK");
    }

    private void CleanControl()
    {
        entInsNome.Text = string.Empty;
        entInsDifficolta.Text = string.Empty;
        entInsNumPers.Text = string.Empty;
        entInsLink.Text = string.Empty;
        entInsPreparazione.Text = string.Empty;
        entInsCommento.Text = string.Empty;
    }
}