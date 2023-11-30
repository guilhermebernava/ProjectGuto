namespace Domain.Entities;

public class Genero : Entity
{
    public Genero()
    {
        
    }
    public Genero(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public virtual List<Conteudo> Conteudos { get; set; }
}
