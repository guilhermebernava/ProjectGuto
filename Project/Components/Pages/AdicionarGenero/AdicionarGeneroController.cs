using Domain.Entities;
using Domain.Repositories;

namespace Project.Components.Pages.AdicionarGenero;

public class AdicionarGeneroController
{
    public AdicionarGeneroController(IGeneroRepository generoRepository)
    {
        _generoRepository = generoRepository;
    }

    private IGeneroRepository _generoRepository { get; set; }

    public async Task<bool> AdicionarGenero(Genero genero)
    {
        return await _generoRepository.AddAsync(genero);
    }
}
