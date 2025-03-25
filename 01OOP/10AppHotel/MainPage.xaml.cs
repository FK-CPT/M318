using _10AppHotel.Models;
using System.Data.Common;

namespace _10AppHotel
{
    public partial class MainPage : ContentPage
    {
        string[] immagini = { "stanza.jpg", "stanza2.jpg", "stanza3.jpg" };
        Stanza stanza100 = new Stanza(100, 7, "Stanza numero 100");
        Calcolatore calcolatore;
        public MainPage()
        {
            InitializeComponent();
            calcolatore = new Calcolatore(stanza100);
            editOss.Text = calcolatore.Stanza.Osservazioni;
            entStanza.Text = calcolatore.Stanza.Numero.ToString();
            entCosto.Text = calcolatore.Stanza.Costo.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            calcolatore.Persone = Convert.ToInt32(stepPersone.Value);
            calcolatore.DataArrivo = dateArrivo;
            calcolatore.DataPartenza = datePartenza;
            calcolatore.HasAnimali = checkAnimali.IsChecked;
            MessaggioCalcolatore();
        }

        private void stepPersone_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            entPersone.Text = stepPersone.Value.ToString();
        }

        private void MessaggioCalcolatore()
        {
            double giorni = calcolatore.CalcolaGiorni();
            double costo = calcolatore.CalcolaCosto();
            double persone = calcolatore.Persone;
            string message = $"Il costo del soggiorno per {giorni} giorni" + $" per {persone} persone" + $" è di {costo} Fr.-";
            DisplayAlert("Costo pernottamento", message, "OK");
        }
    }
}
