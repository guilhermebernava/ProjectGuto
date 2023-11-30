using Domain.Entities;
using Domain.Repositories;
using Infra.Data;

namespace Infra.Repositories;

public class ArtistaRepository : Repository<Artista>, IArtistaRepository
{
    public ArtistaRepository(AppDbContext db) : base(db)
    {
    }
}

