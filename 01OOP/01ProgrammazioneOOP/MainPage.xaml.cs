using _01ProgrammazioneOOP.Models;

namespace _01ProgrammazioneOOP
{
    public partial class MainPage : ContentPage
    {
        Rettangolo rettangolo;
        public MainPage()
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
}
