using Dominio.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
