using Domain.Enums;

namespace Domain.Entities;

public class Conteudo : Entity
{
    public Conteudo()
    {
        DataAdquirido = DateTime.Now;
    }
    public Conteudo(string codigoDeBarra, string titulo, int ano, EFilmeTipo tipo, double preco, DateTime dataAdquirido, double valorCusto, ESituacao situacao, string diretor, string capa)
    {
        CodigoDeBarra = codigoDeBarra;
        Titulo = titulo;
        Ano = ano;
        Tipo = tipo;
        Preco = preco;
        DataAdquirido = dataAdquirido;
        ValorCusto = valorCusto;
        Situacao = situacao;
        Diretor = diretor;
        Capa = capa;
    }

    public string CodigoDeBarra { get; set; }
    public string Titulo { get; set; }

    public int Ano { get; set; }
    public EFilmeTipo Tipo { get; set; }
    public double Preco { get; set; }
    public DateTime DataAdquirido { get; set; }
    public double ValorCusto { get; set; }
    public ESituacao Situacao { get; set; }
    public string Diretor { get; set; }
    public string Capa { get; set; }

    public virtual List<Genero> Generos { get; set; }
    public virtual List<Artista> Artistas { get; set; }
}
