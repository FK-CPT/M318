using _10AppSquola.Models;

namespace _10AppSquola;

public partial class StudentePage : ContentPage
{

	Studente[] students = {
		new Studente("Nobita", "Nobi", "10.06.2013"),
        new Studente("Suneo", "Honekawa", "29.02.2013"),
        new Studente("Shizuka", "Minamoto", "09.05.2013"),
        new Studente("Gian", "Tekeshi", "15.06.2013")
    };
	Scuola scuola;

	public StudentePage()
	{
		InitializeComponent();
		scuola = new Scuola("Nerima School", "Tokio", "Elementare", students);
		entNome.Text = scuola.Nome;
		entTipologia.Text = scuola.Tipologia;
		foreach (Studente student in scuola.Students)
		{
			editStudenti.Text += student + "\n";
		}
	}
}