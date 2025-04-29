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

        campi.Add(new Campo("Minigolf Lugano", "Via Lugano", 6900, "Lugano", "091753894", "www.minigolfLugano.ch", responsabili[0], false, "minigolf1.jfif", "AAA"));
        campi.Add(new Campo("Minigolf Bellinzona", "Via Bellinzona", 6500, "Bellinzona", "4787534820", "www.minigolfBellinzona.ch", responsabili[1], false, "minigolf2.jfif", "BBB"));
        campi.Add(new Campo("Minigolf Locarno", "Via Locarno", 6700, "Locarno", "8957833234", "www.minigolfLocarno.ch", responsabili[2], false, "minigolf3.jfif", "CCC"));
        campi.Add(new Campo("Minigolf Caslano", "Via Caslano", 6893, "Caslano", "54835742354", "www.minigolfCaslano.ch", responsabili[3], false, "minigolf4.jfif", "DDD"));
        pickCampi.ItemsSource = campi;
    }

    private void pickCampi_SelectedIndexChanged(object sender, EventArgs e)
    {
        Campo campoSelezionato = (Campo)pickCampi.SelectedItem;
        entNomeCampo.Text = pickCampi.ToString();
        entIndirizzo.Text = campoSelezionato.Indirizzo.ToString();
        entNAP.Text = campoSelezionato.Nap.ToString();
        entLocalita.Text = campoSelezionato.Citta.ToString();
        entNomeCognomeResp.Text = campoSelezionato.Responsabile.ToString();
        entTelefono.Text = campoSelezionato.Telefono.ToString();
        entLink.Text = campoSelezionato.Link.ToString();
        imgCampo.Source = campoSelezionato.PathImm.ToString();
    }
}