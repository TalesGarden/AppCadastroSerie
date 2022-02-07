using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
    private bool Excluido {get; set;}
		private int rank { get; set; }

        // Métodos
		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
      this.Excluido = false;

			//Numero de estrelas da série - 0 á 5
			Random rnd = new Random();
			this.rank = rnd.Next(6);
		}
		

    public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
						retorno += "Rank: " + ImprimirEstrelas(this.rank)  + Environment.NewLine;
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

		private string ImprimirEstrelas(int numEstrelas)
		{
			string retornoEstrelas = "";
			if (numEstrelas == 0) return retornoEstrelas;

			for (int i = 0; i < numEstrelas; i++)
			{
				retornoEstrelas += " *";
			}
			return retornoEstrelas;

		}
    }
}