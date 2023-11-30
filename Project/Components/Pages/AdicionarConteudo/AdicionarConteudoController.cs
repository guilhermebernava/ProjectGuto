using Domain.Entities;
using Domain.Repositories;

namespace Project.Components.Pages.AdicionarConteudo;

public class AdicionarConteudoController
{
    public AdicionarConteudoController(IConteudoRepository conteudoRepository)
    {
        _conteudoRepository = conteudoRepository;
    }

    private IConteudoRepository _conteudoRepository { get; set; }

    public async Task<bool> AdicionarConteudo(Conteudo conteudo)
    {
        return await _conteudoRepository.AddAsync(conteudo);
    }
}
