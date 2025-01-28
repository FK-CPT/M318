namespace _02Orologio
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            labelData.Text = "" + DateTime.Now;
        }
    }

}
