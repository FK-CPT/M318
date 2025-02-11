using System;
using Microsoft.Maui.Controls;

namespace _05Equation
{
    public partial class MainPage : ContentPage
    {
        double a;
        double b;
        double c;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        { 
            if (!double.TryParse(entryA.Text, out double a) || !double.TryParse(entryB.Text, out double b) || !double.TryParse(entryC.Text, out double c))
            {
                resultLabel.Text = "Inserisci solo valori numerici validi!";
                resultLabel.TextColor = Colors.Red;
            }

            if (a == 0)
            {
                resultLabel.Text = "Il coefficiente A non può essere 0!";
                resultLabel.TextColor = Colors.Red;
            }

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                resultLabel.Text = "Soluzioni: x1 = x1, x2 = x2";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                resultLabel.Text = "Soluzione unica: x = x";
            }
            else
            {
                resultLabel.Text = "Nessuna soluzione nell'insieme dei numeri reali.";
                resultLabel.TextColor = Colors.Red;
            }
        }
    }
}