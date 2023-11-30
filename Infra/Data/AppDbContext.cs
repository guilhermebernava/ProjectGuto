using Domain.Entities;
using Infra.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class AppDbContext : IdentityDbContext
{
    public DbSet<Conteudo> Conteudos { get; set; }
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Genero> Generos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ConteudoConfiguration());
        builder.ApplyConfiguration(new ArtistaConfiguration());
        builder.ApplyConfiguration(new GeneroConfiguration());
    }
}
