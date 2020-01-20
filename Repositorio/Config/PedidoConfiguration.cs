using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido> 
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(u => u.Cidade)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(u => u.Estado)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.NumeroEndereco)
                .IsRequired();

            builder
                .Property(u => u.DataPedido)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.DataPrevisaoEntrega)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
