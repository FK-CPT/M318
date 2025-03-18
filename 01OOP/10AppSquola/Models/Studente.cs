using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10AppSquola.Models
{
    internal class Studente
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _cognome;

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        private string _dataDiNascita;

        public string DataDiNascita
        {
            get { return _dataDiNascita; }
            set { _dataDiNascita = value; }
        }

        private string _id;

        public string ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public Studente(string nome, string cognome, string dataDiNascita)
        {
            _nome = nome;
            _cognome = cognome;
            _dataDiNascita = dataDiNascita;
            GenerateID();
        }

        public void GenerateID()
        {
            var min = DataDiNascita.Length - 4;
            string anno = DataDiNascita.Substring(DataDiNascita.Length - 4);
            ID = Nome.Substring(0, 3) + Cognome.Substring(0, 2) + anno;
        }

        public override string? ToString()
        {
            return $"Nome: {Nome};          Cognome: {Cognome};          Identificativo: {ID}";
        }
    }
}
