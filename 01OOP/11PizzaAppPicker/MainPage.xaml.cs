namespace _11PizzaAppPicker
{
    public partial class MainPage : ContentPage
    {
        List <Pizza> pizze = new List<Pizza>();
        Pizza margherita = new Pizza("Margherita", "peperoncino.jpg", 8, "margherita.jpg", "pomodoro, mozzarella, basilico fresco, sale e olio");
        Pizza funghi = new Pizza("Funghi", "peperoncino.jpg", 10, "mushroom.jpg", "mozzarella, salsa di pomodoro, basilico o origano, frutti di mare, formaggi e funghi");
        Pizza capricciosa = new Pizza("Capricciosa", "peperoncino.jpg", 12, "capricciosa.jpg", "funghi, carciofini, acciughe e olive");
        Pizza quattroFormaggi = new Pizza("Quattro Formaggi", "peperoncino.jpg", 11, "quattroformaggi.jpg", "pomodoro, mozzarella, gorgonzola, fontina, parmigiano-reggiano");
        Pizza salami = new Pizza("Salami", "peperoncino.jpg", 15, "salami.jpg", "mozzarella, salsa di pomodoro, salame piccante, origano");

        public MainPage()
        {
            InitializeComponent();
            pizze.Add(margherita);
            pizze.Add(funghi);
            pizze.Add(capricciosa);
            pizze.Add(quattroFormaggi);
            pizze.Add(salami);
            pickPizza.ItemsSource = pizze;
        }

        private void ImpostaPiccante()
        {
            imPep1.IsVisible = true;
            imPep2.IsVisible = true;
            imPep3.IsVisible = true;

            if (pickPizza.Piccante == 1)
            {
                imPep1.IsVisible = true;
            }

            else if (pickPizza.Piccante == 2)
            {
                imPep1.IsVisible = true;
                imPep2.IsVisible = true;
            }
            else
            {
                imPep1.IsVisible = true;
                imPep2.IsVisible = true;
                imPep3.IsVisible = true;
            }

        private void pickPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza pizze = (Pizza)pickPizza.SelectedItem;
            lblNome.Text = "Pizza " + pizze.Nome;
            lblPrezzo.Text = pizze.Prezzo.ToString() + " Fr .-";
            lblIngredienti.Text = "Ingredienti: " + pizze.Ingredienti;
            imagePizza.Source = pizze.Image;
        }

        private void stepVoto_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            entVoto.Text = stepVoto.Value.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }

}
