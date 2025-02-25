using _02Geometria.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
namespace _02Geometria;

public partial class CuboPage : ContentPage
{
	Cubo cubo = new Cubo();
	public CuboPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
            cubo.Lato = Convert.ToDouble(entLato.Text);
            entPerimetro.Text = cubo.CalcolaPerimetro().ToString();
            entVolume.Text = cubo.CalcolaVolume().ToString();
        }
		catch (ArgumentException ae)
		{
			MostraAllert(ae.Message);
		}
    }
	private async void MostraAllert(string messaggio)
	{
		await DisplayAlert("Allert", messaggio, "OK");
	}
}