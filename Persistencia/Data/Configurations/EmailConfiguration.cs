using Dominio.Entities.Principales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class EmailConfiguration : IEntityTypeConfiguration<Email>
{
    public void Configure(EntityTypeBuilder<Email> builder)
    {
        builder.ToTable("email");

        builder.Property(p => p.Direccion)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.TipoEmail)
        .WithMany(p => p.Emails)
        .HasForeignKey(p => p.IdTipoEmailFk);

        builder.HasOne(p => p.Persona)
        .WithMany(p => p.Emails)
        .HasForeignKey(p => p.IdPersonaFk);
    }
}