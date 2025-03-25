using _03AppListe.Models;

namespace _03AppListe
{
    public partial class MainPage : ContentPage
    {
        List<Frutto> frutti = new List<Frutto>();//Lista di frutti
        Frutto mela = new Frutto("Mela", "Italia");
        Frutto pera = new Frutto("Pera", "Spagna");
        Frutto cocco = new Frutto("Cocco", "Indonesia");
        Frutto avocado = new Frutto("Avocado", "Messico");

        public MainPage()
        {
            InitializeComponent();
            frutti.Add(mela);
            frutti.Add(pera);
            frutti.Add(cocco);
            frutti.RemoveAt(2);
            frutti.Insert(1, avocado);
            entFrutto.Text = frutti[0].Nome;

            pickFrutti.ItemsSource = frutti;

            foreach (Frutto item in frutti)
            {
                editFrutti.Text += item + "\n";
            }
        }

        private void pickFrutti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Frutto selectFruit = (Frutto) pickFrutti.SelectedItem;
            entSelezione.Text = selectFruit.ToString();
        }
    }
}