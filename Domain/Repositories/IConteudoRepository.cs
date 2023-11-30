using Domain.Entities;

namespace Domain.Repositories;

public interface IConteudoRepository : IRepository<Conteudo>
{
    Task<List<Conteudo>> GetByParameterAsync(string parameter);
}
