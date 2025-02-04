namespace _05Piastrelle
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Calcola(object sender, EventArgs e)
        {
            try
            {
                float lunghezzaPavimento = float.Parse(entLunghezzaPavimento.Text);
                float larghezzaPavimento = float.Parse(entLarghezzaPavimento.Text);
                float lunghezzaPiastrella = float.Parse(entLunghezzaPiastrella.Text);
                float larghezzaPiastrella = float.Parse(entLarghezzaPiastrella.Text);

                float areaPavimento = lunghezzaPavimento * larghezzaPavimento;
                float areaPiastrella = lunghezzaPiastrella * larghezzaPiastrella;
                float numeroPiastrelle = (areaPavimento / areaPiastrella);

                if(lunghezzaPavimento < 0 || larghezzaPavimento < 0 || lunghezzaPiastrella < 0 || larghezzaPiastrella < 0)
                {
                    MessaggioAvviso("Inserire valori positivi!");
                }

                else
                {
                    entNumPiastrelle.Text = numeroPiastrelle.ToString();
                };
            }
            catch (FormatException fe)
            {
                MessaggioAvviso("Inserire dei numeri!");
            }
        }

        private async void MessaggioAvviso(string messaggio)
        {
            await DisplayAlert("Avviso", messaggio, "OK");
        }
    }

}
