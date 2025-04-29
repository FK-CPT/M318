using CatalogoVideogame.Models;

namespace CatalogoVideogame
{
    public partial class MainPage : ContentPage
    {

        List<Videogame> videogames = new List<Videogame>();
        public MainPage()
        {
            InitializeComponent();
            videogames.Add(new Videogame("Minecraft", "Mojang, Stoccolma, Svezia", "OpenWorld", "", "minecraft.png"));
            videogames.Add(new Videogame("Rainbow Six Siege", "Ubisoft, Saint - Mandé, Francia", "Sparatutto 5 vs 5", "", "r6.png"));
            videogames.Add(new Videogame("GTA 5", "Rockstar Games, New York, USA", "OpenWorld", "", "gta5.png"));
            pickVideogioco.ItemsSource = videogames;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Videogame selectedVideogame = (Videogame)pickVideogioco.SelectedItem;
            entTitolo.Text = selectedVideogame.Title;
            entSviluppatore.Text = selectedVideogame.Developer.ToString();
            editDescrizzione.Text = selectedVideogame.Description;
            imgVideogame.Source = selectedVideogame.Image.ToString();
        }
    }
}