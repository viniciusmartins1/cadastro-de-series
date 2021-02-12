using System;

namespace DIO.Series
{
    public class Series : EntidadeBase
    {
        //Atributos

        public Series(Genero genero, string titulo, string descricao, int ano) 
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
               
        }
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}

        //Metodos
        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
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
    }
}