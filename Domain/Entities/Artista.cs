namespace Domain.Entities;

public class Artista : Entity
{
    public Artista(string nome, DateTime dataNascimento, string paisNascimento, string foto)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        PaisNascimento = paisNascimento;
        Foto = foto;
    }

    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string PaisNascimento { get; set; }
    public string Foto { get; set; }
    public virtual List<Conteudo> Conteudos { get; set; }
}
