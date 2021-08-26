using System;

namespace series
{
  public class Serie : EntidadeBase
  {
    //Atributos
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }


    //Metodos
    public Serie(int id, Genero genero, string titulo, string decricao, int ano)
    {
      this.Id = id;
      this.Genero = genero;
      this.Descricao = decricao;
      this.Ano = ano;
    }
    public override string ToString()
//Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
{
    string retorno = "";
    retorno += "Genero: " + this.Genero + Environment.NewLine;
    retorno += "Título: " + this.Titulo + Environment.NewLine;
    retorno += "Descrição" + this.Descricao + Environment.NewLine;
    retorno += "Ano de Início: " + this.Ano;
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
