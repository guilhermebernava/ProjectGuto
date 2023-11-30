using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations;

public class ConteudoConfiguration : EntityConfiguration<Conteudo>
{
    public override void Configure(EntityTypeBuilder<Conteudo> builder)
    {
        base.Configure(builder);

        builder.Property(u => u.Diretor).IsRequired();
        builder.Property(u => u.Preco).IsRequired();
        builder.Property(u => u.Situacao).IsRequired();
        builder.Property(u => u.Ano).IsRequired();
        builder.Property(u => u.Capa).IsRequired();
        builder.Property(u => u.CodigoDeBarra).IsRequired();
        builder.Property(u => u.DataAdquirido).IsRequired();
        builder.Property(u => u.Titulo).IsRequired();
        builder.Property(u => u.ValorCusto).IsRequired();
        builder.Property(u => u.Tipo).IsRequired();
    }
}

