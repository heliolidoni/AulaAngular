using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
