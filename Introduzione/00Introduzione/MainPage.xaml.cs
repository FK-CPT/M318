namespace _00Introduzione
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        //Evento che permette di stampare nel label il contenuto dell'entry

        private void CounterBtn_Clicked(object sender, EventArgs e)
        {
            //if controlla se la stringa è nulla o vuota
            if (String.IsNullOrWhiteSpace(entName.Text))
            {
                lbName.Text = "Ciao a tutti";
            }
            else 
            { 
                lbName.Text = "Ciao " + entName.Text;
            }
        }
    }
}