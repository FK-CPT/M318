using Verifica2.Models;

namespace Verifica2;

public partial class CampiPage : ContentPage
{
    List<Campo> campi = new List<Campo>();
    List<Responsabile> responsabili = new List<Responsabile>();
   

    public CampiPage()
	{
		InitializeComponent();

        responsabili.Add(new Responsabile("Francesca", "Rossi"));
        responsabili.Add(new Responsabile("Marco", "Rossi"));
        responsabili.Add(new Responsabile("Luca", "Bianchi"));
        responsabili.Add(new Responsabile("Martina", "Verdi"));

        campi.Add(new Campo("Minigolf Lugano", "Via Lugano", 6900, "Lugano", "091753894", "www.minigolfLugano.ch", Responsabile, false, "minigolf1.jfif", "AAA"));
        campi.Add(new Campo("Minigolf Bellinzona", "Via Bellinzona", 6500, "Bellinzona", "4787534820", "www.minigolfBellinzona.ch", Responsabile, false, "minigolf2.jfif", "BBB"));
        campi.Add(new Campo("Minigolf Locarno", "Via Locarno", 6700, "Locarno", "8957833234", "www.minigolfLocarno.ch", Responsabile, false, "minigolf3.jfif", "CCC"));
        campi.Add(new Campo("Minigolf Caslano", "Via Caslano", 6893, "Caslano", "54835742354", "www.minigolfCaslano.ch", Responsabile, false, "minigolf4.jfif", "DDD"));
    }

    private void pickCampi_SelectedIndexChanged(object sender, EventArgs e)
    {
        pickCampi.ItemsSource = campi;
        entNomeCampo.Text = pickCampi.ToString();
        entIndirizzo.Text = campi.Indirizzo.ToString();
        entNAP.Text = campi.Nap.ToString();
        entLocalita.Text = campi.citta.ToString();
        entNomeCognomeResp.Text = campi.responsabile.ToString();
        entTelefono.Text = campi.telefono.ToString();
        entLink.Text = campi.link.ToString();
    }
}