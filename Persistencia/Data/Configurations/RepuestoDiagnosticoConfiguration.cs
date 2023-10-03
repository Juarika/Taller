using Dominio.Entities.Principales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class RepuestoDiagnosticoConfiguration : IEntityTypeConfiguration<RepuestoDiagnostico>
{
    public void Configure(EntityTypeBuilder<RepuestoDiagnostico> builder)
    {
        builder.ToTable("repuestoDiagnostico");

        builder.Property(p => p.Cantidad)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.Aprobado);
        
        builder.HasOne(p => p.Repuesto)
        .WithMany(p => p.RepuestoDiagnosticos)
        .HasForeignKey(p => p.IdRepuestoFk);

        builder.HasOne(p => p.Diagnostico)
        .WithMany(p => p.RepuestoDiagnosticos)
        .HasForeignKey(p => p.IdDiagnosticoFk);

        builder.HasKey(p => new {p.IdRepuestoFk, p.IdDiagnosticoFk});
    }
}