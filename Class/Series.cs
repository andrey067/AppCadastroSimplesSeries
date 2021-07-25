using System;
using DIO.Series.Class;
using DIO.Series.Shared;

namespace DIO.Series
{
    public class Series : BaseEntitie
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Series(string number,Genero genero, string titulo, string descricao, int ano)
        {          
            Number = number;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public void Excluir()
        {
            Excluido = true;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public string retornaId()
        {
            return this.Id.ToString();
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }
}