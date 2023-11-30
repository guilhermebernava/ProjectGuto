using Domain.Entities;
using Domain.Repositories;
using Infra.Data;

namespace Infra.Repositories;

public class ConteudoRepository : Repository<Conteudo>, IConteudoRepository
{
    public ConteudoRepository(AppDbContext db) : base(db)
    {
    }
}

