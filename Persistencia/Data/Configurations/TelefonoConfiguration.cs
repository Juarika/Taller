using Dominio.Entities.Principales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class TelefonoConfiguration : IEntityTypeConfiguration<Telefono>
{
    public void Configure(EntityTypeBuilder<Telefono> builder)
    {
        builder.ToTable("telefono");

        builder.Property(p => p.Numero)
        .IsRequired()
        .HasMaxLength(50);
        
        builder.HasOne(p => p.TipoTelefono)
        .WithMany(p => p.Telefonos)
        .HasForeignKey(p => p.IdTipoTelefonoFk);

        builder.HasOne(p => p.Persona)
        .WithMany(p => p.Telefonos)
        .HasForeignKey(p => p.IdPersonaFk);
    }
}