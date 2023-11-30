using Domain.Entities;
using Domain.Repositories;

namespace Project.Components.Pages.AdicionarArtista;

public class AdicionarArtistaController
{
    public AdicionarArtistaController(IArtistaRepository artistaRepository)
    {
        _artistaRepository = artistaRepository;
    }

    private IArtistaRepository _artistaRepository { get; set; }

    public async Task<bool> AdicionarArtista(Artista artista)
    {
        return await _artistaRepository.AddAsync(artista);
    }
}
