﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11PizzaAppPicker
{
    internal class Pizza
    {
		private string _nome;

		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		private float _prezzo;

		public float Prezzo
		{
			get { return _prezzo; }
			set { _prezzo = value; }
		}

		private string _image;

		public string Image
		{
			get { return _image; }
			set { _image = value; }
		}

		private string _ingredienti;

		public string Ingredienti
		{
			get { return _ingredienti; }
			set { _ingredienti = value; }
		}

		public int Piccante { get; set; }

        public Pizza(string nome, string piccanzezza, float prezzo, string image, string ingredienti, int piccante)
		{
			if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(image) || String.IsNullOrEmpty(ingredienti) || prezzo <= 0)
			{
				throw new ArgumentException("Inizializzazione con valori non consentiti");
			}
			else
			{
				_nome = nome;
				_prezzo = prezzo;
				_image = image;
				_ingredienti = ingredienti;
				Piccante = piccante;
			}
		}

        public override string? ToString()
        {
            return $"Pizza {Nome}";
        }
    }
}
