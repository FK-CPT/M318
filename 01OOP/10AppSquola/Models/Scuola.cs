using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10AppSquola.Models
{
    internal class Scuola
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _indirizzo;

        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }

        private string _tipologia;

        public string Tipologia
        {
            get { return _tipologia; }
            set { _tipologia = value; }
        }

        private Studente[] _students;

        public Studente[] Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public Scuola(string nome, string indirizzo, string tipologia, Studente[] students)
        {
            _nome = nome;
            _indirizzo = indirizzo;
            _tipologia = tipologia;
            _students = students;
        }
    }
}
