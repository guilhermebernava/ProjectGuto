using Domain.Entities;
using Domain.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories;

public class ConteudoRepository : Repository<Conteudo>, IConteudoRepository
{
    public ConteudoRepository(AppDbContext db) : base(db)
    {
    }

    public async Task<List<Conteudo>> GetByParameterAsync(string parameter)
    {
        var conteudos = new List<Conteudo>();
        var conteudosPorNomeDoFilme = await dbSet.Where(_ => EF.Functions.Like(_.Titulo, $"%{parameter}%")).ToListAsync();
        var conteudosPorNomeDeArtista = await _db.Artistas.Include(_ => _.Conteudos).Where(_ => EF.Functions.Like(_.Nome, $"%{parameter}%")).ToListAsync();
        var conteudosPorNomeDeGenero = await _db.Generos.Include(_ => _.Conteudos).Where(_ => EF.Functions.Like(_.Nome, $"%{parameter}%")).ToListAsync();

        await Task.Run(() =>
        {
            conteudos.AddRange(conteudosPorNomeDoFilme);
            foreach (var conteudo in conteudosPorNomeDeArtista)
            {
                conteudos.AddRange(conteudo.Conteudos);
            }

            foreach (var conteudo in conteudosPorNomeDeGenero)
            {
                conteudos.AddRange(conteudo.Conteudos);
            }

            var semDuplicadas = new HashSet<Conteudo>(conteudos);
            conteudos = new List<Conteudo>(semDuplicadas);
        });

        return conteudos;
    }
}

