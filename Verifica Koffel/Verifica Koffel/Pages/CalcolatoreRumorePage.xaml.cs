namespace Verifica_Koffel;

public partial class CalcolatoreRumorePage : ContentPage
{
	public CalcolatoreRumorePage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		int decibel = Convert.ToInt32(entDecibel.Text);

		if (decibel >= 0 && decibel < 11)
		{
            entSoglia.Text = "Accettabile - Respiro";
		}

		if (decibel >= 10 && decibel < 21)
		{
            entSoglia.Text = "Accettabile - Fruscio";
		}

		if (decibel >= 20 && decibel < 31)
		{
            entSoglia.Text = "Accettabile - Bisbiglio";
		}

        if (decibel >= 30 && decibel < 41)
        {
            entSoglia.Text = "Accettabile - Frigorifero";
        }

        if (decibel >= 40 && decibel < 51)
        {
            entSoglia.Text = "Moderato - Pioggia Moderata";
        }

        if (decibel >= 50 && decibel < 61)
        {
            entSoglia.Text = "Moderato - Conversazione";
        }

        if (decibel >= 60 && decibel < 71)
        {
            entSoglia.Text = "Forte - Traffico";
        }

        if (decibel >= 70 && decibel < 81)
        {
            entSoglia.Text = "Forte - Camion";
        }

        if (decibel >= 80 && decibel < 91)
        {
            entSoglia.Text = "Troppo Forte - Asciugacapelli";
        }

        if (decibel >= 90 && decibel < 101)
        {
            entSoglia.Text = "Troppo Forte - Elicottero";
        }

        if (decibel >= 100 && decibel < 111)
        {
            entSoglia.Text = "Troppo Forte - Trombone";
        }

        if (decibel >= 110 && decibel < 121)
        {
            entSoglia.Text = "Soglia del Dolore - Sirena della Polizzia";
        }

        if (decibel >= 120 && decibel < 131)
        {
            entSoglia.Text = "Soglia del Dolore - Motore a Reazione";
        }

        if (decibel >= 130 && decibel < 141)
        {
            entSoglia.Text = "Soglia del Dolore - Fuochi d'Artificio";
        }
    }
}