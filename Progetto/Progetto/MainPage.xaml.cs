using Progetto.Models;
using System.Text.Json;

namespace Progetto
{
    public partial class MainPage : ContentPage
    {
        string pathArtisti = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Artisti.json");
        string pathAlbum = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Album.json");
        string pathPopolariTravisScott = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PopolariTravisScott.json");
        string pathPopolariFuture = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PopolariFuture.json");
        string pathPopolariGunna = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PopolariGunna.json");
        string pathPopolariThasup = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PopolariThasup.json");
        string pathPopolariLazza = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PopolariLazza.json");
        string pathPopolariSferaEbbasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PopolariSferaEbbasta.json");
        string pathPopolariNemzzz = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PopolariNemzzz.json");
        Catalogo catalogo;

        private readonly JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            IncludeFields = true
        };

        public MainPage()
        {
            InitializeComponent();

            try
            {
                var leggiJSONArtisti = File.ReadAllText(pathArtisti);
                catalogo = JsonSerializer.Deserialize<Catalogo>(leggiJSONArtisti, options);
                pickArtista.ItemsSource = catalogo.Artisti;

                var leggiJSONAlbum = File.ReadAllText(pathAlbum);
                catalogo = JsonSerializer.Deserialize<Catalogo>(leggiJSONAlbum, options);
                pickArtista.ItemsSource = catalogo.Albums;

                var leggiJSONTravisScott = File.ReadAllText(pathPopolariTravisScott);
                catalogo = JsonSerializer.Deserialize<Catalogo>(leggiJSONTravisScott, options);

                var leggiJSONFuture = File.ReadAllText(pathPopolariFuture);
                catalogo = JsonSerializer.Deserialize<Catalogo>(leggiJSONFuture, options);

                var leggiJSONGunna = File.ReadAllText(pathPopolariGunna);
                catalogo = JsonSerializer.Deserialize<Catalogo>(leggiJSONGunna, options);

                var leggiJSONThasup = File.ReadAllText(pathPopolariThasup);
                catalogo = JsonSerializer.Deserialize<Catalogo>(leggiJSONThasup, options);

                var leggiJSONLazza = File.ReadAllText(pathPopolariLazza);
                catalogo = JsonSerializer.Deserialize<Catalogo>(leggiJSONLazza, options);

                var leggiJSONSferaEbbasta = File.ReadAllText(pathPopolariSferaEbbasta);
                catalogo = JsonSerializer.Deserialize<Catalogo>(leggiJSONSferaEbbasta, options);

                var leggiJSONNemzzz = File.ReadAllText(pathPopolariNemzzz);
                catalogo = JsonSerializer.Deserialize<Catalogo>(leggiJSONNemzzz, options);

                pickArtista.ItemsSource = catalogo.Popolari;
            }
            catch (Exception ex)
            {
                DisplayAlert("Errore", $"Errore nella lettura del file: {ex.Message}", "OK");
            }
        }

        private void pickArtista_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedArtista = (Artista)pickArtista.SelectedItem;
            imgArtista.Source = selectedArtista.ImgArtista.ToString();
            lbNome.Text = selectedArtista.Nome;
            lbGenere.Text = selectedArtista.Genere;
            lbAscoltiMensili.Text = selectedArtista.AscoltiMensili.ToString();
            editBiografia.Text = selectedArtista.Biografia;

            var selectedAlbum = (Album)pickArtista.SelectedItem;
            lbAlbumName.Text = selectedAlbum.Nome;
            imgAlbum.Source = selectedAlbum.CoverAlbum.ToString();
            lbAscoltiAlbum.Text = selectedAlbum.Ascolti.ToString();
            editSongsAlbum.Text = selectedAlbum.Canzoni.ToString();

            var selectedPopolari = (Popolari)pickArtista.SelectedItem;
            imgSong1.Source = selectedPopolari.ImgCanzone.ToString();
            lbTitoloCanzone1.Text = selectedPopolari.Titolo;
            lbDurataCanzone1.Text = selectedPopolari.Durata;
            lbAscoltiCanzone1.Text = selectedPopolari.Ascolti.ToString();

            imgSong2.Source = selectedPopolari.ImgCanzone.ToString();
            lbTitoloCanzone2.Text = selectedPopolari.Titolo;
            lbDurataCanzone2.Text = selectedPopolari.Durata;
            lbAscoltiCanzone2.Text = selectedPopolari.Ascolti.ToString();

            imgSong3.Source = selectedPopolari.ImgCanzone.ToString();
            lbTitoloCanzone3.Text = selectedPopolari.Titolo;
            lbDurataCanzone3.Text = selectedPopolari.Durata;
            lbAscoltiCanzone3.Text = selectedPopolari.Ascolti.ToString();

            imgSong4.Source = selectedPopolari.ImgCanzone.ToString();
            lbTitoloCanzone4.Text = selectedPopolari.Titolo;
            lbDurataCanzone4.Text = selectedPopolari.Durata;
            lbAscoltiCanzone4.Text = selectedPopolari.Ascolti.ToString();

            imgSong5.Source = selectedPopolari.ImgCanzone.ToString();
            lbTitoloCanzone5.Text = selectedPopolari.Titolo;
            lbDurataCanzone5.Text = selectedPopolari.Durata;
            lbAscoltiCanzone5.Text = selectedPopolari.Ascolti.ToString();
        }
    }
}