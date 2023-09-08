using Dominio.Entities.Principales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class DiagnosticoConfiguration : IEntityTypeConfiguration<Diagnostico>
{
    public void Configure(EntityTypeBuilder<Diagnostico> builder)
    {
        builder.ToTable("diagnostico");

        builder.Property(p => p.Descripcion)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Orden)
        .WithMany(p => p.Diagnosticos)
        .HasForeignKey(p => p.IdOrdenFk);

        builder.HasOne(p => p.Empleado)
        .WithMany(p => p.Diagnosticos)
        .HasForeignKey(p => p.IdEmpleadoFk);
    }
}