using Domain.Entities;
using Domain.Repositories;

namespace Project.Components.Pages.Home;

public class HomeController
{
    public HomeController(IConteudoRepository conteudoRepository)
    {
        _conteudoRepository = conteudoRepository;
    }

    private IConteudoRepository _conteudoRepository { get; set; }

    public async Task<List<Conteudo>> PegarConteudos()
    {
        var conteudos = await _conteudoRepository.GetAllAsync();
        return conteudos.Take(10).ToList();
    }
}
