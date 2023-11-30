using Domain.Entities;
using Domain.Repositories;
using Infra.Data;

namespace Infra.Repositories;

public class GeneroRepository : Repository<Genero>, IGeneroRepository
{
    public GeneroRepository(AppDbContext db) : base(db)
    {
    }
}

