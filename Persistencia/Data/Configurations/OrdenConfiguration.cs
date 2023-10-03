using Dominio.Entities.Principales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
{
    public void Configure(EntityTypeBuilder<Orden> builder)
    {
        builder.ToTable("orden");

        builder.Property(p => p.Registro)
        .IsRequired()
        .HasColumnType("DateTime");

        builder.Property(p => p.DiagnosticoCliente)
        .IsRequired();

        builder.Property(p => p.Estado)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Cliente)
        .WithMany(p => p.ClienteOrdenes)
        .HasForeignKey(p => p.IdClienteFk);

        builder.HasOne(p => p.Manager)
        .WithMany(p => p.ManagerOrdenes)
        .HasForeignKey(p => p.IdManagerFk);

        builder.HasOne(p => p.Vehiculo)
        .WithMany(p => p.Ordenes)
        .HasForeignKey(p => p.IdVehiculoFk);
    }
}