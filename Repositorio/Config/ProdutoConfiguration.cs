using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Descricao)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(u => u.Descricao)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(u => u.Preco)
                .IsRequired();
        }
    }
}
