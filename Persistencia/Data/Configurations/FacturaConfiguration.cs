using Dominio.Entities.Principales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
{
    public void Configure(EntityTypeBuilder<Factura> builder)
    {
        builder.ToTable("factura");

        builder.Property(p => p.Subtotal)
        .IsRequired()
        .HasColumnType("decimal");

        builder.Property(p => p.Iva)
        .IsRequired()
        .HasColumnType("decimal");

        builder.Property(p => p.ManoObra)
        .IsRequired()
        .HasColumnType("decimal");

        builder.Property(p => p.Total)
        .IsRequired()
        .HasColumnType("decimal");

        builder.HasOne(p => p.Orden)
        .WithMany(p => p.Facturas)
        .HasForeignKey(p => p.IdOrdenFk);

        builder.HasOne(p => p.Cliente)
        .WithMany(p => p.Facturas)
        .HasForeignKey(p => p.IdClienteFk);
    }
}