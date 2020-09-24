using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokedex.BLL
{
    public class PokemonsBLL
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private string descricao;

		public string Descricao
		{
			get { return descricao; }
			set { descricao = value; }
		}


	}
}