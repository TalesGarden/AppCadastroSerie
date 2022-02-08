using System;
using System.Collections.Generic;
namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
		private List<Genero> Genero = new List<Genero>();

		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
    private bool Excluido {get; set;}
		private int Rank { get; set; }

        // Métodos
		public Serie(int id, List<Genero> genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
      this.Excluido = false;

			//Numero de estrelas da série - 0 á 5
			Random rnd = new Random();
			this.Rank = rnd.Next(6);
		}
		

    public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + ImprimirGenero() + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
						retorno += "Rank: " + ImprimirEstrelas()  + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;

			return retorno;
		}

    public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
		public void Excluir() 
		{
            this.Excluido = true;
    }

		private string ImprimirEstrelas()
		{
			string retornoEstrelas = "";
			if (this.Rank == 0) return retornoEstrelas;

			for (int i = 0; i < this.Rank; i++)
			{
				retornoEstrelas += " *";
			}
			return retornoEstrelas;

		}
		private string ImprimirGenero()
		{
			string todosGeneros = "";
			foreach (var genero in Genero)
			{
				todosGeneros +=$"{genero.ToString()}, " ;
			}
			return todosGeneros;
		}
    }
}