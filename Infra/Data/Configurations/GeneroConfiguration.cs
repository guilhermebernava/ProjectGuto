using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations;

public class GeneroConfiguration : EntityConfiguration<Genero>
{
    public override void Configure(EntityTypeBuilder<Genero> builder)
    {
        base.Configure(builder);

        builder.Property(u => u.Nome).IsRequired();
        builder.HasMany(_ => _.Conteudos).WithMany(_ => _.Generos);
    }
}
