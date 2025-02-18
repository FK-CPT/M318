using _02Geometria.Models;

namespace _02Geometria;

public partial class RettangoloPage : ContentPage
{
    Rettangolo rettangolo;
    public RettangoloPage()
	{
		InitializeComponent();
        rettangolo = new Rettangolo();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            rettangolo.LatoMaggiore = Convert.ToDouble(entLatoMaggiore.Text);
            rettangolo.LatoMinore = Convert.ToDouble(entLatoMinore.Text);
            entArea.Text = rettangolo.CalcolaArea().ToString();
            entPerimetro.Text = rettangolo.CalcolaPerimetro().ToString();
        }
        catch (ArgumentException ae)
        {
            MostraAllert(ae.Message);
        }
    }
    private async void MostraAllert(string messaggio)
    {
        await DisplayAlert("Errore", messaggio, "OK");
    }
}