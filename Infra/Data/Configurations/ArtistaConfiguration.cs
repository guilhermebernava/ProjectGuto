using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations;

public class ArtistaConfiguration : EntityConfiguration<Artista>
{
    public override void Configure(EntityTypeBuilder<Artista> builder)
    {
        base.Configure(builder);

        builder.Property(u => u.Nome).IsRequired();
        builder.Property(u => u.DataNascimento).IsRequired();
        builder.Property(u => u.PaisNascimento).IsRequired();
        builder.Property(u => u.Foto).IsRequired();        
        builder.HasMany(_ => _.Conteudos).WithMany(_ => _.Artistas);
    }
}
